using System.Collections;

public class Program
{
    public static void Main()
    {
        Solution solution = new Solution();
        Console.WriteLine(solution.IsValid("()")); // true
        Console.WriteLine(solution.IsValid("()[]{}")); // true
        Console.WriteLine(solution.IsValid("(]")); // false
        Console.WriteLine(solution.IsValid(")")); // false
        Console.WriteLine(solution.IsValid("(){}}{")); // false
        Console.WriteLine(solution.IsValid("{")); // false
    }
}

public class Solution
{
    public bool IsValid(string s)
    {
        Stack stack = new Stack();

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] is '(' or '{' or '[')
            {
                stack.Push(s[i]);
                continue;
            }

            if (stack.Count == 0 && (s[i] is ')' or ']' or '}'))
                return false;

            if (s[i] == ')' && (char) stack.Peek() == '(' ||
                s[i] == ']' && (char) stack.Peek() == '[' ||
                s[i] == '}' && (char) stack.Peek() == '{')
                stack.Pop();
            else
                return false;
        }

        return stack.Count == 0;
    }
}