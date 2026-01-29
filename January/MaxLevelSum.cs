// LINK - https://leetcode.com/problems/maximum-level-sum-of-a-binary-tree/

/**
 *
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 *
 */

public class Solution 
{
    public int MaxLevelSum(TreeNode root)
     {
        var res = new List<int>();
        var queue = new Queue<(TreeNode Node,int Level)>();
        var level = 0;

        if(root != null) 
        {
            queue. Enqueue((root,0));
        }
        
        while(queue.Count() > 0)
        {
            var x = queue.Dequeue();
            if(res.Count() > x.Level) 
            {
                res[x.Level] += x.Node.val;
            }
            else 
            {
                res.Add(x.Node.val);
            }
            if(x.Node.left != null)  
            {
                queue.Enqueue((x.Node.left,  x.Level +1));
            }
            if(x.Node.right != null) 
            {
                queue.Enqueue((x.Node.right, x.Level +1));
            }
        }
        var maxLevel = 0;

        for(var i = 1; i < res.Count; i++)
        {
            if(res[maxLevel] < res[i]) 
            {
                maxLevel = i;
            }
        }

        return maxLevel +1;        
    }
}
