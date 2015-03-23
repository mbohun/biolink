# Introduction #

## The problem ##

If, when SQL Server is installed, Windows Authentication is selected, rather than SQL Server (or mixed mode) authentication, the Windows user is able to log into BioLink, but is unable to make modifications to the data in BioLink as they lack the requisite permissions.

This problem with the BioLink permissions system is a consequence of the legacy design of the original BioLink, and changes to the default way that SQL Server wants to authenticate users. Using 'Windows Authentication' (sometimes called 'NT Authentication') is more convenient, because you don't need to remember a different password for !Biolink, however, in order for your account to have privileges, a BioLink user of the name as your Windows user name must exist, and and have permissions attached it. The problem arises because only a certain class of (privileged) BioLink users can create other BioLink users, and so in a single user install there is a bootstrapping (chicken/egg) problem to overcome. It was originally planned that this bootstrapping problem would be solved as part of the 3.0 redevelopment, but it has proved more difficult than expected, so the fallback solution is to make use of the SQL Server authentication mode and the 'sa' account to create an initial privileged BioLink user.

SQL Server has two modes of authentication - so called 'Windows (or NT) Authentication' and 'SQL Server Authentication' (sometimes also known as "mixed mode"). Windows Authentication is employed when the credentials you supply when you log on to Windows are automatically used to authenticate against the SQL Server, and is the preferred mode. 'SQL Server mode'  (or mixed mode) is where SQL Server manages a separate username and password for each person using SQL Server. When using mixed mode authentication, SQL Server defines a special user 'sa' (short for system administrator') that has unrestricted access to the SQL Server, and therefore can pose a security risk should the 'sa' password become compromised. For this reason, in later versions of SQL Server, both mixed mode and the 'sa' account are disabled by default.

When installing SQL Server the user is presented the option of enabling SQL Server authentication (and supplying an 'sa' password), but the default settings are to leave it disabled. It is possible, however, to enable mixed mode authentication, and enable the sa account, after the installation has completed.

Once enabled, the sa account can be used to log into BioLink - Within BioLink, the 'sa' user is treated specially, in that it has unfettered access to all functions of BioLink. Once logged in as 'sa' you can create a BioLink user with the same name as your Windows username, apply the appropriate permissions, and then disable mixed mode and the sa account (should you so desire). If you give your BioLink user administrative privileges within BioLink, that BioLink user can then be used to create other BioLink users.

Below is a step by step guide on how to do this.

## The solution (workaround) ##

This guide will show you how to

  * Enable SQL Server authentication
  * Enable the SQL Server 'sa' account

Once the sa account has been enabled you can either

  * Always use the 'sa' account when working with BioLink (not recommended)
or
  * Create a privileged !Biolink user (as 'sa')

### Enable SQL Server Authentication (mixed mode) ###

1. Start the SQL Server Management Console, and connect to the SQL Server instance on which you BioLink database resides. See the wiki page [CreatingNewDatabase](CreatingNewDatabase.md) for information on where to download it from.

![http://biolink.googlecode.com/svn/wiki/BootStrap.attach/bootstrap_image001.png](http://biolink.googlecode.com/svn/wiki/BootStrap.attach/bootstrap_image001.png)

2. Right mouse click on the top level (database) node, and select Properties on the popup menu

![http://biolink.googlecode.com/svn/wiki/BootStrap.attach/bootstrap_image002.png](http://biolink.googlecode.com/svn/wiki/BootStrap.attach/bootstrap_image002.png)

3. Select the 'Security' section, and select the 'SQL Server and Windows Authentication' radio button

![http://biolink.googlecode.com/svn/wiki/BootStrap.attach/bootstrap_image003.png](http://biolink.googlecode.com/svn/wiki/BootStrap.attach/bootstrap_image003.png)

### Enable the 'sa' account, and supply a password ###

4. Expand the Security folder and Logins under that. Locate the 'sa' user and right click 'Properties'

![http://biolink.googlecode.com/svn/wiki/BootStrap.attach/bootstrap_image004.png](http://biolink.googlecode.com/svn/wiki/BootStrap.attach/bootstrap_image004.png)

5. Enter a password (twice) for the account under the 'General' section.

![http://biolink.googlecode.com/svn/wiki/BootStrap.attach/bootstrap_image005.png](http://biolink.googlecode.com/svn/wiki/BootStrap.attach/bootstrap_image005.png)

6. Ensure the account is enabled in the 'Status' section, and click OK to save the changes.

![http://biolink.googlecode.com/svn/wiki/BootStrap.attach/bootstrap_image006.png](http://biolink.googlecode.com/svn/wiki/BootStrap.attach/bootstrap_image006.png)

You can exit the SQL Server Management studio now

7. Restart the SQL Server instance using either the Services control panel, or the SQL Server Configuration Manager

![http://biolink.googlecode.com/svn/wiki/BootStrap.attach/bootstrap_image007.png](http://biolink.googlecode.com/svn/wiki/BootStrap.attach/bootstrap_image007.png)

![http://biolink.googlecode.com/svn/wiki/BootStrap.attach/bootstrap_image008.png](http://biolink.googlecode.com/svn/wiki/BootStrap.attach/bootstrap_image008.png)

### Create a privileged BioLink user ###

9. Modify your BioLink database profile to use 'mixed mode' authentication by clicking on the ellipsis button on the BioLink login screen. Select the profile that connects to your database in the dropdown box, and ensure that 'Use Integrated Security (NT Authentication)' is unchecked.

![http://biolink.googlecode.com/svn/wiki/BootStrap.attach/bootstrap_image010.png](http://biolink.googlecode.com/svn/wiki/BootStrap.attach/bootstrap_image010.png)

![http://biolink.googlecode.com/svn/wiki/BootStrap.attach/bootstrap_image009.png](http://biolink.googlecode.com/svn/wiki/BootStrap.attach/bootstrap_image009.png)

10. Login to BioLink using the username 'sa' and the password you entered in the SQL Server Management console

11. Select the 'Users and Groups' menu item under 'Tools->Settings' from the main BioLink menu.

![http://biolink.googlecode.com/svn/wiki/BootStrap.attach/bootstrap_image011.png](http://biolink.googlecode.com/svn/wiki/BootStrap.attach/bootstrap_image011.png)

12. Click on New Group

![http://biolink.googlecode.com/svn/wiki/BootStrap.attach/bootstrap_image013.png](http://biolink.googlecode.com/svn/wiki/BootStrap.attach/bootstrap_image013.png)

13. Create an administrators group. It doesn't really matter what you call the group, but something like 'Administrators' would make sense.

![http://biolink.googlecode.com/svn/wiki/BootStrap.attach/bootstrap_image014.png](http://biolink.googlecode.com/svn/wiki/BootStrap.attach/bootstrap_image014.png)

14. Assign permissions to the Administrator group. In the screen shots below, the Administrator group has been given full permissions. Double click on each
permission to edit them.

![http://biolink.googlecode.com/svn/wiki/BootStrap.attach/bootstrap_image015.png](http://biolink.googlecode.com/svn/wiki/BootStrap.attach/bootstrap_image015.png)

![http://biolink.googlecode.com/svn/wiki/BootStrap.attach/bootstrap_image016.png](http://biolink.googlecode.com/svn/wiki/BootStrap.attach/bootstrap_image016.png)

![http://biolink.googlecode.com/svn/wiki/BootStrap.attach/bootstrap_image017.png](http://biolink.googlecode.com/svn/wiki/BootStrap.attach/bootstrap_image017.png)

15. Create a new user with exactly the same name as your Windows username. In this example, I log into this machine using the username 'baird', so I create a BioLink user named 'baird'

Ensure the 'User can create other users' checkbox is checked
Also make sure the user is in the newly created administrators group (Permissions are applied to groups, to which users can belong).

You can supply a password here, but if you revert you database profile to use Windows authentication you will not need to enter this password, as it will use your (already logged in) Windows credentials to authenticate you. If don't use 'Integrated' or Windows authentication, you will need to use this password to log in.

![http://biolink.googlecode.com/svn/wiki/BootStrap.attach/bootstrap_image018.png](http://biolink.googlecode.com/svn/wiki/BootStrap.attach/bootstrap_image018.png)

16. Log out of BioLink, and modify the database profile again so that it uses Integrated (Windows or NT) Authentication.

![http://biolink.googlecode.com/svn/wiki/BootStrap.attach/bootstrap_image019.png](http://biolink.googlecode.com/svn/wiki/BootStrap.attach/bootstrap_image019.png)

17. You should now be able to log in normally, and have full update privileges.

![http://biolink.googlecode.com/svn/wiki/BootStrap.attach/bootstrap_image020.png](http://biolink.googlecode.com/svn/wiki/BootStrap.attach/bootstrap_image020.png)