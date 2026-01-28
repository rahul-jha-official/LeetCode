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

// With LINQ
public class Solution 
{
    public IList<IList<int>> MinimumAbsDifference(int[] arr) 
    {
        // Sort
        Array.Sort(arr);
        
        // Find Min
        var min = arr
                    .Select((e, i) => i == 0 ? int.MaxValue : e - arr[i - 1])
                    .Min();
                    
        // Find Pairs
        return arr
                    .Select((e, i) => i == 0 || (e - arr[i - 1]) != min ? null : new List<int>() { arr[i - 1], e })
                    .Where(e => e != null)
                    .Cast<IList<int>>()
                    .ToList();
    }
}
