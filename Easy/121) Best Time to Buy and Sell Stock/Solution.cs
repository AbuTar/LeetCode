public class Solution {
    public int MaxProfit(int[] prices) {

        int minimum = int.MaxValue;
        int max_profit = 0;

        for (int i = 0; i < prices.Length; i++) {
            if (prices[i] < minimum) {
                minimum = prices[i];          
            } else {
                max_profit = Math.Max(max_profit, prices[i] - minimum); 
            }
        }

        return max_profit;
    }
}