public class Program
{
    public static void Main()
    {
        MinStack minStack1 = new MinStack();
        minStack1.Push(-2);
        minStack1.Push(0);
        minStack1.Push(-3);

        Console.WriteLine(minStack1.GetMin()); // -3
        minStack1.Pop();
        Console.WriteLine(minStack1.Top());    // 0
        Console.WriteLine(minStack1.GetMin()); // -2

        MinStack minStack2 = new MinStack();
        minStack2.Push(0);
        minStack2.Push(1);
        minStack2.Push(0);

        Console.WriteLine(minStack2.GetMin()); // 0
        minStack2.Pop();
        Console.WriteLine(minStack2.GetMin()); // 0
    }
}

public class MinStack
{
    private readonly LinkedList<int> _linkedList;
    private readonly LinkedList<int> _minimumValues;

    public MinStack()
    {
        _linkedList = new LinkedList<int>();
        _minimumValues = new LinkedList<int>();

        _minimumValues.AddLast(int.MaxValue);
    }

    public void Push(int val)
    {
        _linkedList.AddLast(val);

        if (val <= _minimumValues.Last.Value)
            _minimumValues.AddLast(val);
    }

    public void Pop()
    {
        if (Top() == _minimumValues.Last!.Value)
            _minimumValues.RemoveLast();

        _linkedList.RemoveLast();
    }

    public int Top()
    {
        return _linkedList.Last!.Value;
    }

    public int GetMin()
    {
        return _minimumValues.Last!.Value;
    }
}
