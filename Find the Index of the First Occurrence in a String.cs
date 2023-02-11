using System;

public class Program
{
	public static void Main()
	{
		Console.WriteLine(StrStr("sadbutsad", "sad"));
		Console.WriteLine(StrStr("leetcode", "leeto"));
		Console.WriteLine(StrStr("cbcaaa", "aaa"));
		Console.WriteLine(StrStr("mississippi", "issi"));
	}

	public static int StrStr(string haystack, string needle)
	{
		for (int h = 0; ;)
		{
			if (haystack.Length - h < needle.Length)
				return -1;

			if (haystack.Substring(h, needle.Length) == needle)
				return h;
			else
				h++;
        }
	}
}