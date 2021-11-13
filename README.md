# Apress Source Code

This repository accompanies [*Expert .NET 2.0 IL Assembler*](http://www.apress.com/9781590596463) by Serge Lidin (Apress, 2006).

![Cover image](9781590596463.jpg)

Download the files as a zip using the green button, or clone the repository to your machine using Git.

## Releases

Release v1.0 corresponds to the code in the published book, without corrections or updates.

## Contributions

See the file Contributing.md for more information on how you can contribute to this repository.

## Changes in comparison to the original book samples

Unfortunately, some of the samples are slightly outdated. They were perfectly okay for .NET 2.0, but today versions have some additional defaults so not all samples work. I've decided to improve and update these samples as I read the book.

### Building

To build all the sources you may use [FAKE](http://fsharp.github.io/FAKE/). First, install
[NuGet](https://www.nuget.org/), then get FAKE through it:

    NuGet install FAKE -Version 3.17.4 -OutputDirectory . -ExcludeVersion

It will download FAKE to the current directory. Then run FAKE:

    FAKE\tools\FAKE.exe build.fsx

To execute `ilasm` you'll need it in `PATH` environment variable. One simple way pf providing it is installing the
[PowerShell Community Extensions](https://pscx.codeplex.com/) and running `Import-VisualStudioVars 2013` from PowerShell
Prompt before running the FAKE. Another way is running the FAKE from the Visual Studio Command Prompt.

There is a simple PowerShell script `Build.ps1` for downloading FAKE and running the build.
