#r "FAKE/tools/FakeLib.dll"
open System
open System.IO
open Fake

let buildDir = "./build"

let ilasm file =
  let output = Path.Combine(buildDir, Path.GetFileNameWithoutExtension(file) + ".exe")
  let result = ExecProcess (fun info ->
                            info.FileName <- "ilasm"
                            info.Arguments <- sprintf "\"%A\" /debug /output=\"%A\"" file output) (TimeSpan.FromMinutes 5.0)
  if (result <> 0) then failwithf "%A compilation failed" file

Target "Clean" (fun _ ->
    CleanDir buildDir
)

Target "Default" (fun _ ->
                  ilasm "Simple.il"
                  ilasm "Simple1.il"
                  ilasm "Simple2.il"
                  ilasm "Simple3.il"
                  ilasm "Simple4.il"
)

// Dependencies
"Clean"
  ==> "Default"

// start build
RunTargetOrDefault "Default"
