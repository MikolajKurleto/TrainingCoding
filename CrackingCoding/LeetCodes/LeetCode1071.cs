namespace CrackingCoding.LeetCodes;

public class LeetCode1071 : IRunable
{
    public void Run()
    {
        var word1 = "TAUXX";
        var word2 = "TAUXXTAUXXTAUXXTAUXXTAUXXTAUXXTAUXXTAUXXTAUXX";
        Console.WriteLine(GcdOfStrings(word1, word2));
    }

    private string GcdOfStrings(string str1, string str2) 
        {
            if (str1 + str2 != str2 + str1)
            {
                return ""; // No common divisor found
            }

            // Calculate the greatest common divisor (GCD) of lengths
            int gcdLength = Gcd(str1.Length, str2.Length);

            // Extract the common divisor as a substring
            string divisor = str1.Substring(0, gcdLength);

            return divisor;
        }

    private int Gcd(int a, int b)
    {
        while (b != 0)
        {
            int temp = b;
            b = a % b;
            a = temp;
        }
        return a;
    }
}
