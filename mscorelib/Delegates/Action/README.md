# Action

Shows how to use [System.Action](https://learn.microsoft.com/en-us/dotnet/api/system.action) and [System.Collection.Generic.List.ForEach](https://learn.microsoft.com/en-us/dotnet/api/system.collections.generic.list-1.foreach#system-collections-generic-list-foreach(system-action(()))). 

## Sources

* [src/Action.cs](src/Action.cs)
* [CMakeLists.txt](CMakeLists.txt)

## Build and run with Visual Studio Poject

Open [Action.csproj](Action.csproj)

## Build and run with CMake

To build this project, open "Terminal" and type following lines:

```batch
mkdir build && cd build
cmake ..
start Action.sln
```

Select `Action` project and type Ctrl+F5 to build and run it.

## Output

```
Bruce
Alfred
Tim
Richard
Bruce
Alfred
Tim
Richard
```
