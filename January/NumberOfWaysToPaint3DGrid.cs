// LINK - https://leetcode.com/problems/number-of-ways-to-paint-n-3-grid/

public class Solution 
{
    public int NumOfWays(int n) 
    {
        // R - RED
        // G - GREEN
        // Y - YELLOW
        
        // To Prevent Overflow
        const int mod = 1_000_000_007;

        // All Different Pattern
        // RGY, RYG, GYR, GRY, YRG, YGR
        var allDiffPattern = 6L;

        // 2 Same 1 Different
        // RGR, RYR, GRG, GYG, YRY, YGY
        var twoSamePattern = 6L;

        // For More than 1 Columns
        for (var i = 2; i <= n; i++)
        {
            // For AllDiffPattern
            // Lets Consider - RGY
            // Bottom can be - GYR, YRG with all different and GRG, GYG with 2 same
            // Thus allDiffPattern = 2 * allDiffPattern + 2 * twoSamePattern

            // For 2 Same 1 Different
            // Lets Consider - RGR
            // Bottom can be - GRY, YRG with all different and GRG, GYG, YRY with 2 same
            // Thus allDiffPattern = 2 * allDiffPattern + 3 * twoSamePattern

            // NOTE: Take modulus of final result to prevent overflow
            (allDiffPattern, twoSamePattern) = ((2 * allDiffPattern + 2 * twoSamePattern) % mod, (2 * allDiffPattern + 3 * twoSamePattern) % mod);
        }

        return (int)((allDiffPattern + twoSamePattern) % mod);
    }
}
