public class Solution {
    public IList<int> LargestDivisibleSubset(int[] nums) {
        Array.Sort(nums);
        IList<int> result = new List<int>() {nums[0]};
        IList<int>[] dp = nums.Select(n => new List<int> { n }).ToArray();

          for(int i = 1; i < nums.Length; i++){
            for(int j = 0; j < i; j++){
                if(nums[i] % nums[j] == 0){
                    IList<int> tmpList = new List<int>(dp[j]);
                    tmpList.Add(nums[i]);
                    
                   // Console.WriteLine(string.Join(",", tmpList));
                   // Console.WriteLine(string.Join(",", dp[i]));
                   // Console.WriteLine(string.Join(",", dp[j]));
                    if(tmpList.Count > dp[i].Count){
                        dp[i] = tmpList;
                    }

                    if(tmpList.Count > result.Count){
                        result = tmpList;
                    }
                }
            }
        }
            return result; 
    }
}