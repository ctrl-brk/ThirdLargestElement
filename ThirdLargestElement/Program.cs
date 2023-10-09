var rand = new Random();
const int ARRAY_SIZE = 1000;

var ints = Enumerable.Range(1, ARRAY_SIZE)
    .Select(i => new Tuple<int, int>(rand.Next(ARRAY_SIZE), i))
    .OrderBy(i => i.Item1)
    .Select(i => i.Item2)
    .ToList();

Console.WriteLine(FindThirdLargestElement(ints));
return;

T FindThirdLargestElement<T>(List<T> elements) where T : IComparable<T>
{
    if (elements.Count < 3)
        throw new InvalidOperationException("List must have at least 3 unique elements");

    T? first = default, second = default, third = default;

    foreach (var num in elements)
    {
        if (first == null || num.CompareTo(first) > 0)
        {
            third = second;
            second = first;
            first = num;
        }
        else if (second == null || (num.CompareTo(second) > 0 && num.CompareTo(first) < 0))
        {
            third = second;
            second = num;
        }
        else if (third == null || (num.CompareTo(third) > 0 && num.CompareTo(second) < 0))
        {
            third = num;
        }
    }

    if (third is null)
        throw new InvalidOperationException("List must have at least 3 unique elements");
    
    return third;
}
