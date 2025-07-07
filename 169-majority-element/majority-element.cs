public class Solution {
    public int MajorityElement(int[] nums) {

  var dict = new Dictionary<int, int>();
  
  for (int i = 0; i < nums.Length; i++)
  {
     if (dict.ContainsKey(nums[i]))
         dict[nums[i]]++;
     else
         dict.Add(nums[i], 1);

  }

 return dict.MaxBy(x => x.Value).Key;
    }
}