type Explainer() =
    member this.explain(cmd: (string * string) []): string =
        cmd
        |> Array.map (fun (left, _) -> left)
        |> String.concat " "
