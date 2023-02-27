public class Program
{
    public static void Main()
    {
        Solution solution = new Solution();
        Console.WriteLine(solution.ContainsNearbyDuplicate(new int[] { 1, 2, 3, 1 }, 3)); // true
        Console.WriteLine(solution.ContainsNearbyDuplicate(new int[] { 1, 0, 1, 1 }, 1)); // true
        Console.WriteLine(solution.ContainsNearbyDuplicate(new int[] { 1, 2, 3, 1, 2, 3 }, 2)); // false
    }
}

public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k)
    {
        Dictionary<int, int> dictionary = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (!dictionary.ContainsKey(nums[i]))
                dictionary.Add(nums[i], i);
            else
            {
                if (Math.Abs(i - dictionary[nums[i]]) <= k)
                    return true;

                dictionary[nums[i]] = i;
            }
        }

        return false;
    }
}