namespace CrackingCoding.LeetCodes;

public class LeetCode1768 : IRunable
{
    public void Run()
    {
        var word1 = "abcd";
        var word2 = "pq";
        Console.WriteLine(MergeAlternately(word1, word2));
    }

    private string MergeAlternately(string word1, string word2) 
    {
        string output = MergeStringsRecursive(word1, word2);

        return output;
    }

    private string MergeStringsRecursive(string word1, string word2)
    {
        if (string.IsNullOrEmpty(word1))
        {
            return word2;
        }
        if (string.IsNullOrEmpty(word2))
        {
            return word1;
        }

        return word1[0] + MergeStringsRecursive(word2, word1.Substring(1));
    }
}
