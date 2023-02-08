using System;
using System.Text.RegularExpressions;
					
public class Program
{
	public static void Main()
	{
		Solution ss = new Solution();
		Console.WriteLine(ss.IsPalindrome("A man, a plan, a canal: Panama")); // true
		Console.WriteLine(ss.IsPalindrome("race a car")); // false
		Console.WriteLine(ss.IsPalindrome(" ")); // true
		Console.WriteLine(ss.IsPalindrome("0P")); // false
		Console.WriteLine(ss.IsPalindrome("ab_a")); // true
	}
}

public class Solution {
    public bool IsPalindrome(string s) {
        string updatedString = Regex.Replace(s, @"[^a-zA-Z0-9]", "").ToLower();

		for (int i = 0; i < updatedString.Length / 2; i++)
		{
			if (updatedString[i] != updatedString[updatedString.Length - 1 - i])
				return false;
		}
		return true;
    }
}