# Array2

Shows how to use [System.Array.GetLowerBound](https://learn.microsoft.com/en-us/dotnet/api/system.array.getlowerbound) and [System.Array.GetUpperBound](https://learn.microsoft.com/en-us/dotnet/api/system.array.getupperbound) methods.

## Sources

* [src/Array2.cs](src/Array2.cs)
* [CMakeLists.txt](CMakeLists.txt)

## Build and run with Visual Studio Poject

Open [Array2.csproj](Array2.csproj)

## Build and run with CMake

To build this project, open "Terminal" and type following lines:

```batch
mkdir build && cd build
cmake ..
start Array2.sln
```

Select `Array2` project and type Ctrl+F5 to build and run it.

## Output

```
The Array has 3 dimension(s) and a total of 24 elements.
        Length  Lower   Upper
0:      2       0       1
1:      3       0       2
2:      4       0       3
The Array contains the following values:
        0       1       2       3
        10      11      12      13
        20      21      22      23
        100     101     102     103
        110     111     112     113
        120     121     122     123
```
