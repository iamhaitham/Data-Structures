public class Program
{
  public static void Main()
  {
    Solution solution = new Solution();
    Console.WriteLine(solution.TheMaximumAchievableX(4, 1)); // 6
    Console.WriteLine(solution.TheMaximumAchievableX(3, 2)); // 7
  }
}

public class Solution
{
  public int TheMaximumAchievableX(int num, int t)
  {
    while (t > 0)
    {
      // X - 1 = num + 1, and we want to find X.
      num = num + 2;
      t--;
    }

    return num;
  }
}
