public class Solution {
   public int MissingInteger(int[] nums)
   {
       int l = nums.Length;

       //first number is always fine
       int sum = nums[0];
       for(int i = 1; i < l; i++)
       {
            //checking if sequence is still sequential
            if (nums[i] == nums[i - 1] + 1)
                sum += nums[i];
            else
                break;
       }
            

       while (nums.Contains(sum))
           sum++;


           return sum;
   }
}