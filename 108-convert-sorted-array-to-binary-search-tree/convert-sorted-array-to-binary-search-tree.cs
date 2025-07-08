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
public class Solution {

    private TreeNode AddLeftRight(int[] nums, int left, int right)
    {
        if(left > right)
            return null; 
         int mid = left + (right - left) / 2;
        TreeNode miniTree = new TreeNode(nums[mid]);
        miniTree.left = AddLeftRight(nums, left, mid - 1);
        miniTree.right = AddLeftRight(nums, mid + 1, right);
        return miniTree;
    }
    public TreeNode SortedArrayToBST(int[] nums) {

      

        return AddLeftRight(nums, 0, nums.Length - 1);
    }
}