// LINK - https://leetcode.com/problems/maximum-product-of-splitted-binary-tree/

/**
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
 */
public class Solution 
{
    private long maxProduct = 0;
    private long total = 0;
    public int MaxProduct(TreeNode root) 
    {
        if (root is null)
        {
            return 0;
        }

        var sum = 0L;
        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        // Calculating Total Sum
        while (queue.Count() > 0)
        {
            var item = queue.Dequeue();
            sum += item.val;
            if (item.left is not null) queue.Enqueue(item.left);
            if (item.right is not null) queue.Enqueue(item.right);
        }

        total = sum;
        Dfs(root);
        return (int)(maxProduct % 1000000007);
    }

    private long Dfs(TreeNode node)
    {
        if (node is null)
        {
            return 0;
        }
        var currentTotal = node.val + Dfs(node.left) + Dfs(node.right);
        maxProduct = Math.Max(maxProduct, currentTotal * (total - currentTotal));
        return currentTotal;
    }
}
