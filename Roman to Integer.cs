public class Program
{
    public static void Main()
    {
        Solution solution = new Solution();
        Console.WriteLine(solution.RomanToInt("III")); // 3
        Console.WriteLine(solution.RomanToInt("LVIII")); // 58
        Console.WriteLine(solution.RomanToInt("MCMXCIV")); // 1994
    }
}

public class Solution
{
    public int RomanToInt(string s)
    {
        Dictionary<string, int> dictionary = new Dictionary<string, int>()
        {
            { "I", 1 },
            { "IV", 4 },
            { "V", 5 },
            { "IX", 9 },
            { "X", 10 },
            { "XL", 40 },
            { "L", 50 },
            { "XC", 90 },
            { "C", 100 },
            { "CD", 400 },
            { "D", 500 },
            { "CM", 900 },
            { "M", 1000 }
        };
        int result = 0;
        string remaining = string.Empty;

        for (int i = 0; ;)
        {
            if (i >= s.Length)
                break;

            if (i + 1 >= s.Length)
            {
                result += dictionary[s[i].ToString()];
                break;
            }

            if (s[i] == 'I' && s[i + 1] == 'X')
            {
                result += dictionary["IX"];
                i += 2;
                continue;
            }
            else if (s[i] == 'I' && s[i + 1] == 'V')
            {
                result += dictionary["IV"];
                i += 2;
                continue;
            }

            if (s[i] == 'X' && s[i + 1] == 'L')
            {
                result += dictionary["XL"];
                i += 2;
                continue;
            }
            else if (s[i] == 'X' && s[i + 1] == 'C')
            {
                result += dictionary["XC"];
                i += 2;
                continue;
            }

            if (s[i] == 'C' && s[i + 1] == 'D')
            {
                result += dictionary["CD"];
                i += 2;
                continue;
            }
            else if (s[i] == 'C' && s[i + 1] == 'M')
            {
                result += dictionary["CM"];
                i += 2;
                continue;
            }

            if (s[i] == 'I')
                result += dictionary["I"];
            else if (s[i] == 'X')
                result += dictionary["X"];
            else if (s[i] == 'V')
                result += dictionary["V"];
            else if (s[i] == 'L')
                result += dictionary["L"];
            else if (s[i] == 'C')
                result += dictionary["C"];
            else if (s[i] == 'D')
                result += dictionary["D"];
            else if (s[i] == 'M')
                result += dictionary["M"];

            i++;
        }

        return result;
    }
}
