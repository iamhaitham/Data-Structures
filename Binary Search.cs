public class Program
{
    public static void Main()
    {
        Solution solution = new Solution();
        Console.WriteLine(solution.Search(new int[] { -1, 0, 3, 5, 9, 12 }, 9)); // 4
        Console.WriteLine(solution.Search(new int[] { -1, 0, 3, 5, 9, 12 }, 2)); // -1
        Console.WriteLine(solution.Search(new int[] { 5 }, 5)); // 0
    }
}

public class Solution
{
    public int Search(int[] nums, int target)
    {
        int minIndex = 0;
        int midIndex = (nums.Length - 1) / 2;
        int maxIndex = nums.Length - 1;

        if (nums.Length == 1)
            return nums[0] == target ? 0 : -1;

        while (minIndex < maxIndex)
        {
            if (nums[midIndex] == target)
                return midIndex;
            else if (nums[minIndex] == target)
                return minIndex;
            else if (nums[maxIndex] == target)
                return maxIndex;

            midIndex = minIndex + (maxIndex - minIndex) / 2;

            if (nums[midIndex] < target)
                minIndex = midIndex + 1;
            else if (nums[midIndex] > target)
                maxIndex = midIndex - 1;
        }

        return -1;
    }
}
