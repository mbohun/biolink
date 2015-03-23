# Creating a new BioLink database #

BioLink uses Microsoft SQL Server as its backing data store. Microsoft has made available a free edition of SQL Server called SQL Server Express. SQL Server Express is fully featured, but has some limitations that makes it impractical for medium to large scale use. For single/small number user scenarios, however, it is quite acceptable.

Because BioLink makes heavy use of stored procedures, triggers and other database features, the easiest way to configure a new database is to start with an existing blank database, and simply "attach" that to a SQL Server instance. This guide will walk through the steps of installing SQL Server and attaching a blank BioLink database (available for download from the Downloads section).

## Installing SQL Server ##

BioLink requires a connection to a SQL Server database instance. Installing a new BioLink database is simply a matter of 'attaching' the starter database file to the SQL Server database, and then connecting to it using the BioLink application.

In order to attach the BioLink starter database you will need administrative privileges on the SQL Server.  If you already have administrative access to a SQL Server 2008 [R2](https://code.google.com/p/biolink/source/detail?r=2) instance, you can skip this step.

**Note:** At the time of writing, the supplied "starter database" is compatible with  SQL Server 2008 [R2](https://code.google.com/p/biolink/source/detail?r=2) or greater only. Existing BioLink databases running on older versions of SQL Server can be connected to using the BioLink client without any issues, however.

  * Download and install SQL Server 2008 [R2](https://code.google.com/p/biolink/source/detail?r=2) from [here](http://www.microsoft.com/sqlserver/en/us/editions/express.aspx*).

**Note:** During the installation of SQL Server you will be prompted to enter a name for your database instance. The full name of your database instance will be the name of your computer + a slash + the name that you entered. For example, if you choose to call your database instance `biolink`, the full name of the database instance will be `<yourcomputername>\biolink`. You will need to know the full name of the database instance in order to connect to it.

In addition, you should also allow "SQL Server" authentication mode (mixed mode). This will allow you to more easily manage your user accounts. This mode can be disabled once a BioLink user user has been created that can manage users.

  * Download and install the SQL Server Management Management Studio Express from [here](http://www.microsoft.com/download/en/details.aspx?id=22985).

  * Download the BioLink starter database from [here](http://code.google.com/p/biolink/downloads/detail?name=BioLinkStarter.mdf).

### Attaching the Starter Database ###

After installing both SQL Server and the SQL Server Management Studio, start SQL Server Management Studio, and when prompted, connect to your running SQL Server instance.

![http://biolink.googlecode.com/svn/wiki/SQLMSConnect.png](http://biolink.googlecode.com/svn/wiki/SQLMSConnect.png)

Once connected, expand and right click on the "Databases" node, and select "Attach..."

![http://biolink.googlecode.com/svn/wiki/Attach1.png](http://biolink.googlecode.com/svn/wiki/Attach1.png)

Click on the "Add button"

![http://biolink.googlecode.com/svn/wiki/Attach2.png](http://biolink.googlecode.com/svn/wiki/Attach2.png)

And select the file that you have just downloaded (BiolinkStarter.mdf). It will probably be in your downloads directory.

![http://biolink.googlecode.com/svn/wiki/Attach3.png](http://biolink.googlecode.com/svn/wiki/Attach3.png)

Once the MDF file has been added, you can rename the "Attach as" field. This is name of the actual database, so choose a name that represents its purpose. For the sake of this guide the name "Biolink" has been entered.

![http://biolink.googlecode.com/svn/wiki/Attach4.png](http://biolink.googlecode.com/svn/wiki/Attach4.png)

The SQL Server Management Studio will automatically add a log file entry under the database details. This needs to be removed, as a log file (LDF) will be created automatically when the database is attached. Selected the log file in the lower pane, and click "Remove".

![http://biolink.googlecode.com/svn/wiki/Attach5.png](http://biolink.googlecode.com/svn/wiki/Attach5.png)

Press OK on the "Attach Databases" dialog, and you should now see your database underneath the Databases node in the Management tree.

![http://biolink.googlecode.com/svn/wiki/Attach6.png](http://biolink.googlecode.com/svn/wiki/Attach6.png)


Once this step has been completed, you can close down the SQL Server Management Studio, and [install](InstallBiolink.md) the BioLink application