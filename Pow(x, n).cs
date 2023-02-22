public class Program
{
    public static void Main()
    {
        Solution solution = new Solution();
        Console.WriteLine(solution.MyPow(2.00000, 10)); // 1024.00000
        Console.WriteLine(solution.MyPow(2.10000, 3)); // 9.26100
        Console.WriteLine(solution.MyPow(2.00000, -2)); // 0.25
        Console.WriteLine(solution.MyPow(2.00000, 0)); // 1
        Console.WriteLine(solution.MyPow(0.00001, 2147483647)); // 0
        Console.WriteLine(solution.MyPow(1, 2147483647)); // 1
        Console.WriteLine(solution.MyPow(2.00000, -2147483648)); // 0
        Console.WriteLine(solution.MyPow(-1.00000, 2147483647)); // -1
    }
}

public class Solution
{
    public double MyPow(double x, int n)
    {
        if (n == 0 || x == 1)
            return 1;

        if (x == -1)
        {
            if (n % 2 == 0)
                return 1;
            return -1;
        }

        double result = 1;
        double nn = n < 0 ? n * -1.0 : n;

        for (int i = 1; i <= nn; i++)
        {
            if (result == 0)
                return 0;

            if (n > 0)
                result *= x;
            else
                result *= 1 / x;
        }

        return result;
    }
}