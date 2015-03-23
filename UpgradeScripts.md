

Typically BioLink databases that are at schema version 2.5 do not need to be upgraded. However, a small number of enhancements have been made to the BioLink database schema since version 2.5 which may benefit some users. Users who have BioLink databases that have not been updated to schema version 2.5 (any version of BioLink prior to 2.5, including version 1.0 and 1.5) will need to update the database schema to version 2.5 in order for version 3.0 of the BioLink client application to work correctly.

In addition, an issue has been discovered in the stored procedure that is used to generate the Associates for Taxon report that can lead to incorrect or missing results, even though associates are known to exist. For this reason, there are a number of scripts available on the downloads page that could be applied depending on particular scenarios.

Below is a table of common scenarios, and which scripts should be applied.

| Scenario | Upgrade script |
|:---------|:---------------|
| Last version of BioLink used was 1.0-2.0.x | [Biolink\_V2\_5\_0\_Scripts.sql](http://code.google.com/p/biolink/downloads/detail?name=Biolink_V2_5_0_Scripts.sql) |
|                 | and [AssociateReportsPatch.sql](http://code.google.com/p/biolink/downloads/detail?name=AssociateReportsPatch.sql) |
| Last version of BioLink used as 2.5 | [AssociateReportsPatch.sql](http://code.google.com/p/biolink/downloads/detail?name=AssociateReportsPatch.sql) |
| Recommended for users, but not mandatory | [BioLink Web Extensions.sql](http://code.google.com/p/biolink/downloads/detail?name=BioLink%20Web%20Extensions.sql) |

## How to execute the scripts ##

**Note:** You will need administrator access to the SQL Server instance which holds the BioLink database. You will also need Microsoft SQL Server Management Studio (or some other tool for executing SQL scripts against your database).

First download the script(s) from the [downloads](http://code.google.com/p/biolink/downloads/list) area.

Start Microsoft SQL Server Management Studio, and connect to the server which holds your BioLink database.

![http://biolink.googlecode.com/svn/wiki/UpgradeScripts.attach/Connect.png](http://biolink.googlecode.com/svn/wiki/UpgradeScripts.attach/Connect.png)

The select the Open -> File from the top level File menu

![http://biolink.googlecode.com/svn/wiki/UpgradeScripts.attach/OpenFile.png](http://biolink.googlecode.com/svn/wiki/UpgradeScripts.attach/OpenFile.png)

Navigate to where you saved the downloaded scripts, and select which script you would like to execute (one at a time).

You must then select which database you would like to execute this script against. Use the drop down list in the toolbar to selected your BioLink database.

![http://biolink.googlecode.com/svn/wiki/UpgradeScripts.attach/SelectDatabase.png](http://biolink.googlecode.com/svn/wiki/UpgradeScripts.attach/SelectDatabase.png)

Once the correct database has been selected, press the 'Execute' button to execute the script.

![http://biolink.googlecode.com/svn/wiki/UpgradeScripts.attach/Execute.png](http://biolink.googlecode.com/svn/wiki/UpgradeScripts.attach/Execute.png)

Check the results window for any errors or messages.

![http://biolink.googlecode.com/svn/wiki/UpgradeScripts.attach/Completed.png](http://biolink.googlecode.com/svn/wiki/UpgradeScripts.attach/Completed.png)




## BioLink Web Extensions ##

**Priority:** _Optional_. Although this update is not necessary, it adds features that improve and simplify using the Query Tool.

This script adds:
  * new columns to the biota table which hold specific rank values of each taxons parentage (Kingdom, Phylum, Class, Order, Family, Genus, Species, Subspecies)
  * new columns to the Political Region table (ParentCountry, Primary Division and Secondary Division)
  * two new views (DarwinCareV2 and APPDV2)
  * A number of user defined functions and triggers to support the above changes.

## AssociateReportsPatch ##

**Priority:** _Recommended_. It is highly likely that the Associates for Taxa report will not return any results unless this patch has been applied.

This script addresses an issue in the stored procedure used by the Associates For Taxa report that, on some installations, will cause incorrect or no results to be returned.

## Biolink\_V2\_5\_0\_Scripts.sql ##
**Priority:** _Required_ if your existing BioLink database schema is below version 2.5, _not required_ if your database schema is already at version 2.5

**Note** Depending on the version of your existing schema there may be some errors and warnings generated pertaining to the tblBiotaAssociate table. These can safely be ignored,

In order to find out which version of the BioLink database schema you are using, using the SQL Server Management Studio, navigate the the correct BioLink database, and open a new Query window.

Type the following SQL in the query window, click the Execute button
```
exec spVersion
```

The schema version should be displayed in the results section.

This script updates and creates tables and stored procedures required by BioLink 3.0