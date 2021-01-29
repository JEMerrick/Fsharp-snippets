open System

let readIn () = 
    let count = Console.ReadLine () |> int
    [for _ in 1 .. count -> Console.ReadLine().Split(' ') |> Array.map (fun v -> int v) |> List.ofArray]


let checkList inList =
    
    let foundDiff = 
        inList
        |> Seq.distinct |> List.ofSeq //remove duplicate entries
        |> List.countBy (fun [a; _] -> a ) //count by x value occurences
        |> List.filter (fun (_, snd) -> snd > 1) //find any x values appear twice
    
    //if any multivalued maps i.e. x->y and x->z was found, then our function is not valid
    if List.length foundDiff > 0
    then printfn "NO"
    else printfn "YES"

[<EntryPoint>]
let main argv =
    let count = Console.ReadLine() |> int
    [for _ in 1 .. count -> readIn () |> checkList]
    0 // return an integer exit code