// LINK - https://leetcode.com/problems/max-dot-product-of-two-subsequences/

public class Solution 
{
    private int[][] memo;
    
    public int MaxDotProduct(int[] nums1, int[] nums2) 
    {
        var max = Math.Max(nums1.Length, nums2.Length);
        memo = new int[max][];

        for (var i = 0; i < max; i++)
        {
            memo[i] = new int[max];

            for (var j = 0; j < max; j++)
            {
                memo[i][j] = int.MinValue;
            }
        }   
        return Solve(0, 0, nums1, nums2);     
    }

    private int Solve(int i, int j, int[] nums1, int[] nums2)
    {
        if (i >= nums1.Length || j >= nums2.Length)
        {
            return  int.MinValue;
        }        

        if (memo[i][j] != int.MinValue)
        {
            return memo[i][j];
        }

        var ans = Math.Max(int.MinValue, nums1[i] * nums2[j] + Math.Max(0, Solve(i + 1, j + 1, nums1, nums2)));
        ans = Math.Max(ans, Solve(i + 1, j, nums1, nums2));
        ans = Math.Max(ans, Solve(i, j + 1, nums1, nums2));

        memo[i][j] = ans;

        return memo[i][j];
    }
}
