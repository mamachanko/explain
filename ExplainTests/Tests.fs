module Tests

open NUnit.Framework
open Program


[<TestFixture>]
type ExplainTests() =

    [<Test>]
    member x.Explain_ReturnsCommand() =
        let explainer = Explainer()
        Assert.That
            (explainer.explain [| ("echo", "Writes arguments to the standard output")
                                  ("hello", "The thing to write to the standard output") |],
             Is.EqualTo "echo hello")
