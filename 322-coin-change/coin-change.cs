public class Solution {
    public int CoinChange(int[] coins, int amount) {
        int[] dp = new int[amount + 1];

        //array filled with amount+1 values
       Array.Fill(dp, amount+1); 
        dp[0] = 0; 

        for (int i = 1; i <= amount; i++) {
            foreach (int coin in coins) {
                if (i - coin >= 0) {
                   // Console.WriteLine(coin);
                   // Console.WriteLine(dp[i - coin] + 1);
                   // Console.WriteLine(dp[i]);
                    dp[i] = Math.Min(dp[i], dp[i - coin] + 1);
                }
            }
        }

         return dp[amount] == amount+1 ? -1 : dp[amount];
    }
}