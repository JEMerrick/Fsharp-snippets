open System

let printNum n myString = 
    seq { 1 .. n }
    |> Seq.iter (fun _ -> printfn "%s" myString)
    

[<EntryPoint>]
let main argv = 
    let num = Console.ReadLine() |> int
    printNum num "Hello World"
    0 // return an integer exit code