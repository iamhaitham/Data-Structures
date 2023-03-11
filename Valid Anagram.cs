public class Program
{
    public static void Main()
    {
        Solution solution = new Solution();
        Console.WriteLine(solution.IsAnagram("anagram", "nagaram")); // true
        Console.WriteLine(solution.IsAnagram("rat", "car")); // false
        Console.WriteLine(solution.IsAnagram("a", "ab")); // false
        Console.WriteLine(solution.IsAnagram("aacc", "ccac")); // false
    }
}

public class Solution
{
    public bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length)
            return false;

        return SortString(s).Equals(SortString(t));
    }

    private string SortString(string input)
    {
        char[] characters = input.ToArray();
        Array.Sort(characters);
        return new string(characters);
    }
}
