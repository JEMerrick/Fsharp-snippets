open System

let sumOdd nums = 
    nums 
    |> List.filter (fun v -> abs v % 2 = 1)
    |> List.sum
    

let rec readlines numList = 
    let line = Console.ReadLine()
    match line with
    | null -> []
    | _ -> (line |> int)::(readlines numList)
    
[<EntryPoint>]
let main argv = 
    readlines [] |> sumOdd |> printf "%A" 
    0 // return an integer exit code