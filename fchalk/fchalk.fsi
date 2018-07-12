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