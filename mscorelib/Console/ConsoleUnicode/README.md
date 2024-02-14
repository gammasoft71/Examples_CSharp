# ConsoleUnicode

Shows how to use [System.Console](https://learn.microsoft.com/en-us/dotnet/api/system.console) class with unicode text.

## Sources

* [src/ConsoleUnicode.cs](src/ConsoleUnicode.cs)
* [CMakeLists.txt](CMakeLists.txt)

## Build and run with Visual Studio Poject

Open [ConsoleUnicode.csproj](ConsoleUnicode.csproj)

## Build and run with CMake

To build this project, open "Terminal" and type following lines:

```batch
mkdir build && cd build
cmake ..
start ConsoleUnicode.sln
```

Select `ConsoleUnicode` project and type Ctrl+F5 to build and run it.

## Output

```
А  Б  В  Г  Д  Е  Ж  З  И  Й  К  Л  М  Н  О  П  Р  С  Т  У  Ф  Х  Ц  Ч
Ш  Щ  Ъ  Ы  Ь  Э  Ю  Я  а  б  в  г  д  е  ж  з  и  й  к  л  м  н  о  п
р  с  т  у  ф  х  ц  ч  ш  щ  ъ  ы  ь  э  ю  я
```

