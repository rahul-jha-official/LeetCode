https://leetcode.com/problems/minimum-time-visiting-all-points/description/

public class Solution 
{
    public int MinTimeToVisitAllPoints(int[][] points) 
    {
        var ans = 0;
        for (var i = 0; i < points.Length - 1; i++) 
        {
            var currX = points[i][0];
            var currY = points[i][1];
            var targetX = points[i + 1][0];
            var targetY = points[i + 1][1];
            ans += Math.Max(Math.Abs(targetX - currX), Math.Abs(targetY - currY));
        }
        
        return ans;        
    }
}
