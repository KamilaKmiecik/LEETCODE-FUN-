public class Solution {
    public int MaxProfit(int[] prices) {
        int diff = 0, minPrice = prices[0];
      
            foreach(int price in prices)
            {
                if(price < minPrice)
                    minPrice = price; 

                if(diff < price - minPrice)
                    diff = price - minPrice;
            }

            return diff;
    }
}