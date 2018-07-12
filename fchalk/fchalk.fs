module fchalk

open System
open Printf

///**Description**
/// Colored printf, Inspired by https://blogs.msdn.microsoft.com/chrsmith/2008/10/01/f-zen-colored-printf/
///


let private consoleColor (fc : ConsoleColor) = 
    let current = Console.ForegroundColor
    Console.ForegroundColor <- fc
    { new IDisposable with
          member x.Dispose() = Console.ForegroundColor <- current }

let cprintf color str =
  kprintf (fun s -> use c = consoleColor color in printf "%s" s) str
  

let cprintfn color str = 
  kprintf (fun s -> use c = consoleColor color in printfn "%s" s) str


let red = ConsoleColor.Red
let darkRed = ConsoleColor.DarkRed
let blue = ConsoleColor.Blue
let darkBlue = ConsoleColor.DarkBlue
let green = ConsoleColor.Green
let darkGreen = ConsoleColor.DarkGreen
let yellow = ConsoleColor.Yellow
let darkYellow = ConsoleColor.DarkYellow
let cyan  = ConsoleColor.Cyan
let darkCyan = ConsoleColor.DarkCyan
let gray = ConsoleColor.Gray
let darkGray = ConsoleColor.DarkGray
let grey = gray
let darkGrey = darkGray
let white = ConsoleColor.White
let magenta = ConsoleColor.Magenta
let darkMagenta = ConsoleColor.DarkMagenta
let black = ConsoleColor.Black