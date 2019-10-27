#load "../src/fchalk/fchalk.fs"

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

cprintfn red "Hello %i" 5

cprintfn yellow "I Love %s and I have %i of them" "Cats" 8