public class Solution {
    public void Rotate(int[] nums, int k) {
        int[] temp = new int[nums.Length];
        Array.Copy(nums, temp, nums.Length);

        for(int i = 0; i < nums.Length; i++)
        {
            var c = temp[i];
            int rotatedIndex = (i + k) % nums.Length;
            nums[rotatedIndex] = c;
        }

      //  nums = temp;
    }
}