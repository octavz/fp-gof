module ChainOfResponsability
open System

[<Flags>]
type LogLevel = 
    | None = 0
    | Info = 1
    | Debug = 2
    | Warning = 4
    | Error = 8
    | FunctionalMessage = 16
    | FunctionalError = 32
    | All = 63            

type Logger = LogLevel -> Logger -> Logger

type Rule = { Current: Logger; Next: Rule}

let write logger = 
  match logger with
  | ConsoleLogger(v) -> printfn "Writing to console: %s" v
  | EmailLogger(v) -> printfn "Writing to email: %s" v
  | FileLogger(v) -> printfn "Writing to file: %s" v
  | End -> ()

let rec handle (rule: Rule): unit = 
  write  rule.Current
  handle rule.Next

//ConsoleLogger(,EmailLogger(FileLogger)).message("stuff")