open System


let squared expression = 
    List.allPairs expression expression // ((coef1, pow1), (coef2, pow2)) 
    |> List.map (fun ((coef1, pow1), (coef2, pow2)) -> (coef1 * coef2, pow1 + pow2))
    
let integrate (coef, pow) =
    (coef / (pow + 1.0), pow + 1.0)
    
let evalLim integral lim = 
    integral 
    |> List.map (fun (coef, pow) -> float(coef) * (float(lim) ** float(pow))) //coeff * limit ^ pow
    |> List.reduce(+) //sum all the terms
    
let evalIntegral (lim : int list) integral =
    let upperlim = lim.[1]
    let lowerlim = lim.[0]
    evalLim integral upperlim - evalLim integral lowerlim //upper value - lower value
    
let area coef pow lim =
    //integrate func -> evaluate at limits
    List.map2 (fun a b -> (float(a), float(b))) coef pow 
    |> List.map integrate 
    |> evalIntegral lim
    
let volume coef pow lim =
    List.map2 (fun a b -> (float(a), float(b))) coef pow 
    |> squared
    |> List.map integrate
    |> evalIntegral lim
    |> Operators.(*) Math.PI
    
let InputToList () =
    Console.ReadLine().Split(' ') |> List.ofArray |> List.map (fun v -> int(v))
    
[<EntryPoint>]
let main argv = 
    let coef = InputToList ()
    let pow = InputToList ()
    let lim = InputToList ()
    area coef pow lim |> printf "%A\n"
    volume coef pow lim |> printf "%A\n"
    0 // return an integer exit code
