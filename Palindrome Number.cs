using System;

public class Program
{
	public static void Main()
	{
		Solution solution = new Solution();
		Console.WriteLine(solution.IsPalindrome(121)); // true
		Console.WriteLine(solution.IsPalindrome(-121)); // false
		Console.WriteLine(solution.IsPalindrome(10)); // false
	}
}

public class Solution
{
	public bool IsPalindrome(int x)
	{
		if (x < 0)
			return false;

		var numberAsString = x.ToString();
		var i = 0;
		var j = numberAsString.Length - 1;

		for(; ; )
        {
			if (j <= i)
				break;

			if (numberAsString[i] == numberAsString[j])
			{
				i++;
				j--;
			}
			else
				return false;
        }

		return true;
	}
}