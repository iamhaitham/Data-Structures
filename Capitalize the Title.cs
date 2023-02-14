using System;
using System.Text;
using System.Text.RegularExpressions;

public class Program
{
	public static void Main()
	{
		Solution solution = new Solution();
		Console.WriteLine(solution.CapitalizeTitle("capiTalIze tHe titLe")); // "Capitalize The Title"
		Console.WriteLine(solution.CapitalizeTitle("First leTTeR of EACH Word")); // "First Letter of Each Word"
		Console.WriteLine(solution.CapitalizeTitle("i lOve leetcode")); // "i Love Leetcode"
	}
}

public class Solution
{
	public string CapitalizeTitle(string title)
	{
		var matches = Regex.Matches(title, @"\s*([a-zA-Z]+)\s*");
		var sentence = new StringBuilder();

		foreach(Match match in matches)
        {
			var word = match.Groups[1].Value;
			if (word.Length >= 3)
				sentence.Append(word[0].ToString().ToUpper() + word.Substring(1).ToLower());
			else
				sentence.Append(word.ToLower());

			sentence.Append(" ");
        }

		return sentence.ToString().Trim();
	}
}