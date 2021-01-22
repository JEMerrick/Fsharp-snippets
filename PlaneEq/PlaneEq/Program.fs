// Learn more about F# at http://fsharp.org

open System

///Finds the cross product of two 3D vectors
let crossProd3D (v1 : int list) (v2 : int list) : int list = 
    //v3_x = (v1_y * v2_z) - (v1_z * v2_y)
    let v3_x = v1.[1] * v2.[2] - v1.[2] * v2.[1]

    //v3_y = -((v1_x * v2_z) - (v1_z * v2_x))
    let v3_y = - (v1.[0] * v2.[2] - v1.[2] * v2.[0])

    //v3_z = (v1_x * v2_y) - (v1_y * v2_x)
    let v3_z = v1.[0] * v2.[1] - v1.[1] * v2.[0]

    [v3_x; v3_y; v3_z]

///Finds the coefficients of the equation of a plane (ax + by + cz + d = 0) made by 3 points
let planeEq (p1 : int list) (p2 : int list) (p3 : int list) : int list = 
    //find two direction vectors parallel to the plane made by p1, p2, p3
    let q1 = List.map2 (-) p2 p1
    let q2 = List.map2 (-) p3 p1

    //find the normal vector to the plane using the cross product of the parallel vectors
    //this will be the value of a, b, c in the plane equation
    let v = crossProd3D q1 q2

    //the value of d = any point element multiplied with the crossProd vector
    let d = List.map2 (*) v p1 |> List.sum
    v @ [d]

[<EntryPoint>]
let main argv =
    planeEq [10; 20; 5] [15; 10; 10] [25; 20; 10] |> printfn "%A"
    printfn "Hello World from F#!"
    0 // return an integer exit code
