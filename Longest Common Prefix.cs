using System.Text;

public class Program
{
    public static void Main()
    {
        Solution solution = new Solution();
        Console.WriteLine(solution.LongestCommonPrefix(new string[] { "flower", "flow", "flight" })); // "fl"
        Console.WriteLine(solution.LongestCommonPrefix(new string[] { "dog", "racecar", "car" })); // ""
        Console.WriteLine(solution.LongestCommonPrefix(new string[] { "a" })); // "a"
        Console.WriteLine(solution.LongestCommonPrefix(new string[] { "ab", "a" })); // "a"
        Console.WriteLine(solution.LongestCommonPrefix(new string[] { "", "b" })); // ""
        Console.WriteLine(solution.LongestCommonPrefix(new string[] { "reflower", "flow", "flight" })); // ""
        Console.WriteLine(solution.LongestCommonPrefix(new string[] { "flower", "flower", "flower", "flower" })); // "flower"
        Console.WriteLine(solution.LongestCommonPrefix(new string[] { "aa", "aa" })); // "aa"
        Console.WriteLine(solution.LongestCommonPrefix(new string[] { "geeksforgeeks", "geeks", "geek", "geezer" })); // "gee"
    }
}

public class Solution
{
    public class TrieNode
    {
        public bool IsEndOfString = false;
        public TrieNode[]? Children;
        public int Visits = 0;
    }
    
    public class Trie
    {
        private const int AlphabetSize = 26;
        private TrieNode _root;
        private int _max = 0;
    
        public Trie()
        {
            _root = new TrieNode()
            {
                Visits = -1,
                Children = new TrieNode[AlphabetSize]
            };
        }
    
        public void Insert(string key)
        {
            TrieNode currentNode = _root;

            foreach (char c in key)
            {
                int currentIndex = c - 'a';
    
                if (currentNode.Children[currentIndex] is null)
                    currentNode.Children[currentIndex] = new TrieNode()
                    {
                        Children = new TrieNode[AlphabetSize]
                    };

                currentNode = currentNode.Children[currentIndex];

                currentNode.Visits++;
    
                if (currentNode.Visits > _max)
                    _max = currentNode.Visits;
            }
    
            currentNode.IsEndOfString = true;
        }
    
        public List<string> FindAllPrefixes(string[] strs)
        {
            StringBuilder prefixBuilder = new StringBuilder();
            List<string> listOfPrefixes = new List<string>();
        
            foreach (string key in strs)
            {
                TrieNode currentNode = _root;
        
                foreach (char c in key)
                {
                    var currentIndex = c - 'a';
                    if (currentNode.Children[currentIndex] is not null && currentNode.Children[currentIndex].Visits == _max)
                    {
                        prefixBuilder.Append((char) (currentIndex + 'a'));
                        currentNode = currentNode.Children[currentIndex];
                    }
                    else
                        break;
                }
                listOfPrefixes.Add(prefixBuilder.ToString());
                prefixBuilder.Clear();
            }

            return listOfPrefixes;
        }
    }

    public string LongestCommonPrefix(string[] strs)
    {
        if (strs.Length == 1)
            return strs[0];

        Trie trie = new Trie();

        foreach (string str in strs)
            trie.Insert(str);
        
        List<string> listOfPrefixes = trie.FindAllPrefixes(strs);
        listOfPrefixes.Sort((a, b) => b.Length.CompareTo(a.Length));
        string longestPrefix = listOfPrefixes[0];
        
        foreach (string str in strs)
        {
            if (!str.StartsWith(longestPrefix))
                return string.Empty;
        }

        return longestPrefix;
    }
}
