using System;

namespace StockBuyAndSell
{
    class Program
    {
        static void Main(string[] args)
        {
            var profit = MaxProfit(new int[] { 7, 1, 5, 3, 6, 4 });
        }

        public static int MaxProfit(int[] prices)
        {
            int lowest = prices[0];

            int lowestIndex = 0;
            int highestIndex = 0;
            for (int i = 1; i < prices.Length; i++)
            {
                if (prices[i] < lowest)
                {
                    lowest = prices[i];
                    lowestIndex = prices[i];
                }

            }

            if (lowestIndex == (prices.Length - 1)) return 0;

            int highest = prices[lowestIndex];
            for (int i = lowestIndex; i < prices.Length; i++)
            {
                if (prices[i] > highest)
                {
                    highest = prices[i];
                    highestIndex = prices[i];
                }
            }

            if (highestIndex != 0)
            {
                return prices[highestIndex] - prices[lowestIndex];
            }

            return 0;
        }
    }
}
