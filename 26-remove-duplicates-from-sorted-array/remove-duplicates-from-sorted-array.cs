public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int duplicates = 1;
        foreach(int num in nums)
            if (nums[duplicates - 1] != num) 
                    nums[duplicates++] = num;


        return duplicates;
    }
}