# Information for existing BioLink users #

Version 3.0 of BioLink is basically a rewrite of the BioLink client application. The modifications to the database schema and stored procedures are backwards compatible with version 2.5. This means that both the new and the old versions of BioLink can operate against the same SQL Server database at the same time, with one small caveat. Any new users that are created in version 3.0 will not be able to log on through the old version of BioLink due to a change in how user passwords are managed.

In addition to remaining backwards compatible with existing BioLink databases, version 3.0 of BioLink can be installed side by side with an existing installation of the old version of the BioLink application. Typically BioLink version 2.5 is installed under `c:\program files\CSIRO\Biolink`. By default version 3.0 is installed directly under `c:\program files\Biolink`.

Any existing (version 2.5) connection profiles will automatically be imported into the new application, and so profile configuration should be minimal.

All existing users of BioLink need to do in order to upgrade to version 3.0 is to install the version 3.0 application (See [here](InstallBiolink.md)) and [upgrade](UpgradeScripts.md) their database(s).

# See Also #

[Whats new and different in version 3.0](WhatsNew.md)

[How to report bugs](ReportIssues.md)

[User Guide](UserGuide.md)