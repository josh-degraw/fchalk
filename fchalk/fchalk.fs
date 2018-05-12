module fchalk

open System

///**Description**
/// Colored printf, Inspired by https://blogs.msdn.microsoft.com/chrsmith/2008/10/01/f-zen-colored-printf/    
///
///**Parameters**
///  * `c` - parameter of type `ConsoleColor`
///  * `fmt` - parameter of type `Printf.StringFormat<'a,unit>`
///
///**Output Type**
///  * `'a`
///
///**Exceptions**
///
let cprintf c fmt = 
    Printf.kprintf
        (fun s ->
            let old = Console.ForegroundColor
            try
              Console.ForegroundColor <- c;
              Console.Write s

            finally
              Console.ForegroundColor <- old)
        fmt


///**Description**
/// Colored printfn
///**Parameters**
///  * `c` - parameter of type `ConsoleColor`
///  * `fmt` - parameter of type `Printf.StringFormat<unit,unit>`
///
///**Output Type**
///  * `unit`
let cprintfn c fmt =
    cprintf c fmt
    printfn ""

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

