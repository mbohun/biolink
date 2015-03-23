Although core functionality is basically unchanged from the previous versions, there are a number of minor changes and enhancements to BioLink in version 3.0 that existing users should be aware of.



# New Look and Feel #

Version 3 of BioLink has a new look and feel. The following screens and documentation will outline the changes and provide some helpful tips and rules when using this new version.

The screen below is how BioLink will appear when you log in for the first time. The top left hand corner of the screen will tell you which Database you are connected to, and the User id you have used to log on. The menu bar is where you will find the Tools and Views you may want to use, such as the Loan Manager, Import, Label Manager, Statistics and the Query Tool, etc.

![http://biolink.googlecode.com/svn/wiki/WhatsNew.attach/guide1.png](http://biolink.googlecode.com/svn/wiki/WhatsNew.attach/guide1.png)

When you first open BioLink 3, the screen will look like the one above (Windows Vista and Windows 7 users will notice other cosmetic differences due to the Aero theme). You will note that there is now a stack of tabs on the left hand side of the screen, one for each of the main "Explorers" in BioLink - the Material Explorer, Taxon Explorer, Gazetteer and the new Pin Board. The rest of the screen by default is filled by the Welcome tab window, which contains a welcome message that is specific to the database to which you are connected (BioLink administrators can change the content of this page. See [here](WelcomeHTML.md) for more details.)

# Docking and Undocking Explorers #

You may choose to leave the Explorer tabs as they are and work with them this way. More typically, however, you can detach each explorer by "dragging" its tab (left click on the tab title, and move the mouse whilst keeping the mouse button pressed) to float on any part of the screen. Alternatively, you can place the contents of individual tabs onto other anchor points that will appear on screen once you initiate a drag (docking).

![http://biolink.googlecode.com/svn/wiki/WhatsNew.attach/docking.png](http://biolink.googlecode.com/svn/wiki/WhatsNew.attach/docking.png)

Each of the explorers (including the Gazetteer) can be docked/undocked and re-sized to suit your work preferences and screen size.

**Hints:**
  * To drag a tab easily, hold the left mouse button and down then move the mouse either **up** or **down** to detach the contents of the tab. If you move the mouse **left** or **right**, the tab will change position within the stack of tabs, and will only detach if the tab is either the right most tab (or left most, depending on which way you are dragging).

  * The tabs can also be moved collectively by using “click and hold” on the light blue bar where the name of the tab is written at the top of the window. The main thing to note with this option, is that if you have your tabs "stacked" one on top of the other, the drag will move all the stacked tabs as one.

  * If you right mouse click on the light blue bar at the top of each window you will also get menu options for relocating the explorers.

  * If you choose not to re-arrange the BioLink windows, some windows will give you scroll bars where appropriate, such as the Find tab on the Material tab.

![http://biolink.googlecode.com/svn/wiki/WhatsNew.attach/guide2.png](http://biolink.googlecode.com/svn/wiki/WhatsNew.attach/guide2.png)

If you have moved your tabs around, the screen may now look like the one above. Note that the Welcome window tab is still populating the centre of the screen, and the moved tabs are now "pinned" on each side of the centre window. If you choose to set up your screen this way, the Welcome window tab will now automatically populate any remaining space left between the tabs on either side of the screen.

**Hints**
  * The Welcome tab can be made to float on the screen by the click and drag method.

  * You can also choose to close the Welcome window tab by either clicking on the X next to Welcome on the tab or by clicking on the X on the top right corner of the Welcome window. The Welcome window will always reappear the next time you log in to BioLink however.

![http://biolink.googlecode.com/svn/wiki/WhatsNew.attach/guide3.png](http://biolink.googlecode.com/svn/wiki/WhatsNew.attach/guide3.png)

Another option for setting up your screen is to un-pin the tabs, as illustrated above. The un-pinned tabs will now line up down the side of the screen on which they were originally pinned. If you have a small monitor, you may choose to work this way as it gives you more “clear” screen for working with Rapid Data Entry (RDE), reports, etc.

To un-pin the tabs, click on the pin symbol in the top right hand corner of the window.

![http://biolink.googlecode.com/svn/wiki/WhatsNew.attach/pinned.png](http://biolink.googlecode.com/svn/wiki/WhatsNew.attach/pinned.png)

To use an un-pinned tab, hover your mouse over the item you wish to use, and it will temporarily populate the screen.

To re-pin the item, hover the mouse over the item and click on the pin symbol. This will re-pin the whole stack. Or, you can choose View on the menu bar and click on any of the un-pinned tab names and this will also re-pin the whole stack. Alternatively you can right mouse click on the light blue line and choose “Dock as Tabbed Document”. This will pin the choosen tab in the centre of the screen.

**Hints**

When you re-pin the tab stack, the tab you choose to do this on will now be on top of the tab stack.

# The Pin Board #

One of the more obvious new features introduced in version 3 of BioLink is the "Pin Board".

![http://biolink.googlecode.com/svn/wiki/WhatsNew.attach/guide4.png](http://biolink.googlecode.com/svn/wiki/WhatsNew.attach/guide4.png)

The Pin Board allows you to "pin" favourite or regularly used items. Items on the Pin Board tab can be dragged and dropped onto such things as fields on the Rapid Data Entry form, Loans forms, etc. As can be seen from the above screen shot, the Pin Board groups like items together, and displays them in alphabetical or numeric order, which-ever is appropriate.

**Hints**

  * To add items to the Pin Board tab, you can either drag and drop them onto the Pin Board, or on explorers, choose the item you want to add, right mouse click and select “Pin to pin board”. To remove items from the Pin Board tab, select the item to be removed, right mouse click and choose “Unpin”.

  * Pin board items may also have other commonly used commands (such as Edit, for example) in their context menu (right click), depending on the item.

# Associates #

There are two new "Associates" features in BioLink 3.0 - The "Associates" view on the Associates for taxa report, and the simplified Pest/Host associate editor.

## Associates viewer (Associates for Taxa report) ##

The associates view of the "Associates for Taxa" report is an attempt to present the relationships involved in an association in an unambiguous manner.

![http://biolink.googlecode.com/svn/wiki/WhatsNew.attach/AssociatesReport1.png](http://biolink.googlecode.com/svn/wiki/WhatsNew.attach/AssociatesReport1.png)

Each outer box in the view represents an association between two elements. Each element in an association is either a Taxon, and piece of material (specimen) or a piece of descriptive text (description). Because a description does not exist as separate entity outside of the association, a description will always appear on the right hand side of the association. Each inner box describes one participant in the association. Rich Tooltips will be displayed when the mouse is hovered over either side.

## Simplified Pest/Host associates editor ##

The Pest/Host associates editor is an attempt to streamline associates for a common associate scenario, namely the Pest/Host relationship.

The Pest/Host associates editor can be activated by selecting Preferences from the "Tools->Settings->Preferences..." menu.

![http://biolink.googlecode.com/svn/wiki/WhatsNew.attach/PreferencesMenu.png](http://biolink.googlecode.com/svn/wiki/WhatsNew.attach/PreferencesMenu.png)

![http://biolink.googlecode.com/svn/wiki/WhatsNew.attach/PestHost1.png](http://biolink.googlecode.com/svn/wiki/WhatsNew.attach/PestHost1.png)

Once activated, whenever an existing associate is viewed that has the From-To and To-From relationships being Pest and Host exclusively, or if a new associate is created, the Pest/Host editor will be used rather than the more detailed associates editor.

![http://biolink.googlecode.com/svn/wiki/WhatsNew.attach/PestHost2.png](http://biolink.googlecode.com/svn/wiki/WhatsNew.attach/PestHost2.png)

# Material #

![http://biolink.googlecode.com/svn/wiki/WhatsNew.attach/guide5.png](http://biolink.googlecode.com/svn/wiki/WhatsNew.attach/guide5.png)

One of the new features on the Material Explorer is the ability to select the type of material search from the drop down menu as seen on the screen above, without having to use the mouse. Just tab into the type of search field and type the first letter of the search word you want to use. For example, if you want to search on Accession Number  type the letter 'a'. Where there is more than one 'search type' starting with the same letter, continue to type the same letter and it will alternate through the possible matches for that letter.

## Rapid Data Entry ##

When using the RDE form, there are now several shortcuts that allow you to use your keyboard instead of the mouse. The RDE form looks different at fisrt glance, but it has all the same fields as in version 2.5.

![http://biolink.googlecode.com/svn/wiki/WhatsNew.attach/guide10.png](http://biolink.googlecode.com/svn/wiki/WhatsNew.attach/guide10.png)

All the ellipsis buttons work in the same way for populating fields, but there are some shortcuts that you can now choose to use as well.

## Shortcuts ##

  * You can drag and drop in to fields using Values you have previously placed on the pin board

  * In any field that has a magnifying glass symbol at the end of the field, you can type the first letter of the information you want in the field and then hit the enter key and a Search results list will pop up that you can select from. The more letters you type before using the enter key the narrower the returned search results will be.
  * Another way to access the Search results pop up list in fields where there is a Values list behind the elipsis button, is to type the first few letters of the Value you are looking for then type Ctrl + Space. You can use your up and down arrow keys to navigate the list to select the Value you want (by pressing enter).

  * In any of the fields that show the blue auto-select, you can go to the front or back of the highlighted characters by using either your right or left arrow key to move your cursor in the direction you wish to edit

This version of BioLink defaults the S for South in the Longitude field, whereas in previous versions it always defaulted whatever the last Longitude you used was. If you need to add a Northern hemisphere record, you will need to remember to change the Longitude field to N.


# Taxa #

![http://biolink.googlecode.com/svn/wiki/WhatsNew.attach/guide6.png](http://biolink.googlecode.com/svn/wiki/WhatsNew.attach/guide6.png)

## Taxon tree lock ##

The Taxon Explorer now has a lock symbol in the top left of the window. This is a security device to protect the taxon tree from accidental changes. The lock symbol appears on both the "All Taxa" and "Find" tabs. You can still edit the taxon tree in the same ways as before, except that you must "unlock" the Taxon tree (by clicking on the lock symbol) before you can make any changes. Once you open the lock, you will notice an orange band across the top of the window as visual reminder that the taxon tree is now open for editing. To lock the taxon tree again, click on the lock symbol. If you have made any changes that have yet to be applied to the database you will be prompted to save these changes, or to discard them.

## Hints ##
  * You can scroll the taxon tree up and down using the mouse wheel

  * You can use a right mouse click to access a context menu on individual taxa items. This menu has the option to "Unlock Taxon Explorer for editing". However you cannot re-lock the Taxon tree from a right mouse click menu list, you must use the lock symbol.

  * When dragging taxon items, if drop target is not visible (off screen) because there are too many other taxa items between the drag source and the target, you can simply drag the item to either the very top of the taxon tree, or the bottom (depending on which direction the target is from the source), and the tree view will automatically scroll.

## Multimedia Report ##

![http://biolink.googlecode.com/svn/wiki/WhatsNew.attach/MultimediaReport1.png](http://biolink.googlecode.com/svn/wiki/WhatsNew.attach/MultimediaReport1.png)

The Taxon tree now exposes a new report - the 'Multimedia' report. This report will retrieve all the multimedia items attached to the selected taxa and (optionally) its children. In addition multimedia attached to material associated with the selected taxa (and its children) can be retrieved as well, although it should be noted that this has the potential to be a very CPU and resource intensive operation, depending on how high up the Taxon tree the report is run.

![http://biolink.googlecode.com/svn/wiki/WhatsNew.attach/MultimediaReport2.png](http://biolink.googlecode.com/svn/wiki/WhatsNew.attach/MultimediaReport2.png)

There are two views presented once the report has completed. The table view lists a summary of the multimedia found, and the thumbnail view displays a thumbnail image for each item.

**Note** Thumbnail image generation requires that each piece of multimedia be retrieved to a temporary file on your computer which could, if the number of items found is large, have an (temporary) effect on the amount of free space available on your computer. Thumbnails are generated as a background process, and once started will continue to run until all thumbnails have been generated, or the report tab is closed. When the report tab is closed, all temporary files associated with the report will be deleted.

# Rich tooltips #

Most items displayed in explorers and find results now have detailed tool tips that display further information about that item when the mouse is hovered over them.

![http://biolink.googlecode.com/svn/wiki/WhatsNew.attach/guide7.png](http://biolink.googlecode.com/svn/wiki/WhatsNew.attach/guide7.png)

On the Material explorer, for example, if you can place the mouse over a site name, a pop-up box (commonly called a tooltip) will appear as illustrated in the screen shot above. The tooltip will present more details on the hovered site record. The main benefit of this feature is when you have multiple site records with the same label, records can be quickly differentiated by their latitude & longitude (or other fields), as these now appear on screen without having to open each site record individually.

![http://biolink.googlecode.com/svn/wiki/WhatsNew.attach/guide8.png](http://biolink.googlecode.com/svn/wiki/WhatsNew.attach/guide8.png)

Likewise, this feature is also available on the Taxon Explorer as seen in the screen shot above. The tooltip for taxon items will show the three "levels" above where the hovered item exists in the hierarchy. It is particularly helpful when you search on a species name and it returns multiple species with similar names, but within different higher orders.

# The Gazetteer #

![http://biolink.googlecode.com/svn/wiki/WhatsNew.attach/guide9.png](http://biolink.googlecode.com/svn/wiki/WhatsNew.attach/guide9.png)

The Gazetteer works in the same way as in previous versions, although it looks a little different. You may need to re-size the Gazetteer window to show all the Lat and Long offset buttons, or you can use the scroll bar that will automatically appear if the gazetteer is too big for its allotted space.

Some gazetteer functions are found on the menu bar under Tools -> eGaz.

The Choose file button allows you to select a gazetteer file. The format of Gazetteer files has changed for version 3, and older (version 2.5 and earlier) gazetteer files can be converted via the 'Legacy eGaz file converter' menu option (Tools->eGaz).

# Filters #
Report result tables, User manager, Query tool and import field selectors are just a few of the lists within BioLink 3.0 that now have a filter box associated with them.

![http://biolink.googlecode.com/svn/wiki/WhatsNew.attach/QueryToolFilter.png](http://biolink.googlecode.com/svn/wiki/WhatsNew.attach/QueryToolFilter.png)

The filter box allows you to quickly filter out items that do not match text entered. This allows you to quick find a field (in the query tool, for example) if you already know the name of the item you wish to select.

# Google Earth integration #

Google Earth integration has also been added to this version of BioLink. Google Earth must be already installed on your computer to make this feature work. You can use this feature to populate the Latitude, Longitude and Elevation of a locality in both the Site Detail and Rapid Data Entry (RDE) screens. Clicking on the earth symbol initiates Google Earth, and a Geo-coding dialog will prompt you to find your Locality.

![http://biolink.googlecode.com/svn/wiki/WhatsNew.attach/GoogleEarth2.png](http://biolink.googlecode.com/svn/wiki/WhatsNew.attach/GoogleEarth2.png)

When the desired position has been located, click on the button “Use current location”. This will seed the Latitude and Longitude values in BioLink, and will prompt to add the Elevation (if applicable). The Source field on the Rapid Data Entry screen will automatically be populated with "Google Earth".

![http://biolink.googlecode.com/svn/wiki/WhatsNew.attach/GoogleEarth1.png](http://biolink.googlecode.com/svn/wiki/WhatsNew.attach/GoogleEarth1.png)

**Note:** If you do not have Google Earth installed the 'Earth' button will not be displayed.

# Loans #

## Find Loans by Taxon name ##

Loans can now be searched by the Taxon name supplied in the material attached to the loan.

![http://biolink.googlecode.com/svn/wiki/WhatsNew.attach/LoansByTaxonName.png](http://biolink.googlecode.com/svn/wiki/WhatsNew.attach/LoansByTaxonName.png)

**Note:** The Find in all (Loan fields) will **not** search the taxon name field.