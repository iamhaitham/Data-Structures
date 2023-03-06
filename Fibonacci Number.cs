public class Program
{
    public static void Main()
    {
        Solution solution = new Solution();
        Console.WriteLine(solution.Fib(2)); // 1
        Console.WriteLine(solution.Fib(3)); // 2
        Console.WriteLine(solution.Fib(4)); // 3
        Console.WriteLine(solution.Fib(7)); // 13
    }
}

public class Solution {
    public int Fib(int n)
    {
        List<int> fibs = new List<int>() { 0, 1 };

        for (int i = 2; i <= n; i++)
            fibs.Add(fibs[i - 2] + fibs[i - 1]);

        return fibs[n];
    }
}