public class Solution {
    public int[] TwoSum(int[] nums, int target) {
           var numToIndex = new Dictionary<int, int>();
//test
        for (int i = 0; i < nums.Length; i++)
        {
            int complement = target - nums[i];

            if (numToIndex.ContainsKey(complement))
            {
                return new int[] { numToIndex[complement], i };
            }

            if (!numToIndex.ContainsKey(nums[i]))
            {
                numToIndex[nums[i]] = i;
            }
        }

        throw new InvalidOperationException("No two sum solution found");
    }
}