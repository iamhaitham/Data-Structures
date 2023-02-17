using System.Collections;

public class Program
{
    public static void Main()
    {
        Solution solution = new Solution();
        Console.WriteLine(solution.ArrayStringsAreEqual(new [] {"ab", "c"}, new [] {"a", "bc"})); // true
        Console.WriteLine(solution.ArrayStringsAreEqual(new [] {"a", "cb"}, new [] {"ab", "c"})); // false
        Console.WriteLine(solution.ArrayStringsAreEqual(new [] {"abc", "d", "defg"}, new [] {"abcddefg"})); // true
    }
}

public class Solution
{
    public bool ArrayStringsAreEqual(string[] word1, string[] word2)
    {
        Stack stack = new Stack();

        for (int arrayPointer = 0, currentWordLettersPointer = 0; ;)
        {
            var currentWord = word1[arrayPointer];

            if (currentWordLettersPointer >= currentWord.Length)
            {
                if (++arrayPointer >= word1.Length)
                    break;

                currentWordLettersPointer = 0;
                continue;
            }

            stack.Push(currentWord[currentWordLettersPointer]);
            currentWordLettersPointer++;
        }

        for (int arrayPointer = word2.Length - 1, currentWordLettersPointer = word2[^1].Length - 1; ;)
        {
            var currentWord = word2[arrayPointer];

            if (currentWordLettersPointer < 0)
            {
                if (--arrayPointer < 0)
                    break;

                currentWordLettersPointer = word2[arrayPointer].Length - 1;
                continue;
            }

            if (stack.Count != 0 && (char) stack.Peek()! == currentWord[currentWordLettersPointer])
            {
                stack.Pop();
                currentWordLettersPointer--;
            }
            else
                return false;
        }

        return true;
    }
}