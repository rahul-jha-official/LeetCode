// LINK - https://leetcode.com/problems/four-divisors/

public class Solution 
{
    public int SumFourDivisors(int[] nums) 
    {
        var result = 0;
        foreach (var num in nums)
        {
            var counter = 0;
            var sum = 0;
            for (var d = 1; d * d <= num; d++)
            {
                if (num % d == 0)
                {
                    if (d * d == num)
                    {
                        counter++;
                        sum += d; 
                    }
                    else
                    {
                        counter += 2;
                        sum += (d + num / d);
                    }

                    if (counter > 4)
                    {
                        break;
                    }
                } 
            }

            if (counter == 4)
            {
                result += sum;
            }
        }
        return result;
    }
}
