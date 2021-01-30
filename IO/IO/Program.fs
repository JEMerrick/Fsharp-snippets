// Learn more about F# at http://fsharp.org

open System

//Read many items in one line into a list of ints
//Needs to be called in a for loop for multiple uses

let InputToList () =
    Console.ReadLine().Split(' ') |> List.ofArray |> List.map (fun v -> int(v))

//Reads all input lines, where one item per line into a list (of ints)

let rec readlines numList = 
    let line = Console.ReadLine()
    match line with
    | null -> []
    | _ -> (line |> int)::(readlines numList)

//Reads all input lines and makes a list where each line = one item in the list 
let input = 
    stdin.ReadToEnd().Split '\n' 
    |> Array.map(fun x -> int(x)) 
    |> Array.toList
   
//Reads all input lines and makes a list of lists
//Each line = one item in the outer list, each value spaced by ' ' in a line is an item in the inner list
let rec read numList = 
    let line = Console.ReadLine()
    match line with
    | null -> []
    | _ -> (line.Split(' ') 
            |> Array.map (fun v -> int v) 
            |> Array.toList)::(read numList)
    

[<EntryPoint>]
let main argv =
    printfn "Hello World from F#!"
    0 // return an integer exit code
