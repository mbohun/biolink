# Technical overview #

## Legacy Design ##

The original BioLink (versions 2.5 and prior) where primarily written in Microsoft Visual Basic 6.0, with some performance critical functionality implemented in C/C++. BioLink was designed with a 'N-Tier' architecture, comprising of 3 tiers (client, middle and storage). The client tier was a collection of COM components composed by a single executable process, and interaction between components was achieved via a relatively crude manual dynamic string dispatch mechanism. The middle tier abstracts database access, and some business rules, behind logical services, and comprised multiple DCOM server processes, one for roughly each major component in BioLink (Taxonomy, Specimens etc). The client tier communicated with the middle tier by making DCOM method calls, and because of the difficulty of defining and marshaling complex data types in Visual Basic, row sets are marshalled as 2 dimensional COM 'Safearrays' of Variants. The Middle tier made use of Microsoft's Active Data Object (ADO) library to execute queries and retrieve results.


## Version 3.0 Design ##

Generally the overall design of version 3 is a simplification of its predecessor. Logically the three separate tiers still exist, but rather than having an active middle tier that can be run out of process, data access and typical "middle" tier concerns are implemented as in-process library calls. This greatly simplifies deployment, but still allows for data access code to be decoupled from the UI should an alternate front end be required (such as a web interface, for example).

### Packaging overview ###

