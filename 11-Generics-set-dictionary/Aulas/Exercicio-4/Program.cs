namespace Course;

class Program
{

    static void Main(string[] args)
    {
        SortedSet<int> a = new SortedSet<int>() { 0, 2, 4, 5, 6, 8, 10 };
        SortedSet<int> b = new SortedSet<int>() { 5, 6, 7, 8, 9, 10 };

        // union
        SortedSet<int> c = new SortedSet<int>(a);
        c.UnionWith(b);

        SortedSet<int> d = new SortedSet<int>(a);
        d.IntersectWith(b);

        SortedSet<int> e = new SortedSet<int>(a);
        e.ExceptWith(b);

        PrintCollection(a, "a");
        PrintCollection(b, "b");
        PrintCollection(c, "c");
        PrintCollection(d, "d");
        PrintCollection(e, "e");
    }

    static void PrintCollection<T>(IEnumerable<T> collection, string? name = null)
    {
        if (name != null) Console.Write($"Collection {name}: {{ ");

        foreach (T item in collection)
        {
            if (name != null)
            {
                Console.Write( item + " ");
            }
        }
        Console.Write("}");
        Console.WriteLine();
    }
}
