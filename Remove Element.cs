using System;

public class Program
{
    public static void Main()
	{
		Console.WriteLine(RemoveElement(new int[] { 3, 2, 2, 3 }, 3));
        Console.WriteLine(RemoveElement(new int[] { 0, 1, 2, 2, 3, 0, 4, 2 }, 2));		
	}

	public static int RemoveElement(int[] nums, int val)
    {
		int firstNonTarget = 0;
		int counter = 0;
		for (int i = nums.Length - 1; i > -1; i--)
		{
			if (nums[i] != val)
			{
				firstNonTarget = i;
				break;
			}
			counter++;
		}

		for (int j = firstNonTarget, k = firstNonTarget - 1; k > -1;)
		{
			if (nums[k] != val)
			{
				k--;
			}
			else
			{
				counter++;
				nums[k] = nums[j];
				nums[j] = val;
				j--;
				k--;
			}
		}

		return nums.Length - counter;
	}
}