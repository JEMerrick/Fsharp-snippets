// Learn more about F# at http://fsharp.org

open System

let InputToList () =
    Console.ReadLine().Split(' ') |> List.ofArray |> List.map (fun v -> int(v))

let rec readlines numList = 
    let line = Console.ReadLine()
    match line with
    | null -> []
    | _ -> (line |> int)::(readlines numList)

let input = 
    stdin.ReadToEnd().Split '\n' 
    |> Array.map(fun x -> int(x)) 
    |> Array.toList
    
[<EntryPoint>]
let main argv =
    printfn "Hello World from F#!"
    0 // return an integer exit code
