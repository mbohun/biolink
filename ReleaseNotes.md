# Release Notes #

## BioLink Version 3.0.619 ##

BioLink 3.0.619 28th November 2014

This is build 619 for BioLink version 3. It address issues discovered since build 615.

### Issues addressed in this release ###

  * [issue 223](https://code.google.com/p/biolink/issues/detail?id=223)	Row failure during import can cause uncommitted objects to exist in cache
  * [issue 224](https://code.google.com/p/biolink/issues/detail?id=224)	Need a way to delete material for taxa
  * [issue 225](https://code.google.com/p/biolink/issues/detail?id=225)	No warning is given when deleting taxa that material or associates may be orphaned.

## BioLink Version 3.0.615 ##

BioLink 3.0.615 27th October 2014

This is build 615 of BioLink version 3.  It addresses issues raised since build 591 and adds several new features

### New Features ###

  * New Darwin Core report for taxa and material result sets
  * New Darwin Core Archive exporter (only available for darwin core reports)
  * Importer now has the ability to perform a chain of (limited) data transformations during the import. These are editable on the field mapping page of the import wizard
  * Auto-synonymy - when merging two taxa an option is now available to automatically make the merge source an available name of the target

### Issues addressed in this release ###

  * [Issue 210](https://code.google.com/p/biolink/issues/detail?id=210)	Darwin Core Report for taxa (and maybe a material result set in the query tool)
  * [Issue 219](https://code.google.com/p/biolink/issues/detail?id=219)	Requested Enhancement to Import: xlsx
  * [Issue 220](https://code.google.com/p/biolink/issues/detail?id=220)	Error during XML Export

## BioLink Version 3.0.591 ##

BioLink 3.0.591 10th April 2014

This is build 591 of BioLink version 3.  It addresses issues raised since build 582

### New Features ###
  * Users whose SQL Credentials have 'sysadmin' will have full rights via the BioLink application in much the same way 'sa' does. This should make things easier for single user installs
  * Query tool results (and other table based reports) now get enhanced menu options depending on what kind of results are being displayed. For example, if the data returned contains Material id's then a complete list of commands for material will be available. Likewise for taxa, sites and site visits. If a row contains different kinds of data (e.g. both taxa and material), menu options will appear for each type.

### Issues addressed in this release ###

  * [Issue 214](https://code.google.com/p/biolink/issues/detail?id=214)	Import regions
  * [Issue 215](https://code.google.com/p/biolink/issues/detail?id=215)	Cannot create new top level Distribution Regions in Region Explorer
  * [Issue 216](https://code.google.com/p/biolink/issues/detail?id=216)	Cannot import or export Distribution Regions
  * [Issue 217](https://code.google.com/p/biolink/issues/detail?id=217)	Export CSV puts extraneous commas at the end of each line
  * [Issue 218](https://code.google.com/p/biolink/issues/detail?id=218)	Changing Change Combination status does not get reflected in Taxon explorer

## BioLink Version 3.0.582 ##

BioLink 3.0.582 14 Aug 2013

This is the ninth "fix" release for BioLink 3.0. It addresses issues raised since build 570

### New Features ###

  * [Issue 190](https://code.google.com/p/biolink/issues/detail?id=190)	There is currently no way through the application to add phrase categories
  * [Issue 194](https://code.google.com/p/biolink/issues/detail?id=194)	Not possible to retrieve notes in query tool
  * [Issue 195](https://code.google.com/p/biolink/issues/detail?id=195)	Multimedia tab in RDE
  * [Issue 203](https://code.google.com/p/biolink/issues/detail?id=203)	Double clicking on sites, material, visits or taxa should edit that item
  * [Issue 201](https://code.google.com/p/biolink/issues/detail?id=201)	Cannot find Material/Visits or Sites in the contents tree

In addition Loan Form templates can now be formatted using Microsoft Word DOCX format using MERGEFIELD fields, rather then the rather error prone RTF format. The field names to use with the MERGEFIELD fields remains the same as per the Loan forms documentation.

### Issues addressed in this release ###

  * [Issue 193](https://code.google.com/p/biolink/issues/detail?id=193)	Query Associates does not return expected results
  * [Issue 196](https://code.google.com/p/biolink/issues/detail?id=196)	Loan Form templates often fail due to bad formatting
  * [Issue 197](https://code.google.com/p/biolink/issues/detail?id=197)	Cannot add ranks after adding Sub-Kingdon in Plantae
  * [Issue 198](https://code.google.com/p/biolink/issues/detail?id=198)	Trait values are no longer able to be selected from phrase categories
  * [Issue 199](https://code.google.com/p/biolink/issues/detail?id=199)	Query tool will not return material parts unless a material field is explicitly selected
  * [Issue 200](https://code.google.com/p/biolink/issues/detail?id=200)	No easy way to plot a set of arbitrary points on the map tool
  * [Issue 202](https://code.google.com/p/biolink/issues/detail?id=202)	Non-SA users that have the SQL Server SysAdmin role should be treated as if they are the 'sa' user



## BioLink Version 3.0.570 ##

BioLink 3.0.570 22 Mar 2013

This is the eighth "fix" release for BioLink 3.0. It addresses issues raised since build 560

### New Features ###

  * ALA Biodiversity Volunteer Portal import plugin - Allows data sourced from the ALA BVP to be easily imported into BioLink databases
  * Added support to import multimedia via URL when importing specimen data

### Issues addressed in this issue ###

  * [Issue 188](https://code.google.com/p/biolink/issues/detail?id=188)	Site Elevation will not accept an empty value
  * [Issue 189](https://code.google.com/p/biolink/issues/detail?id=189)	eGaz loses track of its currently connected gazetteer when it loses focus

## BioLink Version 3.0.560 ##

BioLink 3.0.560 25 Oct 2012

This is the seventh "fix" release for BioLink 3.0. It addresses issues raised since build 558

### New Features ###

No new features are introduced in this build.

### Issues addressed in this release ###

  * [Issue 185](https://code.google.com/p/biolink/issues/detail?id=185)	Regression: Map no longer shows 'edit site' on distribution map
  * [Issue 186](https://code.google.com/p/biolink/issues/detail?id=186)	Added a trait to the query tool causes an exception
  * [Issue 187](https://code.google.com/p/biolink/issues/detail?id=187)	Problem when adding new sites in RDE

## BioLink Version 3.0.558 ##

BioLink 3.0.558 11 Oct 2012

This is the sixth "fix" release for BioLink 3.0. It addresses issues reported since build 538.

### New Features ###
  * Minor UI enhancements, particularly in reference management
  * Experimental: There is now a "Check for updates" under the help menu that checks to see if there is a new version available for download from the Google code site

### Issues addressed in this release ###

  * [Issue 175](https://code.google.com/p/biolink/issues/detail?id=175)	"use in reports" don't work?
  * [Issue 176](https://code.google.com/p/biolink/issues/detail?id=176)	Cannot see what other things are linked to an image from the multimedia control
  * [Issue 177](https://code.google.com/p/biolink/issues/detail?id=177)	Cannot rerun a report directly from the report results window`
  * [Issue 178](https://code.google.com/p/biolink/issues/detail?id=178)	RTF preview of a reference is sometimes very messy
  * [Issue 179](https://code.google.com/p/biolink/issues/detail?id=179)	Dragging newly created favorite into a favorite group creates visual artefact until the apply button is pressed
  * [Issue 180](https://code.google.com/p/biolink/issues/detail?id=180)	Exporting references from reference manager (search) only includes a subset of reference fields
  * [Issue 181](https://code.google.com/p/biolink/issues/detail?id=181)	Would be good to be able to export a reference favorite group

## BioLink Version 3.0.538 ##

BioLink 3.0.538 2 Aug 2012

This is the fifth "fix" release for BioLink 3.0. It addresses issues reported since build 526.

### New Features ###

  * Reference search results now include journal information, if applicable
  * Reference search results can now be exported
  * Query and Report results can be copied to the clipboard (right click)
  * Query results now have formatting options (currently just for Date and Coordinate columns)
  * Country, State and County are now query-able columns (only if the web extensions script has been applied!)

### Issues addressed in this release ###

  * [Issue 155](https://code.google.com/p/biolink/issues/detail?id=155)     When launcing EGaz from the RDE or Site Details form, locality should be seeded in the egaz search box
  * [Issue 156](https://code.google.com/p/biolink/issues/detail?id=156)     When egaz is in floating window mode it doesn't get brought to the front when selected
  * [Issue 160](https://code.google.com/p/biolink/issues/detail?id=160)	 Map symbol size selector should allow for text input as well slider
  * [Issue 161](https://code.google.com/p/biolink/issues/detail?id=161)	 Line layers not honoring selected colour
  * [Issue 162](https://code.google.com/p/biolink/issues/detail?id=162)	 Query results window is always behind other windows
  * [Issue 164](https://code.google.com/p/biolink/issues/detail?id=164)	 Incorrect date format in delimited text exports
  * [Issue 165](https://code.google.com/p/biolink/issues/detail?id=165)	 Closing a subordinate window sometimes fails to refocus on main BioLink Window
  * [Issue 166](https://code.google.com/p/biolink/issues/detail?id=166)	 Cannot format dates or coordinates in query results
  * [Issue 167](https://code.google.com/p/biolink/issues/detail?id=167)	 Exported CSV files should have the option to escape embedded delimiters and quotes with backslash
  * [Issue 168](https://code.google.com/p/biolink/issues/detail?id=168)	 Map Legend Options font size is incorrectly reported
  * [Issue 169](https://code.google.com/p/biolink/issues/detail?id=169)	 Apply button is always active, even when no changes are present
  * [Issue 170](https://code.google.com/p/biolink/issues/detail?id=170)	 Country, State and County are not available fields in the query tool
  * [Issue 171](https://code.google.com/p/biolink/issues/detail?id=171)	 Reference search results should include journal details if relevent
  * [Issue 172](https://code.google.com/p/biolink/issues/detail?id=172)	 Copy/Paste results from tabular Query and Report Results
  * [Issue 173](https://code.google.com/p/biolink/issues/detail?id=173)	 Can't easily export reference search results

## BioLink Version 3.0.526 ##

BioLink 3.0.526 22 May 2012

This is the fourth "fix" release for BioLink 3.0. It addresses issues reported since build 517.

### New Features ###

  * Loan search results can now be sorted
  * Loan search results can also be exported via the reporting mechanism

### Issues addressed in this release ###

  * [Issue 152](https://code.google.com/p/biolink/issues/detail?id=152)   RDE, autofill copy from previous material fails trait copying

## BioLink Version 3.0.517 ##

BioLink 3.0.517 28 March 2012

This is the third "fix" release for BioLink 3.0. It addresses issues reported since build 503.

### New Features ###

  * Map tool now has a customizable legend, similar in functionality to the legacy BioLink map tool.

### Issues addressed in this release ###

  * [Issue 145](https://code.google.com/p/biolink/issues/detail?id=145)	Map tool does not have a legend option
  * [Issue 146](https://code.google.com/p/biolink/issues/detail?id=146)	Loans search needs an implied trailing wildcard
  * [Issue 147](https://code.google.com/p/biolink/issues/detail?id=147)	Loan Material Description text edit needs to accept new line characters (multiline)
  * [Issue 148](https://code.google.com/p/biolink/issues/detail?id=148)	Loan contacts with attached permit number traits should pre-fill permit number on loan form if selected as borrower
  * [Issue 150](https://code.google.com/p/biolink/issues/detail?id=150)	Display an aggregated specimen count at the bottom of the Loan Material tab
  * [Issue 151](https://code.google.com/p/biolink/issues/detail?id=151)	Duplicate Loan Numbers allowed to be saved

Also fixed was an issue in Loan Form templates whereby invisible formatting markup within the templates was garbling the place holder names during loan form generation, thereby preventing correct generation

## BioLink Version 3.0.503 ##

BioLink 3.0.503 15 December 2011

This is the second "fix" release for BioLink 3.0. It address issues raised since build 485

### New Features ###
No new features

### Issues addressed in this release ###

  * [Issue 136](https://code.google.com/p/biolink/issues/detail?id=136)	Sites sometimes have position data (lat/long) but no geometry type
  * [Issue 137](https://code.google.com/p/biolink/issues/detail?id=137)	Taxa Lookup controls are not correctly sorting
  * [Issue 138](https://code.google.com/p/biolink/issues/detail?id=138)	Dragging from eGaz will not trigger locality update
  * [Issue 139](https://code.google.com/p/biolink/issues/detail?id=139)	Sometimes dragging a taxa to a lookup control appends (or leaves) a trailing space, cause validation to fail
  * [Issue 140](https://code.google.com/p/biolink/issues/detail?id=140)	Can edit species available name data before a type data instance has been added
  * [Issue 141](https://code.google.com/p/biolink/issues/detail?id=141)	Can drag a taxon to the 'identification' lookup control on RDE, even if RDE is locked
  * [Issue 142](https://code.google.com/p/biolink/issues/detail?id=142)	Dragging certain taxa to a lookup control can be problematic
  * [Issue 143](https://code.google.com/p/biolink/issues/detail?id=143)	RDE material dropping identification data when viewed
  * [Issue 144](https://code.google.com/p/biolink/issues/detail?id=144)	Map point colours not being changed from default

## BioLink Version 3.0.485 ##

BioLink 3.0.485 29 September 2011

This release is the first "fix" release for BioLink 3.0. It addresses all issues raised since build 459 (excluding [Issue 49](https://code.google.com/p/biolink/issues/detail?id=49)).

### New Features ###

  * Polygon "Features for Points" report (Map tool). This report presents feature data of polygons on which a point layer is overlayed. It can optionally group by taxon if the points are from a distribution map.
  * New option to always show the Gazetteer in a floating window (rather than docked). See Tools->Settings->Preferences...
  * New options to always regenerate Material and Site Visit names when details are saved.
  * General stability and performance improvements to modelling
  * New colour picker widget (this affects all windows on which a colour can be selected including notes, modelling, layers etc).

### Issues addressed in this release ###

  * [Issue 121](https://code.google.com/p/biolink/issues/detail?id=121)	 Colours in Modelling not sticking between runs
  * [Issue 122](https://code.google.com/p/biolink/issues/detail?id=122)	 Query Tool SP error
  * [Issue 123](https://code.google.com/p/biolink/issues/detail?id=123)	 Reference detail does not validate missing ref code
  * [Issue 124](https://code.google.com/p/biolink/issues/detail?id=124)	 Pages should be parsed and placed into into page range box if possible (new journal)
  * [Issue 126](https://code.google.com/p/biolink/issues/detail?id=126)	 RTF strip formatting is failing if unmatch { are detected.
  * [Issue 127](https://code.google.com/p/biolink/issues/detail?id=127)	 Multimedia captions are not being saved.
  * [Issue 128](https://code.google.com/p/biolink/issues/detail?id=128)	 Can't drag from a child of a Taxon favorite
  * [Issue 129](https://code.google.com/p/biolink/issues/detail?id=129)	 Raster maps should be added to the bottom of the layers list (i.e models)
  * [Issue 130](https://code.google.com/p/biolink/issues/detail?id=130)	 When new layers are added, the map should retain its existing extents
  * [Issue 131](https://code.google.com/p/biolink/issues/detail?id=131)	 Should be an easier way to set a vector layer fill to be transparent
  * [Issue 132](https://code.google.com/p/biolink/issues/detail?id=132)	 Auto naming of material and subparts (sites and visits too?)
  * [Issue 133](https://code.google.com/p/biolink/issues/detail?id=133)	 Can't set map background colour to a transparent (or partially transparent) colour
  * [Issue 134](https://code.google.com/p/biolink/issues/detail?id=134)	 Can't drag an unranked element to another that already has children
  * [Issue 135](https://code.google.com/p/biolink/issues/detail?id=135)	 Add taxon menu does not take into account the kingdom code (gets incorrect list for Plantae)

## BioLink Version 3.0 Release ##

BioLink 3.0.459 19 August 2011

### New Features ###

No new features in this release

### Issues addressed in this release ###

  * [Issue 116](https://code.google.com/p/biolink/issues/detail?id=116) Add 'All ranks' not implemented
  * [Issue 118](https://code.google.com/p/biolink/issues/detail?id=118) About box needs updating to include ALA information
  * [Issue 119](https://code.google.com/p/biolink/issues/detail?id=119) Debug logging needs to be turned off by defaut in Release 3.0
  * [Issue 120](https://code.google.com/p/biolink/issues/detail?id=120) User guide needs to be put up in Wiki somewhere (PDF and DOC)

### Known Issues ###

There is an issue that can (rarely) cause a XML Import failure that is currently being investigated. It appears as if there is a size constraint  mismatch between the import stored procedures and the exported data. A fix will be made available in a future release.

## Release Candidate 4 (RC4) ##
BioLink 3.0.443 16 August 2011

### New features ###

No new features in this release

### Issues addressed in this release ###

  * [Issue 111](https://code.google.com/p/biolink/issues/detail?id=111)	 Can't open label manager (null reference exception)
  * [Issue 112](https://code.google.com/p/biolink/issues/detail?id=112)	 When merging two sites, if either site has a trait, performing a compare will fail if the trait name has a space
  * [Issue 113](https://code.google.com/p/biolink/issues/detail?id=113)	 Inserting new taxa fails if no permissions exist for user in fine grained permissions
  * [Issue 115](https://code.google.com/p/biolink/issues/detail?id=115)	 Associates not importing from XML
  * [Issue 117](https://code.google.com/p/biolink/issues/detail?id=117)	 Can't press enter in contacts address fields or Loan conditions fields

Also many small issues around XML Importing and Exporting

## Release Candidate 3 (RC3) ##

BioLink 3.0.425 12 August 2011

### New Features ###

  * New Pest/Hosts associates editor. An optional streamlined editor for simple pest host associations
  * The Associates for Taxa report now has a second view that graphically describes the relationship between associates
  * Taxon multimedia report can now optionally include multimedia attached to associated material (specimens)
  * Lookup controls (linking controls with Magnify glass and ellipsis buttons) now show the tooltip of the item they link to when hovered over.
  * Loan forms generation now prompts for a target filename before the form is generated

### Issues addressed in this release ###

  * [Issue 8](https://code.google.com/p/biolink/issues/detail?id=8)	Associates not loading on one side of the relationship
  * [Issue 99](https://code.google.com/p/biolink/issues/detail?id=99)	Items with RTF notes will set 'dirty' flag without any changes
  * [Issue 102](https://code.google.com/p/biolink/issues/detail?id=102)	 Taxon Explorer (and presumably other explorers) wont save changes if undocked from main window
  * [Issue 103](https://code.google.com/p/biolink/issues/detail?id=103)	 Taxon "Change Rank" command missing
  * [Issue 104](https://code.google.com/p/biolink/issues/detail?id=104)	 Taxon fine grained security options missing (permissions)
  * [Issue 105](https://code.google.com/p/biolink/issues/detail?id=105)	 Change to Available Name or Change to Literature Name not showing in menu
  * [Issue 106](https://code.google.com/p/biolink/issues/detail?id=106)	 Delete current level menu item missing
  * [Issue 107](https://code.google.com/p/biolink/issues/detail?id=107)	 Remove from favorites not working
  * [Issue 108](https://code.google.com/p/biolink/issues/detail?id=108)	 Find regions by name missing (region map)
  * [Issue 109](https://code.google.com/p/biolink/issues/detail?id=109)	 When generating a loan form, ask for a file location before generation
  * [Issue 110](https://code.google.com/p/biolink/issues/detail?id=110)	 "Editing" an empty lookup control raises an exception


## Release Candidate 2 (RC2) ##

BioLink 3.0.395 5th August, 2011

The second release candidate for BioLink 3.0. This release addresses a number of issues identified during testing of RC1.

### Known Issues ###

Associates is still not working quite right. In addition a new, more simplified Associates mode is currently being implemented, which should be available in RC 3.

### New Features ###

  * Multimedia Report from Taxon Explorer. Finds all multimedia for a taxon (and optionally its descendents)
  * Google Earth geo coding is now possible from Site and Rapid Data Entry forms (only if Google Earth is installed)
  * Region Map now warns you if you have no 'Region enabled' layers active. 'Region enabled' layers are shape files that include meta data that associates  region identifiers to a polygons. BioLink 2.5 shipped with one Region layer (Admin98), which can be used with BioLink 3.0.

### Issues addressed in this release ###

  * [Issue 87](https://code.google.com/p/biolink/issues/detail?id=87)	Taxon sort order not quite right
  * [Issue 89](https://code.google.com/p/biolink/issues/detail?id=89)	Loans search by surname not working
  * [Issue 90](https://code.google.com/p/biolink/issues/detail?id=90)	Region Map sometimes 'optimizes' all regions out
  * [Issue 91](https://code.google.com/p/biolink/issues/detail?id=91)	Loans that have not yet been closed have a closed date of 30 Dec, 1899
  * [Issue 92](https://code.google.com/p/biolink/issues/detail?id=92)	Reference search by surname not working
  * [Issue 93](https://code.google.com/p/biolink/issues/detail?id=93)	User details does not register changes on notes field
  * [Issue 94](https://code.google.com/p/biolink/issues/detail?id=94)	Last used template is not appearing on the Add-> xxx menu from the material explorer
  * [Issue 95](https://code.google.com/p/biolink/issues/detail?id=95)	Cancelling changes on taxon tree will enter an endless loop of asking if you want to discard changes (unless you discard the changes)
  * [Issue 96](https://code.google.com/p/biolink/issues/detail?id=96)	Label manager wont allow new items (wont save)
  * [Issue 97](https://code.google.com/p/biolink/issues/detail?id=97)	Mini map on site details should allow to plot site location on full map
  * [Issue 98](https://code.google.com/p/biolink/issues/detail?id=98)	When geo coding from GE, set Source and Elev Source to "Google Earth"

## Release Candidate 1 (RC1) ##

BioLink 3.0.378 1st August, 2011

This release is the first release candidate for BioLink 3.0. Testing is continuing, and any issues found will be addressed by subsequent release candidate builds.

#### New Features ####
  * [Issue 78](https://code.google.com/p/biolink/issues/detail?id=78) Taxa for distribution report
  * [Issue 84](https://code.google.com/p/biolink/issues/detail?id=84) Drop files from Window Explorer to multimedia

#### Issues addressed in this release ####

  * [Issue 76](https://code.google.com/p/biolink/issues/detail?id=76) Editing site details and locality
  * [Issue 77](https://code.google.com/p/biolink/issues/detail?id=77) Collector box appends rather than replaces
  * [Issue 79](https://code.google.com/p/biolink/issues/detail?id=79) Site/Visit/Material identifiers in query results
  * [Issue 80](https://code.google.com/p/biolink/issues/detail?id=80) Double clicking in hierarchical selectors
  * [Issue 81](https://code.google.com/p/biolink/issues/detail?id=81) Gazetteer select button missing
  * [Issue 82](https://code.google.com/p/biolink/issues/detail?id=82) Gazetteer scrolling issue
  * [Issue 83](https://code.google.com/p/biolink/issues/detail?id=83) Remember answer to update locality question RDE
  * [Issue 85](https://code.google.com/p/biolink/issues/detail?id=85) Admin controls fail with no data
  * [Issue 86](https://code.google.com/p/biolink/issues/detail?id=86) Taxon Explorer lock panel on find tab