open System

let replicate n nums = 
    //Can also use (List.replicate >> List.collect) n nums
    nums |> List.collect (fun x -> List.replicate n x)

let rec readlines numList = 
    let line = Console.ReadLine()
    match line with
    | null -> []
    | _ -> (line |> int)::(readlines numList)
    
[<EntryPoint>]
let main argv = 
    let n = Console.ReadLine() |> int
    readlines [] |> replicate n |> Seq.iter (printf "%d\n")
    0 // return an integer exit code