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
        if (n == 0 || n == 1)
            return n;

        return Fib(n - 2) + Fib(n - 1);
    }
}