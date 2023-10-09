# Third Largest Element

The solution is implemented using C# as my favorite language.
Quite a few sorting options could be used here. Like OrderByDescending() or SortedSet or Distinct(). And depending on the concrete instance they might be a good fit, but in general all of them will have O(n log n) complexity.
Because of that and because of the requirement to use no sorting ;) I choose the simple loop scenario where the complexity is O(n). I made it generic since the data type is not specified. The approach is to use IComparable, which gives us support to all numeric types in .NET and also for Char, String and DateTime.
