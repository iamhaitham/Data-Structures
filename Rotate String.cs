public class Program
{
    public static void Main()
    {
        Solution solution = new Solution();
        Console.WriteLine(solution.RotateString("abcde", "cdeab")); // true
        Console.WriteLine(solution.RotateString("ceeab", "ceeab")); // true
        Console.WriteLine(solution.RotateString("abcde", "abced")); // false
        Console.WriteLine(solution.RotateString("abcde", "bcdea")); // true
        Console.WriteLine(solution.RotateString("gcmbf", "fgcmb")); // true
    }
}

public class Solution 
{
    public bool RotateString(string s, string goal) 
    {
         if (goal.Length != s.Length)
            return false;

        var possibilities = new HashSet<string>();

        for (int i = 0; i <= s.Length - 1; i++)
        {
            possibilities.Add(s.Substring(i) + s.Substring(0, i));
        }
        
        return possibilities.Contains(goal);
    }
}