public class Program
{
    public static void Main()
    {
        Solution solution = new Solution();
        Console.WriteLine(solution.MinimumOperations(new int[] { 1, 5, 0, 3, 5})); // 3
        Console.WriteLine(solution.MinimumOperations(new int[] { 0 })); // 0
        Console.WriteLine(solution.MinimumOperations(new int[] { 2, 0, 9, 7, 5, 6 })); // 5
        Console.WriteLine(solution.MinimumOperations(new int[] { 0, 0, 0, 0 })); // 0
    }
}

public class Solution {
    public int MinimumOperations(int[] nums)
    {
        bool CheckIfAllNumsAreZero(int[] numsArr)
        {
            foreach (int num in numsArr)
                if (num != 0)
                    return false;

            return true;
        }

        // Find minimum number that is not a zero
        Array.Sort(nums);
        int minNumber = nums[^1];
        foreach (int num in nums)
        {
            if (num != 0 && num < minNumber)
            {
                minNumber = num;
                break;
            }
        }
        
        // In case nums is something like [0, 0, 0, 0] or [0] -- Remember that the array is sorted from the previous step
        if (nums[^1] == 0)
            return 0;

        // In case nums is something like [5]
        if (nums.Length == 1)
            return 1;

        // Subtract the minimum number from all elements
        int numberOfOperations = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != 0)
                nums[i] -= minNumber;
        }
        numberOfOperations++;

        // If nums still has elements which are not zero, do recursion
        if (CheckIfAllNumsAreZero(nums))
            return numberOfOperations;
        
        return numberOfOperations + MinimumOperations(nums);
    }
}