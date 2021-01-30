open System

let rec readlines numList = 
    let line = Console.ReadLine()
    match line with
    | null -> []
    | _ -> (line.Split(' ') 
            |> Array.map (fun v -> int v) 
            |> Array.toList)::(readlines numList)

let lengthPoints (points : int list list) =
    let p1 = points.[0]
    let p2 = points.[1]
    let x = float(p1.[0] - p2.[0])
    let y = float(p1.[1] - p2.[1])
    sqrt ((x ** 2.0) + (y ** 2.0))

let polygonPerimeter (points : int list list) =
    //read input
    //duplicate each point
    //remove the last value duplicate from the list
    let pointList = 
        points
        |> List.collect (fun v -> List.replicate 2 v) 
        |> List.rev 
        |> List.tail 
        |> List.rev
    
    //find the last value and add to start of list
    let last = List.last pointList
    let allPoints = List.append [last] pointList

    //chunkby 2 to get each pair of points
    //find the length between each pair
    //sum the lengths
    allPoints 
    |> List.chunkBySize 2 
    |> List.map lengthPoints 
    |> List.reduce (+) 
    |> printf"%A" 

[<EntryPoint>]
let main argv =
    Console.ReadLine() //dont need n
    
    
    readlines [] |> polygonPerimeter
        
    
    0 // return an integer exit code