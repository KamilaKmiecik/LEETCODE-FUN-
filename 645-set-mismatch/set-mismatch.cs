public class Solution {
    public int[] FindErrorNums(int[] nums) {
        
        int[] count = new int[nums.Length + 1];

        foreach (int n in nums)
            count[n]++;

        int dup = -1, miss = -1;

        for (int i = 1; i <= nums.Length; i++)
        {
            if (count[i] == 2)
                dup = i;
            else if (count[i] == 0)
                miss = i;
        }

        return new int[] { dup, miss };
    }
}