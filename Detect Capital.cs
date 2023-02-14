using System;
using System.Text.RegularExpressions;

public class Program
{
	public static void Main()
	{
		Solution solution = new Solution();
		Console.WriteLine(solution.DetectCapitalUse("USA")); // true
		Console.WriteLine(solution.DetectCapitalUse("leetcode")); // true
		Console.WriteLine(solution.DetectCapitalUse("Google")); // true
		Console.WriteLine(solution.DetectCapitalUse("FlaG")); // false
	}
}

public class Solution
{
	public bool DetectCapitalUse(string word)
	{
		if (Regex.IsMatch(word, @"^[A-Z]+$") || Regex.IsMatch(word, @"^[a-z]+$") || Regex.IsMatch(word, @"^[A-Z][a-z]+$"))
			return true;
		return false;
	}
}