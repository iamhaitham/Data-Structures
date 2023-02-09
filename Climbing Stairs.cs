using System;
using System.Collections.Generic;

public class Program
{
	public static void Main()
	{
		Solution solution = new Solution();
		Console.WriteLine(solution.ClimbStairs(0)); // 0
		Console.WriteLine(solution.ClimbStairs(2)); // 2
        Console.WriteLine(solution.ClimbStairs(3)); // 3
        Console.WriteLine(solution.ClimbStairs(6)); // 13
    }
}

public class Solution
{
	public int ClimbStairs(int n)
	{
		if (n == 1 || n == 0)
			return n;

		List<int> fib = new List<int>() { 1, 2 };

		for(int i = fib.Count - 1; i < n - 1; i++)
        {
			fib.Add(fib[i] + fib[i-1]);
        }

		return fib[fib.Count - 1];
	}
}