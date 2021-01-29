open System

let fact n =
    if n = 0.0
    then 1.0
    else List.reduce (*) [1.0 .. float n]

let exp x =
    let term i =
        (x ** float(i)) / fact(i)
        
    [0.0..9.0] |> List.map term |> List.reduce (+)

let rec input numList = 
    let line = Console.ReadLine()
    match line with
    | null -> []
    | _ -> (line |> float)::(input numList)
    
[<EntryPoint>]
let main argv = 
    Console.ReadLine() //don't need n
    
    input [] |> List.map exp |> Seq.iter (printf "%f\n" )
    0 // return an integer exit code
