namespace CrackingCoding.LeetCodes;

public class LeetCode151 : IRunable
{
    public void Run()
    {
        var s = "a good   example";
        Console.WriteLine(ReverseWords(s));
        Console.WriteLine(ReverseWordsOtherSolution(s));
    }

    public string ReverseWords(string s) 
    {
        var cleanString = s.Split(" ", StringSplitOptions.RemoveEmptyEntries | StringSplitOptions.TrimEntries);
        var reversed = cleanString.Reverse();
        return string.Join(" ", reversed);
    }

    private string ReverseWordsOtherSolution(string s) 
    {
        var cleanString = s.Trim();
        var wordsSplit = cleanString.Split(" ");
        var reversed = wordsSplit.Where(w => !string.IsNullOrEmpty(w)).Reverse();
        return string.Join(" ", reversed);
    }
}

