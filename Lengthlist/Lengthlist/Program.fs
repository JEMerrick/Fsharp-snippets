open System

let findLength nums = 
    List.fold (fun count _ -> count + 1) 0 nums
        
let rec readlines numList = 
    let line = Console.ReadLine()
    match line with
    | null -> []
    | _ -> (line |> int)::(readlines numList)
    
[<EntryPoint>]
let main argv = 
    readlines [] |> findLength |> printf "%A" 
    0 // return an integer exit code