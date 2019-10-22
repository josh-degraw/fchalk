module fchalk


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
val cprintf: color: System.ConsoleColor -> str: Printf.StringFormat<'a, unit> -> 'a


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
val cprintfn: color: System.ConsoleColor -> str: Printf.StringFormat<'a, unit> -> 'a


/// **Description**
/// Colors
/// **Parameters**
/// **Output Type**
/// **Exceptions**
val red: System.ConsoleColor
val darkRed: System.ConsoleColor
val blue: System.ConsoleColor
val darkBlue: System.ConsoleColor
val green: System.ConsoleColor
val darkGreen: System.ConsoleColor
val yellow: System.ConsoleColor
val darkYellow: System.ConsoleColor
val cyan: System.ConsoleColor
val darkCyan: System.ConsoleColor
val gray: System.ConsoleColor
val darkGray: System.ConsoleColor
val grey: System.ConsoleColor
val darkGrey: System.ConsoleColor
val white: System.ConsoleColor
val magenta: System.ConsoleColor
val darkMagenta: System.ConsoleColor
val black: System.ConsoleColor

