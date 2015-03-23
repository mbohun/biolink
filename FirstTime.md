# Starting BioLink for the first time #

**Note**: BioLink has a runtime dependency on the Microsoft Dot Net Framework version 4.0. If you do not have this installed when you try and start the application, you will be presented with an error message, and will be prompted to download and install the Dot Net Framework (Version 4.0 or better)

If you do not have a BioLink database running in an instance of SQL Server already, see [here](CreatingNewDatabase.md) first.

If you are starting a fresh install of BioLink for the first time, the first thing you need to do is to create a connection profile. A connection profile details which server and database holds BioLink data. Note that if you have a previous version of BioLink installed, the existing connection profiles will be imported automatically, and you can skip this step.

Start BioLink by double clicking on its icon, or finding the biolinkapplication.exe (Usually in `c:\program files\Biolink\`). Then click on the profile ellipsis button.

![http://biolink.googlecode.com/svn/wiki/Profile1.png](http://biolink.googlecode.com/svn/wiki/Profile1.png)

Click on Add New,

![http://biolink.googlecode.com/svn/wiki/Profile2.png](http://biolink.googlecode.com/svn/wiki/Profile2.png)

and fill out the following fields:

| **Field** | **Description** |
|:----------|:----------------|
| Name | This is the name of the connection profile itself |
| Server/Instance | The full instance name of the database server that you are connecting to. If the SQL Server is installed on your own computer it usually takes the form `<machinename>\<instancename>`, where machinename is the name of your computer, and instance name is the name you supplied during the installation of SQL Server. Older versions of SQL Server do not require the server portion, and may simply be an IP address or computer name (if not the local machine). |
| Database | The name of the actual database hosted within the SQL Server instance |
| Timeout | (Optional). The amount of time to wait when performing a database operation before giving up and raising an error |
| Use Integrated Security (NT Authentication| Allows you to use your Windows credentials to log into the SQL Server instance |

![http://biolink.googlecode.com/svn/wiki/Profile3.png](http://biolink.googlecode.com/svn/wiki/Profile3.png)

Once you have completed the profile, click Ok, and enter your username and password (unless NT Authentication has been selected) to log in.


## See Also ##
