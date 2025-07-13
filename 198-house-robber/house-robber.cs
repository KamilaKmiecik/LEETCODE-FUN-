public class Solution {
    public int Rob(int[] nums) {

        if(nums.Length == 1) return nums[0];

        int candidate1 = nums[0], candidate2 = Math.Max(nums[0], nums[1]);

        for(int i =2; i < nums.Length; i++)
        {
            //cur is either previous candidate or sum of 2nd before candidate + current number
            int curr = Math.Max(candidate2, candidate1 + nums[i]);
            candidate1 = candidate2;
            candidate2 = curr; 
        }

        return candidate2; 
    }
}