# ConsoleBackgroundColor

Shows how to use [System.Console.BackgroundColor](https://learn.microsoft.com/en-us/dotnet/api/system.console.backgroundcolor) property. 

## Sources

* [src/ConsoleBackgroundColor.cs](src/ConsoleBackgroundColor.cs)
* [CMakeLists.txt](CMakeLists.txt)

## Build and run with Visual Studio Poject

Open [ConsoleBackgroundColor.csproj](ConsoleBackgroundColor.csproj)

## Build and run with CMake

To build this project, open "Terminal" and type following lines:

```batch
mkdir build && cd build
cmake ..
start ConsoleBackgroundColor.sln
```

Select `ConsoleBackgroundColor` project and type Ctrl+F5 to build and run it.

## Output

```
All the foreground colors except Black, the background color:
   The foreground color is DarkBlue.
   The foreground color is DarkGreen.
   The foreground color is DarkCyan.
   The foreground color is DarkRed.
   The foreground color is DarkMagenta.
   The foreground color is DarkYellow.
   The foreground color is Gray.
   The foreground color is DarkGray.
   The foreground color is Blue.
   The foreground color is Green.
   The foreground color is Cyan.
   The foreground color is Red.
   The foreground color is Magenta.
   The foreground color is Yellow.
   The foreground color is White.

All the background colors except Gray, the foreground color:
   The background color is Black.
   The background color is DarkBlue.
   The background color is DarkGreen.
   The background color is DarkCyan.
   The background color is DarkRed.
   The background color is DarkMagenta.
   The background color is DarkYellow.
   The background color is DarkGray.
   The background color is Blue.
   The background color is Green.
   The background color is Cyan.
   The background color is Red.
   The background color is Magenta.
   The background color is Yellow.
   The background color is White.

Original colors restored...
`
