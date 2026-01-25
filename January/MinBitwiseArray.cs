// LINK - https://leetcode.com/problems/construct-the-minimum-bitwise-array-i/description/


public class Solution 
{
    public int[] MinBitwiseArray(IList<int> nums) 
    {
        var result = new int[nums.Count];

        for (var i = 0; i < nums.Count; i++) 
        {
            var original = nums[i];
            var candidate = -1;
            for (var j = 1; j < original; j++) 
            {
                if ((j | (j + 1)) == original) 
                {
                    candidate = j;
                    break;
                }
            }

            result[i] = candidate;
        }

        return result;
    }



  //  abc
