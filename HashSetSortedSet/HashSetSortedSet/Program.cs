

HashSet<string> set = new HashSet<string>();
set.Add("TV");
set.Add("Notebook");
set.Add("Tablet");


Console.WriteLine(set.Contains("Notebook"));

// No hashset utilizar o foreach.
foreach (String p in set)
{
    Console.WriteLine(p);
}

// Exemplo sorted.
SortedSet<int> a = new SortedSet<int>() { 0, 2, 4, 5, 6, 8, 10 };
SortedSet<int> b = new SortedSet<int>() { 5, 6, 7, 8, 9, 10 };


// União 
SortedSet<int> c = new SortedSet<int>(a);
c.UnionWith(b);
printCollection(c);


// Interseção entre os grupos.
SortedSet<int> d = new SortedSet<int>(a);
d.IntersectWith(b);
printCollection(d);

// Diferença.
SortedSet<int> e = new SortedSet<int>(a);
e.ExceptWith(b);
printCollection(e);

static void printCollection<T>(IEnumerable<T> collection)
{
    foreach (T obj in collection)
    {
        Console.Write(obj + " ");
    }
    Console.WriteLine();
}