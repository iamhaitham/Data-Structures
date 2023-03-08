public class Program
{
    public static void Main()
    {
        MyHashMap myHashMap = new MyHashMap();
        myHashMap.Put(1, 1); // The map is now [[1,1]]
        myHashMap.Put(2, 2); // The map is now [[1,1], [2,2]]
        Console.WriteLine(myHashMap.Get(1));    // return 1, The map is now [[1,1], [2,2]]
        Console.WriteLine(myHashMap.Get(3));    // return -1 (i.e., not found), The map is now [[1,1], [2,2]]
        myHashMap.Put(2, 1); // The map is now [[1,1], [2,1]] (i.e., update the existing value)
        Console.WriteLine(myHashMap.Get(2));    // return 1, The map is now [[1,1], [2,1]]
        myHashMap.Remove(2); // remove the mapping for 2, The map is now [[1,1]]
        Console.WriteLine(myHashMap.Get(2));    // return -1 (i.e., not found), The map is now [[1,1]]
    }
}

public class MyHashMap
{
    private readonly int[] _hashMap;

    public MyHashMap()
    {
        _hashMap = new int[(int)Math.Pow(10, 6) + 1];
        Array.Fill(_hashMap, -1);
    }

    public void Put(int key, int value)
    {
        _hashMap[key] = value;
    }

    public int Get(int key)
    {
        return _hashMap[key];
    }

    public void Remove(int key)
    {
        _hashMap[key] = -1;
    }
}
