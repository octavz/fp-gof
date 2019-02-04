module Visitor

type Expr = Num of double | Sum of Expr*Expr | Prod of Expr*Expr | Div of Expr*Expr 

let rec eval e = 
  match e with 
  | Num n -> n
  | Sum (l,r) -> eval l + eval r
  | Prod (l,r) -> eval l * eval r
  | Div (l,r) -> eval l / eval r

let rec print e = 
  match e with 
  | Num n -> sprintf "%O" n
  | Sum (l,r) -> sprintf "(%s+%s)" (print l)  (print r)
  | Prod (l,r) -> sprintf "(%s*%s)" (print l)  (print r)
  | Div (l,r) -> sprintf "(%s/%s)" (print l)  (print r)
