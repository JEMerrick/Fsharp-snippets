open System

let filterIndex nums = 
    nums 
    |> Seq.mapi (fun i v -> (i, v))
    |> Seq.filter (fun (i, v) -> i % 2 = 1)
    |> Seq.map (fun (i, v) -> v)
    

let rec readlines numList = 
    let line = Console.ReadLine()
    match line with
    | null -> []
    | _ -> (line |> int)::(readlines numList)
    
[<EntryPoint>]
let main argv = 
    readlines [] |> filterIndex |> Seq.iter (printf "%A\n")
    0 // return an integer exit code