namespace CrackingCoding.LeetCodes;

public class LeetCode345 : IRunable
{
    readonly static string vovels = "aeiou";

    public void Run()
    {
        var s = "aA";
        Console.WriteLine(ReverseVowels(s));
    }

    private string ReverseVowels(string s) 
    {
        var reversedVowels = s.ToCharArray();
        var vovelsStack = new Stack<char>();
        for (int i = 0; i < s.Length; i++)
        {
            reversedVowels[i] = s[i];
            if(vovels.Contains(reversedVowels[i]) || vovels.ToUpper().Contains(reversedVowels[i]))
            {
                vovelsStack.Push(reversedVowels[i]);
            }
        }
            
        for (int i = 0; i < reversedVowels.Length; i++)
        {
            if(vovels.Contains(reversedVowels[i]) || vovels.ToUpper().Contains(reversedVowels[i]))
            {
                reversedVowels[i] = vovelsStack.Pop();
            }
        }

        return string.Join("", reversedVowels);
    }           
}
