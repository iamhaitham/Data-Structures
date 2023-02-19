public class Program
{
    public static void Main()
    {
        Solution solution = new Solution();
        foreach (int digit in solution.PlusOne(new int[] { 1, 2, 3 })) // [1, 2, 4]
            Console.Write(digit);
        Console.Write("\n");
        
        foreach (int digit in solution.PlusOne(new int[] { 4, 3, 2, 1 })) // [4, 3, 2, 2]
            Console.Write(digit);
        Console.Write("\n");
        
        foreach (int digit in solution.PlusOne(new int[] { 9 })) // [1, 0]
            Console.Write(digit);
        Console.Write("\n");

        foreach (int digit in solution.PlusOne(new int[] { 1, 1, 9 })) // [1, 2, 0]
            Console.Write(digit);
        Console.Write("\n");
        
        foreach (int digit in solution.PlusOne(new int[] { 9, 8, 9 })) // [9, 9, 0]
            Console.Write(digit);
        Console.Write("\n");
    }
}

public class Solution
{
    public int[] PlusOne(int[] digits) 
    {
        if (digits.Length == 1)
        {
            if (digits[0] == 9)
                return new int[] {1, 0};
            
            return new int[] {digits[0] + 1};
        }

        List<int> result = new List<int>();

        if (digits[^1] != 9)
        {
            for (int i = 0; i <= digits.Length - 2; i++)
                result.Add(digits[i]);

            result.Add(digits[^1] + 1);
            
            return result.ToArray();
        }

        bool isAddOne = false;
        for (int i = digits.Length - 1; ; i--)
        {
            if (i < 0)
            {
                if (isAddOne)
                    result.Add((1));

                break;
            }

            if (i == digits.Length - 1)
            {
                result.Add(0);
                isAddOne = true;
                continue;
            }

            if (digits[i] == 9)
            {
                if (!isAddOne)
                {
                    result.Add(9);
                    continue;
                }

                result.Add(0);
            }
            else
            {
                if (isAddOne)
                {
                    result.Add(digits[i] + 1);
                    isAddOne = false;
                }
                else
                    result.Add(digits[i]);
            }
        }

        result.Reverse();
        return result.ToArray();
    }
}