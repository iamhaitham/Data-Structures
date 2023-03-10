public class Program
{
    public static void Main()
    {
        Trie trie = new Trie();
        trie.Insert("apple");
        Console.WriteLine(trie.Search("apple"));   // true
        Console.WriteLine(trie.Search("app"));     // false
        Console.WriteLine(trie.StartsWith("app")); // true
        trie.Insert("app");
        Console.WriteLine(trie.Search("app"));     // true
    }
}

/*
 * Your Trie object will be instantiated and called as such:
 * Trie obj = new Trie();
 * obj.Insert(word);
 * bool param_2 = obj.Search(word);
 * bool param_3 = obj.StartsWith(prefix);
 */

public class TrieNode
{
    public bool IsEndOfWord = false;
    public TrieNode[]? Children;
}

public class Trie
{
    private const int AlphabetSize = 26;
    private readonly TrieNode _root;

    public Trie()
    {
        _root = new TrieNode()
        {
            Children = new TrieNode[AlphabetSize]
        };
    }
    
    public void Insert(string word)
    {
        TrieNode currentNode = _root;

        foreach (char currentCharacter in word)
        {
            int currentCharacterIndex = currentCharacter - 'a';

            if (currentNode.Children[currentCharacterIndex] is null)
            {
                currentNode.Children[currentCharacterIndex] = new TrieNode()
                {
                    Children = new TrieNode[AlphabetSize]
                };
            }

            currentNode = currentNode.Children[currentCharacterIndex];
        }

        currentNode.IsEndOfWord = true;
    }
    
    public bool Search(string word)
    {
        TrieNode currentNode = _root;

        for (int i = 0; i < word.Length; i++)
        {
            int currentCharacterIndex = word[i] - 'a';

            if (currentNode.Children[currentCharacterIndex] is null)
                return false;

            if (i == word.Length - 1)
                break;
                
            currentNode = currentNode.Children[currentCharacterIndex];
        }

        return currentNode.Children[word[^1] - 'a'].IsEndOfWord;
    }
    
    public bool StartsWith(string prefix)
    {
        TrieNode currentNode = _root;

        foreach (char character in prefix)
        {
            int currentCharacterIndex = character - 'a';

            if (currentNode.Children[currentCharacterIndex] is null)
                return false;

            currentNode = currentNode.Children[currentCharacterIndex];
        }

        return true;
    }
}