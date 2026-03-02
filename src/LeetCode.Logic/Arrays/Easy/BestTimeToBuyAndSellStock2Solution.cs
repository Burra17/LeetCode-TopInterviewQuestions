namespace LeetCode.Logic.Arrays.Easy

{
    public class BestTimeToBuyAndSellStock2Solution
    {
        //https://leetcode.com/explore/interview/card/top-interview-questions-easy/92/array/564/
        public int MaxProfit(int[] prices)
        {
            int maxProfit = 0;
            for (int i = 1; i < prices.Length; i++) 
            {
                // If the price of the stock on the current day is higher than the price on the previous day,
                // we can profit by buying on the previous day and selling on the current day.
                if (prices[i] > prices[i - 1])
                {
                    maxProfit += prices[i] - prices[i - 1];
                }
            }
            return maxProfit;
        }
    }
}
