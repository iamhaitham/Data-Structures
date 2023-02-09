using System;

public class Program
{
	public static void Main()
	{
		Solution solution = new Solution();
        Console.WriteLine(solution.TitleToNumber("A")); // 1
		Console.WriteLine(solution.TitleToNumber("AB")); // 28
        Console.WriteLine(solution.TitleToNumber("ZY")); // 701
        Console.WriteLine(solution.TitleToNumber("AAA")); // 703
    }
}

public class Solution
{
    public int TitleToNumber(string columnTitle) 
    { 
        const int asciiBeforeA = 64;
        int result = 0;

        for (int i = columnTitle.Length - 1; i > -1; i--)
        {
            int currentCharacterAlphabeticalOrder = columnTitle[i] - asciiBeforeA;
            int cycles = (int)Math.Pow(26, columnTitle.Length - 1 - i);
            
            result += cycles * currentCharacterAlphabeticalOrder;
        }
        
        return result;
    }
}