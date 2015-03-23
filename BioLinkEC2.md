# Hosting a Biolink Database in the Amazon Web Services Cloud (EC2) #



## Introduction ##

The following steps show you how to build a BioLink database server using Amazon's Web Services (AWS). This is a cheap and potentially free hosting solution which facilitates sharing your data.

## Step 1: Create an AWS account with Amazon ##
Instructions on establishing an AWS account are at http://aws.amazon.com/.

## Step 2: Build a Windows virtual machine in the cloud. ##

### 2.1 Use the <b>Request Instances</b> wizard to build your machine ###
  * Go to http://aws.amazon.com/ and click on the <b>My Account / Console</b> link at the top of the page, then <b>AWS Management Console</b> on the drop-down list. You will be asked for your AWS user name and password if you are not logged in.
  * Click on the <b>EC2</b> icon.
  * Choose a geographic region from the drop-down list at the top of the **Navigation** panel.
  * Click on the <b>Launch Instance</b> button. This launches the <b>Request Instances</b> wizard.
    * On the <b>Create a New Instance</b> page, select the <b>Quick Launch Wizard</b>.
    * <b>Name Your Instance:</b> This will be the name of your server. I suggest "BioLink".
    * <b>Choose a Key Pair:</b> This is used to encrypt your Windows password. Create a new key pair with "mykey" as your key. Click on the <b>Download</b> button to save your key pair in a file, "mykey.pem", for later use. This will be saved in the default downloads folder on your local machine.
    * <b>Choose a Launch Configuration:</b> Select "Microsoft Windows Server 2008 [R2](https://code.google.com/p/biolink/source/detail?r=2) with SQL Server Express and IIS 64 bit".
    * Press the <b>Continue</b> button.
    * Press the <b>Launch</b> button.
    * Click the <b>View your instances on the Instances Page</b> link.

### 2.2 Get a static IP address for your new machine ###
  * Select your new machine on the <b>Instances</b> page.
  * Click on the <b>Elastic IPs</b> link in the left hand frame.
  * Click on the <b>Allocate Address</b> button.
  * Click on the <b>Associate Address</b> button and associate the IP address with your new machine.

### 2.3 Get the Windows password for your new machine ###
  * Right click on the record for your new machine on the <b>Instances</b> page.
  * In the drop down menu, select <b>Get Windows password</b>.
  * Press the <b>Choose file</b> button and locate the "mykey.pem" file you downloaded in a previous step.
  * Press the <b>Decrypt Password</b> button and record the decrypted password. This is the Windows password that will authenticate you as <b>Administrator</b> of your new machine.

## Step 3: Log onto your virtual machine ##

### 3.1 Establish a Remote Desktop Connection ###
  * We will use the Remote Desktop Connection program provided with Windows XP and later versions.
  * Click <b>Start | All Programs | Accessories | Remote Desktop Connection</b>
  * For <b>Computer:</b>, enter the static IP (Elastic IP) address for your new computer and  press the <b>Connect</b> button.
  * Log on as **Administrator** using the Windows password you got in a previous step.

### 3.2 Change your the Windows password for your new machine ###
  * It is recommended to change your windows password to something you are likely to remember.
  * On your remote desktop click <b>Start | Windows Security | Change a Password ...</b>

## Step 4: Configure MS SQL Server on your virtual machine ##

### 4.1 Change server authentication method ###
  * Launch the Microsoft SQL Server Management Studio on your remote desktop: Click **Start | All Programs | Microsoft SQL Server 2008 [R2](https://code.google.com/p/biolink/source/detail?r=2) | SQL Server Management Studio**
  * On the <b>Connect to Server</b> dialog, click the <b>Connect</b> button.
  * Right click on the server icon which is the top most item in tree in the <b>Object Explorer</b> panel, then click on <b>Properties</b> in the drop down menu.
  * Select the <b>Security</b> page.
  * Under <b>Server authentication</b>, select <b>SQL Server and Windows Authentication mode</b>
  * Click the <b>OK</b> button.
  * Right click on the server object in the <b>Object Explorer</b> panel and select <b>Restart</b> in the drop down menu.
  * Keep <b>Server Management Studio</b> open for the next step.

### 4.2 Enable "sa" user ###
  * In the <b>Object Explorer</b> panel of the <b>Server Management Studio</b> window, click on <b>Security</b> and then <b>Logins</b>.
  * Right click on the <b>sa</b> user and select <b>Properties</b>.
  * On the <b>Login Properties - sa - General</b> page, deselect <b>Enforce password policy</b> and provide a new password for <b>sa</b>
  * On the <b>Login Properties - sa - Status</b> page, confirm that <b>Login:</b> is enabled.
  * Select <b>View | Refresh</b> and confirm that the little red arrow on the <b>sa</b> icon disappears. (The red arrow indicates that a user is not enabled.)
  * Keep <b>Server Management Studio</b> open for the next step.

## Step 5: Attach a BioLink database ##
In this example, we will attach the BiolinkStarter database available from the BioLink site at http://biolink.googlecode.com/files/BioLinkStarter.mdf. An alternative to downloading a .mdf file from the web is to copy a file from your local machine to your remote server. A simple copy and paste from the local machine to the remote desktop window works for me.

### 5.1 Download a BioLink database ###
  * You will probably have to enable downloads in the Internet Explorer instance on your server. On your remote desktop, launch IE, click the tools icon, select **Internet options**, on the **Security** tab click <b>Custom level ...</b>, enable <b>Downloads | File download</b>.
  * Navigate to the BioLink project site and download <b>BiolinkStarter.mdf</b>. Save the file at a logical location, C:\data\BiolinkStarter.mdf for example.

### 5.2 Attach the database ###
  * In the <b>Object Explorer</b> panel of the <b>Server Management Studio</b> window, right click on <b>Databases</b> and then <b>Attach ...</b>.
  * Click on the <b>Add ...</b> and locate the <b>BioLinkStarter.mdf</b> file you just downloaded.
  * In the <b>BiolinkStarter details</b> panel, select the record for the log file and click the <b>Remove</b> button. (A log file will be created automatically.)
  * Click <b>Ok</b>.
  * You can now close **Server Management Studio** and your remote desktop. Your SQL server will remain running in the cloud.

## Step 6: Connect a BioLink client to your online database ##
  * If you haven't done so already, download and install the BioLink client software, available from http://code.google.com/p/biolink/downloads/list.
  * Launch BioLink and create a new profile for your online database
    * <b>Name:</b> BioLinkStarter on 11.22.33.44
    * <b>Server/Instance:</b> 11.22.33.44
    * <b>Database:</b> BiolinkStarter
  * Of course, you will substitute the fixed IP address for your remote server for 11.22.33.44
  * Log onto the remote server using the new profile with <b>sa</b> as the user and whatever you set as the password for <b>sa</b>.
  * If successful, you can now use the <b>sa</b> account to create user accounts and control access privileges for collaborators and guests.

## Notes ##
  1. I was unable to delete users imported with a database. Error message was "'Laura' is not a valid login or you do not have permission.". However, I found an easy workaround. I simply created a new user called 'Laura' and then deleted it.