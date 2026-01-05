// LINK - https://leetcode.com/problems/maximum-matrix-sum/description/

public class Solution 
{
    public long MaxMatrixSum(int[][] matrix) 
    {
        var sum = 0L;
        var negativeCount = 0;
        var minimumAbsoluteValue = int.MaxValue;
        foreach (var row in matrix)
        {
            foreach (var column in row)
            {
                var value = Math.Abs(column);
                sum += value;
                negativeCount += column < 0 ? 1 : 0;
                minimumAbsoluteValue = Math.Min(minimumAbsoluteValue, value);
            }
        }

        if (negativeCount % 2 != 0)
        {
            sum -= 2 * minimumAbsoluteValue;
        }

        return sum;
    }
}
