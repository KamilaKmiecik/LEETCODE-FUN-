public class Solution {
    public int FindDuplicate(int[] nums) {
        
        int i = 1; 
        var arr = new List<int>();
        foreach(int num in nums)
            if(arr.Contains(num))
                return num;
            else 
                arr.Add(num);
            


        return 0;
    }
}