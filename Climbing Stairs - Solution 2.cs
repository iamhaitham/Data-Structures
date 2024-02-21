public class Program
{
  public static void Main()
  {
    Solution solution = new Solution();

    Console.WriteLine(solution.ClimbStairs(3)); // 3
    Console.WriteLine(solution.ClimbStairs(4)); // 5
    Console.WriteLine(solution.ClimbStairs(5)); // 8
    Console.WriteLine(solution.ClimbStairs(45)); // 1836311903
  }
}

public class Solution
{
  private Dictionary<int, int> _memo = new Dictionary<int, int>();

  public int ClimbStairs(int n)
  {
      return CalculateFibonacci(n);
  }

  private int CalculateFibonacci(int n)
  {
    // Get memoized values (if exist)
    if (_memo.TryGetValue(n, out var memoizedValue))
    {
      return memoizedValue;
    }

    // Base case
    if (n <= 3)
      return n;

    // Recursion
    var fibonacci = CalculateFibonacci(n - 1) + CalculateFibonacci(n - 2);
    
    // Memoize new values
    if (!_memo.ContainsKey(n))
    {
      _memo.Add(n, fibonacci);;
    }

    return fibonacci;
  }
}