open System
open Visitor
open Strategy

let testVisitor = 
  let exp = Div(Sum(Prod(Num(10.0), Num(34.0)), Num(25.0)), Num(4.0))
  let result = eval exp
  let printed = print exp
  printfn "%s = %.2f\n\n" printed result

let testStrategy = 
  let lst = [63;4235;2453;25;99;14;233;1;23;42;12;45652;1365]
  let compareNumeric = (>=)
  let compareStrings a b = a.ToString() >= b.ToString()
  let compareSizes a b = a.ToString().Length >= b.ToString().Length
  printfn "Numeric sort: %A\n" (sort compareNumeric lst)
  printfn "String sort: %A\n" (sort compareStrings lst)
  printfn "By size sort: %A\n" (sort compareSizes lst)

[<EntryPoint>]
let main argv =
  testVisitor
  testStrategy
  0 // return an integer exit code




