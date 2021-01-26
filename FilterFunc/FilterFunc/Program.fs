open System

let lessThan n nums = 
    let rec test nums =
        match nums with
        | [] -> []
        | head::tail when head < n -> head :: test tail
        | _::tail -> test tail
    test nums

let rec readlines numList = 
    let line = Console.ReadLine()
    match line with
    | null -> []
    | _ -> (line |> int)::(readlines numList)
    
[<EntryPoint>]
let main argv = 
    let n = Console.ReadLine() |> int
    readlines [] |> lessThan n |> Seq.iter (printf "%d\n")
    0 // return an integer exit code