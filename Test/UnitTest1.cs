using CrackingCoding.LeetCodes;

namespace Test;

public class UnitTest1
{
    [Theory]
    [InlineData("the sky is blue", "blue is sky the")]
    [InlineData("  hello world  ", "world hello")]
    [InlineData("a good   example", "example good a")]
    public void IsReverseWordsCorrect(string value, string expected)
    {
        LeetCode151 leetCode = new LeetCode151();
        var result = leetCode.ReverseWords(value);

        Assert.Equal(expected, result);
    }
}