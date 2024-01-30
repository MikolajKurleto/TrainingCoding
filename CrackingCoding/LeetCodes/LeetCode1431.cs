namespace CrackingCoding.LeetCodes;

public class LeetCode1431 : IRunable
{
    public void Run()
    {
        var candies = new int[] {2,3,5,1,3};
        var extraCandies = 3;
        var output = KidsWithCandies(candies, extraCandies);

        Console.WriteLine(string.Join(",", output));
    }

    private IList<bool> KidsWithCandies(int[] candies, int extraCandies) 
    {
        var output = new List<bool>(candies.Length);
        var maxValue = candies.Max();
        for (int i = 0; i < candies.Length; i++)
        {
            output.Add(candies[i] + extraCandies >= maxValue);
        }

        return output;
    }
}
