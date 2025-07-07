public class Solution {
    public int SingleNumber(int[] nums) {
         HashSet<int> hash = new HashSet<int>();

   for (int i = 0; i < nums.Length; i++)
   {
       if (hash.Contains(nums[i]))
           hash.Remove(nums[i]);
       else
           hash.Add(nums[i]);
   }

   return hash.First();
    }
}