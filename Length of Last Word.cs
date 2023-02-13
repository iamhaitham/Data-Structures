using System;
using System.Text.RegularExpressions;

public class Program
{
	public static void Main()
	{
		Solution solution = new Solution();
		Console.WriteLine(solution.LengthOfLastWord("Hello World")); // 5
		Console.WriteLine(solution.LengthOfLastWord("   fly me   to   the moon  ")); // 4
		Console.WriteLine(solution.LengthOfLastWord("luffy is still joyboy")); // 6
	}
}

public class Solution
{
	public int LengthOfLastWord(string s)
	{
		MatchCollection matches = Regex.Matches(s, @"[a-zA-Z]+");

		return matches[matches.Count - 1].Value.Length;
	}
}