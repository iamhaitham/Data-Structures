public class Program
{
    public static void Main()
    {
        Solution solution = new Solution();
        Console.WriteLine(solution.ContainsDuplicate(new int[] { 1, 2, 3, 1 })); // true
        Console.WriteLine(solution.ContainsDuplicate(new int[] { 1, 2, 3, 4 })); // false
        Console.WriteLine(solution.ContainsDuplicate(new int[] { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 })); // true
    }
}

public class Solution {
    public bool ContainsDuplicate(int[] nums)
    {
        return new HashSet<int>(nums).Count != nums.Length;
    }
}