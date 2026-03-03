# Project
This little practice-project showcases how LINQ can be used with objects and collections in C# with .NET 9.

# Basics
There are two ways to approach LINQ:

Method syntax that uses `lambda` expressions:
```c#
var cheapTools = _db.Tools
    .Where(t => t.Price < 50)
    .OrderBy(t => t.Name)
    .ToList();
```

Query syntax, which is similar to SQL:
```c#
var cheapTools2 = from t in _db.Tools
                  where t.Price < 50
                  orderby t.Name
                  select t;
```

# Usage
1. Clone the project
2. Uncomment the function calls
3. Run with `dotnet run`
# Author
[Yosmel Chiang](https://github.com/yosang)