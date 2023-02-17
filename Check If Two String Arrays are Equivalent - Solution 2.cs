public class Program
{
    public static void Main()
    {
        Solution solution = new Solution();
        Console.WriteLine(solution.ArrayStringsAreEqual(new [] {"ab", "c"}, new [] {"a", "bc"})); // true
        Console.WriteLine(solution.ArrayStringsAreEqual(new [] {"a", "cb"}, new [] {"ab", "c"})); // false
        Console.WriteLine(solution.ArrayStringsAreEqual(new [] {"abc", "d", "defg"}, new [] {"abcddefg"})); // true
    }
}

public class Solution
{
    public bool ArrayStringsAreEqual(string[] word1, string[] word2)
    {
        return string.Join("", word1) == string.Join("", word2);
    }
}