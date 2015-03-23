There are two ways to build BioLink from the source code. The first, and easiest, way is to check out the source code and simply open the BioLink.sln file in Visual Studio 2010 and build it using the build command. This method will not build an installer, or stamp the executables with the build version number, however. The second method, detailed below, uses MSBuild, and requires a little more set up.

**Note** BioLink source code can be edited and built using the free editions of tools supplied by Microsoft. See [Visual C# 2010 Express](http://www.microsoft.com/visualstudio/en-us/products/2010-editions/visual-csharp-express)



## Required tools ##

  * Subversion client (http://subversion.tigris.org/) - SlikSVN, for example.
  * Dot NET Framework version 4.0 (**Note** this will be installed with Visual Studio or Visual C# 2010 Express)
  * The [NullSoft Scriptable Install System](http://nsis.sourceforge.net/Download) (Install with default settings)
  * MSBuild extension pack (http://msbuildextensionpack.codeplex.com/) (Download and install the MSI 4.0.3 version)

## Checkout the source code from the Google Code Repository ##
_For example_
```
C:\>mkdir Biolink
C:\>cd Biolink
C:\Biolink>svn checkout http://biolink.googlecode.com/svn/trunk/ .
```

## Edit the BuildBiolink.proj file ##

BioLink is built using MSBuild, which comes with the .NET Framework. The Atlas of Living Australia uses a continuous integration server that rebuilds BioLink whenever changes are committed to the repository, and the build project has been configured to work on this server. For this reason you may need to edit the build project file slightly in order for it to work on your own system, depending on the nature of your system.

Navigate to the 'build' directory under the directory where the source code has been checked out, and modify `BuildBiolink.proj` so  that the `NSISPath` property points to the actual install location of the NullSoft Scriptable Install System (NSIS) on your machine.

On 32bit systems this will most probably be:

```
    <NSISPath>&quot;C:\Program Files\NSIS\makensis.exe&quot;</NSISPath>
```

> On 64 bit systems it will probably be:

```
    <NSISPath>&quot;C:\Program Files (x86)\NSIS\makensis.exe&quot;</NSISPath>
```

**Note:** the &quot;'s are necessary because of the spaces in the path.

## Build BioLink ##

Use MSBuild to build the solution

  * You must supply a value for the `BuildNumber` property. This number is stamped into each assembly, and the installer filename.
  * MSBuild will not be on the PATH by default. You can either modify your PATH environment variable in include the location of MSBuild (version 4.0.x), or specify its full path on the command line, as demonstrated below.

```
C:\Biolink>cd build
C:\Biolink\build>C:\Windows\Microsoft.NET\Framework\v4.0.30319\MSBuild BuildBioLink.proj /p:BuildNumber=999
```