public class Solution {
    public void MoveZeroes(int[] nums) {
        if(nums.Count() == 0)
            return; 

        int k = 0;
        //reindex the array removing zero, using k as new index
        for(int i = 0; i < nums.Length; i++)
        {
            if(nums[i] != 0)
            {
                nums[k] = nums[i];
                k++; 
            }
        }
        //swth the missing zeros
        for(int j  = k; k < nums.Length; k++)
        {
            nums[k] = 0;
        }
    }
}