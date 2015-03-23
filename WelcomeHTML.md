# Introduction #

**Note** This information is aimed at administrators, and assumes a basic working knowledge of HTML.

The Welcome message is a piece of static HTML that is held within the BioLink database under a special pre-defined multimedia category.

To modify the welcome message, first select the "Manage HTML (Welcome page)" menu item from the settings menu.

![http://biolink.googlecode.com/svn/wiki/WelcomeHTML.attach/html1.png](http://biolink.googlecode.com/svn/wiki/WelcomeHTML.attach/html1.png)

A window should appear that looks something like:

![http://biolink.googlecode.com/svn/wiki/WelcomeHTML.attach/html2.png](http://biolink.googlecode.com/svn/wiki/WelcomeHTML.attach/html2.png)

When BioLink starts it will download every file (multimedia) that is added to this window to a temporary folder. It will then select the first HTML (files with extension HTML or HTM) file and attempt to display it in the welcome window (using an Internet Explorer control). In order to avoid ambiguity it is recommended to have only one HTML file in the list. Any static content linked in the HTML (such as images) should be relatively linked (no folders) and added to the list of multimedia on this window.

To create a Welcome Message, using Notepad (or your favourite HTML editor), create a HTML file containing the content you wish to display. For  example:

```
<html>
    <body>
        <div>
            <p align="center">			
                <span>
                    <img width=270 height=270 src="biolink_logo_splash.png" alt="BioLink Logo">
                </span>
            </p>
            <p align="center" style='text-align:center'>
                <span style='font-size:24.0pt;line-height:115%'>Welcome to <span`>BioLink 3.0!</span>			
            </p>
        </div>
    </body>
</html>
```

Save this to Welcome.html, for example (the name is not important, just the extension).

Then ensure any images (or other content you require) is also present. Note in the above example that the image 'biolink\_logo\_splash.png' has a relative location (i.e. it is assumed to be co-located with the html file).

Add the html file to the welcome file list by either clicking on the 'add multimedia' button and locating the file, or by dragging the html file from the Windows Explorer to the Welcome message multimedia window. Ensure that any existing html files that are no longer required are removed from the list as well. Click apply.


![http://biolink.googlecode.com/svn/wiki/WelcomeHTML.attach/html3.png](http://biolink.googlecode.com/svn/wiki/WelcomeHTML.attach/html3.png)

The next time that you log in, your new content should now be displayed.

![http://biolink.googlecode.com/svn/wiki/WelcomeHTML.attach/html4.png](http://biolink.googlecode.com/svn/wiki/WelcomeHTML.attach/html4.png)