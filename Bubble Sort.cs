using System;

public class Program
{
	public static void Main()
	{
        foreach (var x in BubbleSort(new int[] { 10, 9, 8, 7, 6, 5, 4, 3, 2, 1 }))
        {
            Console.Write($"-({ x })-");
        }
        Console.WriteLine("\n");

        foreach (var x in BubbleSort(new int[] { 10, 20, 30, 35, 45, 48 }))
        {
            Console.Write($"-({ x })-");
        }
        Console.WriteLine("\n");

        foreach (var x in BubbleSort(new int[] { 3, 7, -1, -2, 0, 5 }))
        {
            Console.Write($"-({ x })-");
        }
        Console.WriteLine("\n");

        foreach (var x in BubbleSort(new int[] { 9, 5, 1, 4, 3 }))
        {
            Console.Write($"-({ x })-");
        }
    }

	public static int[] BubbleSort(int[] nums)
    {
		for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] > nums[j])
                {
                    var temp = nums[j];
                    nums[j] = nums[i];
                    nums[i] = temp;
                }
            }
        }

		return nums;
    }
}