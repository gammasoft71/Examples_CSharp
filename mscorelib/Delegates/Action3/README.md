# Action3

Shows how to use [System.Action](https://learn.microsoft.com/en-us/dotnet/api/system.action). 

## Sources

* [src/Action3.cs](src/Action3.cs)
* [CMakeLists.txt](CMakeLists.txt)

## Build and run with Visual Studio Poject

Open [Action3.csproj](Action3.csproj)

## Build and run with CMake

To build this project, open "Terminal" and type following lines:

```batch
mkdir build && cd build
cmake ..
start Action3.sln
```

Select `Action3` project and type Ctrl+F5 to build and run it.

## Output

* If `Action3` is called without param

```
Hello, World!
```

* If `Action3` is called with any param

![Screenshot](../../../docs/Pictures/mscorelib/Action3.png)
