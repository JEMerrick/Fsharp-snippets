open System

let rec fib n =
    match n with
    | 0 | 1 -> 0
    | 2 -> 1
    | n -> fib(n - 1) + fib(n - 2)
    

[<EntryPoint>]
let main argv =
    let n = Console.ReadLine() |> int
    fib n |> printf"%A\n" 
    0 // return an integer exit code
