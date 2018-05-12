#load "./fchalk.fs"

open System
open fchalk;

[
    red
    darkRed
    cyan    
    darkCyan
    green
    darkGreen
    blue
    darkBlue
    yellow
    darkYellow
    magenta
    darkMagenta
    white
    gray
    darkGray
    black
]
|> List.iter (fun c -> cprintfn c "I love printing in color in F#!")