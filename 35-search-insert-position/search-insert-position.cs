public class Solution {
    public int SearchInsert(int[] nums, int target) {
        if(nums.Count() == 0)
            return 0;

        //first and last index
        var l = 0;
        var r = nums.Length - 1; 
        while(l < r)
        {
            var middle = l +  (r - l)/ 2;
                //choosing either the lest of right side
            if(nums[middle] == target)
                return middle; 

            if(nums[middle] >= target)
                r = middle; 
            else 
                l = middle + 1; 
        }

        //at last index
        if(r == nums.Length -1)
        {
            //still not at target, needs another element with last index
            if(nums[r] < target)
                return nums.Length;

            return r; 
        }

        return l;

        
    }
}