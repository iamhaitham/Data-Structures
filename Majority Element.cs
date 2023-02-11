using System;

public class Program
{
	public static void Main()
	{
		Console.WriteLine(MajorityElement(new int[] { 3, 2, 3 }));
		Console.WriteLine(MajorityElement(new int[] { 2, 2, 1, 1, 1, 2, 2 }));
	}

	public static int MajorityElement(int[] nums)
    {
		Array.Sort(nums);
		int current = nums[0], currentFrequency = 1, major = nums[0], majorFrequency = 1;
		
		for (int i = 1; i < nums.Length;)
        {
			if (nums[i] == current)
            {
				currentFrequency++;
				i++;
            }
            else
            {
				if (currentFrequency > majorFrequency)
                {
					major = current;
					majorFrequency = currentFrequency;
                }

				current = nums[i];
				currentFrequency = 1;
				i++;
            }
        }

		if (currentFrequency > majorFrequency)
        {
			major = current;
        }

		return major;
    }
}