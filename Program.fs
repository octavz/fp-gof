open System
open Visitor

[<EntryPoint>]
let main argv =
    let exp = Div(Sum(Prod(Num(10.0), Num(34.0)), Num(25.0)), Num(4.0))
    let result = eval exp
    let printed = print exp
    printfn "%s = %.2f" printed result
    0 // return an integer exit code




