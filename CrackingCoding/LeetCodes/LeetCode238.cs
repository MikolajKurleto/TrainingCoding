namespace CrackingCoding.LeetCodes;

public class LeetCode238 : IRunable
{
    public void Run()
    {
        var nums = new int[]{1,2,3,4};
        Console.WriteLine(string.Join(',', ProductExceptSelf(nums)));
        Console.WriteLine(string.Join(',', ProductExceptSelfLongerVersion(nums)));
    }

    private int[] ProductExceptSelf(int[] nums) 
    {
        int[] answer = new int[nums.Length];

        int productFromLeftSide = 1;

        for(int i = 0; i < nums.Length; i++)
        {
            answer[i] = productFromLeftSide;
            productFromLeftSide *= nums[i];
        }

        int productFromRightSide = 1;

        for(int i = nums.Length - 1; i >= 0; i--)
        {
            answer[i] *= productFromRightSide;
            productFromRightSide *= nums[i];
        }

        return answer;
    }

    private int[] ProductExceptSelfLongerVersion(int[] nums)
    {
        var answer = new int[nums.Length];

        for (int i = 0; i < nums.Length; i++)
        {
            answer[i] = 1;
            for (int j = 0; j < nums.Length; j++)
            {
                if (i == j) continue; 
                answer[i] *= nums[j];
            }          
        }

        return answer;
    }
}
