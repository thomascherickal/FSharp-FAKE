﻿namespace System
open System.Reflection
open System.Runtime.InteropServices

[<assembly: AssemblyTitleAttribute("FAKE - F# Make Command line tool")>]
[<assembly: GuidAttribute("fb2b540f-d97a-4660-972f-5eeff8120fba")>]
[<assembly: AssemblyProductAttribute("FAKE - F# Make")>]
[<assembly: AssemblyVersionAttribute("3.14.4")>]
[<assembly: AssemblyInformationalVersionAttribute("3.14.4")>]
[<assembly: AssemblyFileVersionAttribute("3.14.4")>]
do ()

module internal AssemblyVersionInformation =
    let [<Literal>] Version = "3.14.4"
