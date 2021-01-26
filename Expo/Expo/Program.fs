let fact n =
    [1.0 .. n] |> List.reduce (*)

let exp x =
    let term i =
        (float(x) ** float(i)) / fact(i)
    [0.0..9.0] |> List.map term |> List.reduce (+)

let input = 
    stdin.ReadToEnd().Split '\n' 
    |> Array.map(fun x -> int(x)) 
    |> Array.toList
    
[<EntryPoint>]
let main argv = 
    input |> List.map exp |> printf "%A\n" 
    0 // return an integer exit code