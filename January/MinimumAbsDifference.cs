// LINK - https://leetcode.com/problems/minimum-absolute-difference/

public class Solution 
{
    public IList<IList<int>> MinimumAbsDifference(int[] arr) 
    {
        Array.Sort(arr);
        var min = int.MaxValue;
        for (var i = 1; i < arr.Length; i++)
        {
            min = Math.Min(min, arr[i] - arr[i - 1]);
        }       
        var result = new List<IList<int>>();
        for (var i = 1; i < arr.Length; i++)
        {
            if (arr[i] - arr[i - 1] == min)
            {
                result.Add([arr[i - 1], arr[i]]);
            }
        }
        return result;
    }
}
