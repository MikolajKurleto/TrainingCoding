namespace CrackingCoding.LeetCodes;

public class LeetCode605 : IRunable
{
    public void Run()
    {
        var flowers = new int[] {1, 0, 0, 0, 1};
        var n = 1;
        Console.WriteLine(CanPlaceFlowers(flowers, n));
    }

    private bool CanPlaceFlowers(int[] flowerbed, int n) 
    {
        bool output = true;
        var length = flowerbed.Length;
        
        for (int i = 0; i < length && n > 0; i++)
        {
            if(i == 0 && ((flowerbed[i] == 0 && i+1 == length) ||  (i + 1 < length 
                && flowerbed[i] == 0 && flowerbed[i+1] == 0)))
            {
                flowerbed[i] = 1;
                output = true;
                n--;
            } 
            else if (i > 0 && i + 1 < length && flowerbed[i-1] == 0 
                && flowerbed[i] == 0 && flowerbed[i+1] == 0) 
            {
                flowerbed[i] = 1;
                output = true;
                n--;        
            } 
            else if (i != 0 && i + 1 == length && flowerbed[i-1] == 0 && flowerbed[i] == 0) 
            {
                flowerbed[i] = 1;
                output = true;
                n--;
            }
            else
            {
                output = false;
            }
        }

        if(n > 0) return false;
        return output;
    }
}
