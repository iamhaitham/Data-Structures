public class Program
{
    public static void Main()
    {
        Solution s = new Solution();
        Console.WriteLine(s.LengthOfLongestSubstring("abcabcbb")); // 3
        Console.WriteLine(s.LengthOfLongestSubstring("bbbbb")); // 1
        Console.WriteLine(s.LengthOfLongestSubstring("pwwkew")); // 3
    }
}

public class Solution
{
    public int LengthOfLongestSubstring(string s)
    {
        int max = 0;
        int start = 0;
        int current = start;
        int _maximumSubStringLength = 0;
        HashSet<char> uniqueCharacters = new HashSet<char>();

        while (start < s.Length && current < s.Length)
        {
            if (uniqueCharacters.Add(s[current]))
            {
                max++;
                current++;
            }
            else
            {
                if (_maximumSubStringLength < max)
                    _maximumSubStringLength = max;
                max = 0;
                start++;
                current = start;
                uniqueCharacters.Clear();
            }
        }

        if (_maximumSubStringLength < max)
            _maximumSubStringLength = max;

        return _maximumSubStringLength;
    }
}
