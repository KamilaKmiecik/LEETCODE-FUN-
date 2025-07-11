public class Solution {
    public string LargestNumber(int[] nums) {

        if(nums.Min() == 0 && nums.Sum() == 0)
            return "0";


        var numsString = nums
            .OrderByDescending(n => int.Parse(n.ToString()[0].ToString()))
            .Select(x => x.ToString())
            .ToArray();

        Array.Sort(numsString,(a,b) => String.Compare(b+a, a+b));

        return string.Concat(numsString);
    }
}