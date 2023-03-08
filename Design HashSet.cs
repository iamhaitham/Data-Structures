public class Program
{
    public static void Main()
    {
        MyHashSet myHashSet = new MyHashSet();
        myHashSet.Add(1);  // set = [1]
        myHashSet.Add(2);  // set = [1, 2]
        Console.WriteLine(myHashSet.Contains(1)); // return True
        Console.WriteLine(myHashSet.Contains(3)); // return False, (not found)
        myHashSet.Add(2);  // set = [1, 2]
        Console.WriteLine(myHashSet.Contains(2)); // return True
        myHashSet.Remove(2);  // set = [1]
        Console.WriteLine(myHashSet.Contains(2)); // return False, (already removed)
    }
}

public class MyHashSet
{
    private readonly int[] _hashSet;

    public MyHashSet()
    {
        _hashSet = new int[(int)Math.Pow(10, 6) + 1];
        Array.Fill(_hashSet, -1);
    }

    public void Add(int key)
    {
        _hashSet[key] = key;
    }

    public void Remove(int key)
    {
        _hashSet[key] = -1;
    }

    public bool Contains(int key)
    {
        return _hashSet[key] != -1;
    }
}
