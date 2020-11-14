module Tests

open System
open Program
open Xunit


[<Fact>]
let Explain () =
    Assert.Equal(Explain.from "Max", "from Max")
