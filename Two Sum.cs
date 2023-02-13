using System;

public class Program
{
	public static void Main()
	{
		Solution solution = new Solution();
		foreach(var number in solution.TwoSum(new int[] { 2, 7, 11, 15 }, 9))
        {
			Console.Write($"-{number}-"); // [0,1]
		}
		Console.WriteLine("\n");

		foreach (var number in solution.TwoSum(new int[] { 3, 2, 4 }, 6))
		{
			Console.Write($"-{number}-"); // [1,2]
		}
		Console.WriteLine("\n");

		foreach (var number in solution.TwoSum(new int[] { 3, 3 }, 6))
		{
			Console.Write($"-{number}-"); // [0,1]
		}
	}
}

public class Solution
{
	public int[] TwoSum(int[] nums, int target)
	{
		var dictionary = new Dictionary<int, int>();

		for (int currentIndex = 0; currentIndex < nums.Length; currentIndex++)
        {
			var currentNumber = nums[currentIndex];

			if (!dictionary.ContainsKey(nums[currentIndex]))
				dictionary.Add(currentNumber, currentIndex);

			if (dictionary.ContainsKey(target - currentNumber) && currentIndex != dictionary[target - currentNumber])
				return new int[2] { dictionary[target - currentNumber], currentIndex };
		}

		return new int[2];
	}
}