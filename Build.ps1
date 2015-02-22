if (-not (Test-Path fake)) {
    NuGet install FAKE -Version 3.17.4 -OutputDirectory . -ExcludeVersion
}

FAKE\tools\FAKE.exe build.fsx
