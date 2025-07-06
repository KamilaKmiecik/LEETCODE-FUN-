public class Solution {
    public int RemoveElement(int[] nums, int val) {
       
            if (nums.Count() == 0)
                return 0;

            int k = 0;

            //go through the array and switch elements equal to val
            for (int i = 0; i < nums.Length; i++)
            {
                if(nums[i] != val)
                {
                    nums[k] = nums[i];
                    k++;
                }

            }

            return k;
    }
}