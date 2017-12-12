// Learn more about F# at http://fsharp.org
// See the 'F# Tutorial' project for more help.
open System;

[<EntryPoint>]
let main argv = 
    let amount = Console.ReadLine() |> int
    let array = [|for i in 1 .. amount -> Console.ReadLine() |> int|]

    let mutable max = 0
    let mutable temporaryMax = 0
    
    for i = 0 to amount - 1 do
        temporaryMax <- temporaryMax + array.[i]
        if temporaryMax > max then
            max <- temporaryMax
            
        if temporaryMax < 0 then
           temporaryMax <- 0
           
        
    Console.WriteLine(max)
    0 // return an integer exit code
