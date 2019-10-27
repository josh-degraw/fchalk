///**Description**
/// Colored printf, Inspired by https://blogs.msdn.microsoft.com/chrsmith/2008/10/01/f-zen-colored-printf/
///
module fchalk

open System
open Printf

let inline private useConsoleColor (fc : ConsoleColor) =
    let current = Console.ForegroundColor
    Console.ForegroundColor <- fc
    {
       new IDisposable with
          member _.Dispose() = Console.ForegroundColor <- current
    }

/// **Description**
/// Print to the console
/// **Parameters**
///   * `color` - parameter of type `ConsoleColor`
///   * `str` - parameter of type `StringFormat<'a,unit>`
///
/// **Output Type**
///   * `'a`
///
/// **Exceptions**
///
let inline cprintf color str = kprintf (fun s -> use __ = useConsoleColor color in printf "%s" s) str

/// **Description**
/// Print to the console, with a newline
/// **Parameters**
///   * `color` - parameter of type `ConsoleColor`
///   * `str` - parameter of type `StringFormat<'a,unit>`
///
/// **Output Type**
///   * `'a`
///
/// **Exceptions**
///
let inline cprintfn color str = kprintf (fun s -> use __ = useConsoleColor color in printfn "%s" s) str

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