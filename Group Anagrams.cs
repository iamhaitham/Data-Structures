using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class Program
{
    public static void Main()
    {
        Solution solution = new Solution();
        solution.GroupAnagrams(new string[] { "eat","tea","tan","ate","nat","bat" }); // [["bat"],["nat","tan"],["ate","eat","tea"]]
        solution.GroupAnagrams(new string[] { "" }); // [[""]]
        solution.GroupAnagrams(new string[] { "a" }); // [["a"]]
    }
}

public class Solution
{
    public IList<IList<string>> GroupAnagrams(string[] strs)
    {
        IList<IList<string>> result = new List<IList<string>>();
        Dictionary<string, List<string>> dictionary = new Dictionary<string, List<string>>();

        for (int i = 0; i < strs.Length; i++)
        {
            string sortedStr = string.Concat(strs[i].OrderBy(c => c));

            if (!dictionary.ContainsKey(sortedStr))
                dictionary.TryAdd(sortedStr, new List<string>() { strs[i] });
            else
                dictionary[sortedStr].Add(strs[i]);
        }

        foreach (var value in dictionary.Values)
        {
            result.Add(value);
        }

        return result;
    }
}