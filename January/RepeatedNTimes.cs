// LINK - https://leetcode.com/problems/n-repeated-element-in-size-2n-array/

public class Solution 
{
    public int RepeatedNTimes(int[] nums) 
    {
        var n = nums.Length / 2;
        var set = new HashSet<int>(n + 1);
        foreach (var num in nums)
        {
            if (set.Contains(num)) return num;
            set.Add(num);
        }                
        return -1;
    }
}