![http://biolink.googlecode.com/svn/wiki/TechnicalDesign.attach/Overview.png](http://biolink.googlecode.com/svn/wiki/TechnicalDesign.attach/Overview.png)

### Data Access Layer ###

Nearly all of the interaction between the application and the database is achieved via stored procedures. The only exceptions to this are:

  * The extraction of multimedia bytes
  * New features for which no stored procedures yet exist
  * temporary workarounds for issues with current stored procedures

Communication with the database server is achieved via ADO.NET (System.Sata.SqlClient). BioLink functions are grouped under individual 'service' objects (taxa, material, for example). All service objects inherit from `BioLinkService`, which provides convenience methods for calling stored procedures and mapping results to model objects. Services return model (or lists of model) objects, and some service methods (such as update and insert methods) accept model objects as parameters. The service layer in this sense abstracts away SQL Server as an implementation detail of the storage platform. The rule of thumb, then, is that no SQL Server implementation details are leaked outside of the service layer (i.e. it should be possible to re-implement the service layer using another RDBMS and clients need not be aware of the change.

#### Services ####

Services are the objects through which data is retrieved, inserted and updated in BioLink. Using the service paradigm provides a layer of abstraction between the application code and the database, and simplifies client code that is concerned with interacting with data. There are currently two main service types in BioLink: `BioLinkService` services are those that interact with the main SQL Server database that holds BioLink data.

![http://biolink.googlecode.com/svn/wiki/TechnicalDesign.attach/ServiceClasses.png](http://biolink.googlecode.com/svn/wiki/TechnicalDesign.attach/ServiceClasses.png)

The `SQLiteServiceBase` services are responsible for managing data held in local (to the client application) SQLite database instances.

![http://biolink.googlecode.com/svn/wiki/TechnicalDesign.attach/SQLiteServiceClasses.png](http://biolink.googlecode.com/svn/wiki/TechnicalDesign.attach/SQLiteServiceClasses.png)

#### Model objects ####

Key nouns in BioLink are modelled by classes (`Taxon`, `Material`, `Loan` for example). Model objects (also sometimes known as Data Transfer Objects, or more simply Transfer Objects) are simple 'structures' with properties (in actual fact, they are reference types - `class` not `struct`) that basically hold a single row of data from the results of a stored procedure (or SQL Query). Model objects should not have any logic in them, but rather are a vehicle for a collection of related data. All model objects inherit from `BioLinkDataObject` (or one of it's intermediate descendants). `BioLinkDataObject` itself has no members (other than ObjectID, discussed below), but is rather like a marker class. Some model objects have GUID's associated with them, and inherit from `GUIDObject`. Some model objects also contain ownership information (who created, last updated etc.). These objects inherit from `OwnedDataObject`.

![http://biolink.googlecode.com/svn/wiki/TechnicalDesign.attach/DataObjects.png](http://biolink.googlecode.com/svn/wiki/TechnicalDesign.attach/DataObjects.png)

##### ObjectID #####

Just about all objects in BioLink have an integer id that corresponds to its (internal) database identifier. Because of this it makes sense for the base class for all model objects to expose that object id. Each object, however, has a different column that holds it's id (`intTaxonID` vs `intMaterialID`, for example). Because of this BioLinkDataObject exposes a single `ObjectID` property, and declares an abstract `Expression` property called `IdentityExpression` that all subclasses must implement. This expression property should yield a function that returns an integer (which would be the Object ID for the instance being queried). In this way a `BioLinkDataObject` subclass provides an expression that yields its object identifier that will be exposed via the `ObjectID` property.

For example, in the `Taxon` class:

```
    protected override Expression<Func<int>> IdentityExpression {
        get { return () => this.TaxaID.Value; }
    }
```

#### Mapping (Object Relational Mapping) ####

Data is returned from SQL Server via a `SqlDataReader` object. Because the service layer should only return model objects, the data held by the reader needs to be mapped into a model object (or a list of model objects, if the operation returns multiple rows). Many of the convenience methods provided by `BiolinkService` accept a `GenericMapper<T>` that can convert the row data into instances of type T. A `GenericMapper` can be built automatically using the `GenericMapperBuilder<T>`, which will generate a mapper for type T that uses type introspection (or reflection) to extract column data from the data reader based on the property names held in type T.

For example, here is the service method for retrieving the `Loan`s for a contact.
```
    public List<Loan> ListLoansForContact(int contactID) {
        var mapper = new GenericMapperBuilder<Loan>().build();
        return StoredProcToList("spLoanListForContact", mapper, _P("intContactID", contactID));
    }
```

The `GenericMapperBuilder<T>` allows further customisation of the mapping process, including type conversions and special handling.

Reflective/Introspective mapping works by going through every column in the record set and attempting to locate a property on the target object whose name matches the column name, and setting the value of that property with the value held in the column for the current row. The following list describes the heuristics used by the reflective mapper, and how it can be otherwise influenced:

  * Column mapping objects can be passed in that override the mapping behaviour for selected columns
  * A `MappingInfo` attribute can also be applied to a model property in order to force a column name to be mapped explicitly to that property
  * If no mapping info is supplied, a property with the same name as the column is searched for
  * If no property is found, columns that start with the prefixes `chr`,`vchr`,`bit`,`int`,`txt`,`flt`,`tint`,`dt`,`sint` or `img` have this prefix stripped, and a property is searched for whose name matches the modified name

The reason for these heuristics is that the BioLink stored procedures return inconsistent results. Some return column names that include the type prefix (`vchr`, `int` etc.), and others don't. Also, some stored procedures return the same logical column using different abbreviations, making automatic mapping using just the name impossible.

**Note** It was originally anticipated that reflective mapping would prove too inefficient to be used in all circumstances (like retrieving long lists of results). The contingency planned for these cases was the intention of writing 'custom' mappers that explicitly map columns to properties without the cost of reflection. The actual performance of the reflective mapper, however, has proved sufficient that no custom mappers have yet been required.

#### Data matrices ####

Some service methods return raw table results that do not conform to a Model object (such as query and report results whose columns may not be known at design time). These methods return a `DataMatrix` which is a simple abstraction of tabular data. A `DataMatrix` has columns and rows, and not much else. There is the facility to programmatically add 'virtual' columns whose values are computed, possibly by aggregating other column values, but usually the matrix is a direct replication of the rowset returned from the stored procedure/query. The reason for this is to prevent the implementation detail of SQL Server from being leaked from the service layer. Data matrices are almost always displayed in a `TabularReportViewer`.

### The 'Database Command' pattern ###

One of the key usability features of BioLink is the way that changes are not applied immediately, but rather are held in a pending state until they are committed either by pressing 'OK' or 'Apply'. This means that a series of changes can be backed out by simply pressing cancel. In version 2.5 and earlier this was achieved by storing all changes in fairly complex 2 dimensional arrays, along with a flag indicating what kind of change is required (insert, update or delete). It was up to the middle layer, then, to interpret  the change flag, and apply the correct stored procedure depending on the nature of the data in the array. In version 3.0 this scheme has been replaced with a database 'Command' pattern. Typically user interface elements (such as WPF Controls or Windows) allow users to modify data that is held in _ViewModels_. _ViewModels_ raise property change events when bound data has been modified, and these change events can be hooked by the containing control or window. If the parent container is a Window, it should extend `ChangeContainerWindow`. If it is a control it should extend `ChangeContainerControl`. Either way, once a modification to data has been detected, a `DatabaseCommand` object can be registered with a `ChangeContainer`. A `DatabaseCommand` holds all the required information to commit that change. Many of the `DatabaseCommand`s contain references to a Model object, so that changes to multiple properties can be committed with a single `Update` command. For this reason there exists two methods of registering a database command: `RegisterPendingChange` and `RegisterUniquePendingChange`. `RegisterUniquePendingChange` will search any existing pending database commands for the same command (with the same arguments), and will only add it to the list of pending commands if one does not already exist. Insertions and Deletes happen in the same way - when an object is marked for delete, for example, the user interface is updated to indicate the result of the delete (in some cases this is via strike through text, in other cases the element is removed), and a database command is registered that will actually perform the deletion within the database. Regardless of the type of database command (Insert, Update and Delete), the commands are held in a `Queue` until the users indicates that they should be committed (by either pressing Apply or Ok). A `Queue` is used to ensure that operations are committed in the same order in which the user triggered them. For example, an `insert` is usually followed immediately with an `Update`. If the `Update` command precedes the `Insert` and error will occur because the object being update won't exist.

The following steps are undertaken when the queue of pending changes is committed:

  * Each database command is given an opportunity to validate its data
  * Each pending database command is then queried for which security permissions are required in order to for it to execute
  * A new transaction is created via the `User` object.
  * For each database command
    * `User`s permissions are confirmed against the list of required permissions. If permission is not granted the save is aborted with an error message.
    * If so, each action is the executed
    * If an error occurs the entire transaction is rolled back, and an error message is displayed
  * If all database commands succeed, then the transaction is committed, and the list of pending database commands list cleared.

The database command pattern facilitates a single level of 'Undo', as well as providing a single point where permission checks can be performed. It also means that individual update, insert and delete operations can be described in a single class each with low coupling to other code. Change containers provide events that can be hooked that allow for meaningful user interface cues, indicating if there are unsaved changes or not.

### The Model View ViewModel pattern ###

The BioLink application UI uses the `Model View ViewModel` (MVVM) pattern quite extensively. More information about MVVM can be found at http://msdn.microsoft.com/en-us/magazine/dd419663.aspx. BioLink's particular implementation of makes use of wrapping `Model` objects with `ViewModel` objects, and reimplementing the relevant `Model` members as required.

...

# TODO #

  * Model View View-Model pattern
  * Plugin architecture
  * "Pinnable" objects and inter-plugin communication