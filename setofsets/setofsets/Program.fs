// Learn more about F# at http://fsharp.org

open System


let q7 (el: int) (setOfSets: int Set Set) =
    let isNotEmpty myList =
        if List.isEmpty myList
        then false
        else true
        

    setOfSets 
    |> Set.toList  
    |> List.map (Set.toList)
    |> List.map (List.filter ((=) el)) 
    |> List.filter (isNotEmpty) 
    |> List.length 
    

[<EntryPoint>]
let main argv =
    let a = set [set[1; 2]; set[2; 3]; set[1]]
    q7 2 a |> printf "%A\n"
    
    printfn "Hello World from F#!"
    0 // return an integer exit code
