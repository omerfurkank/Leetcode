using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Arrays;
public static class BestTimeToBuyAndSellStock
{
    public static int MaxProfit1(int[] prices)
    {
        int profit = 0;
        for (int i = 0; i < prices.Length; i++)
        {
            for (int j = i + 1; j < prices.Length; j++)
            {
                if (prices[j] - prices[i]>profit) profit = prices[j] - prices[i];
            }
        }
        return profit;
    }
    public static int MaxProfit2(int[] prices)
    {
        int minValue = prices[0];
        int maxProfit = 0;
        for (int i = 0; i < prices.Length; i++)
        {
            if (prices[i]<minValue) minValue = prices[i];
            else if (prices[i]- minValue > maxProfit) maxProfit = prices[i]- minValue;
        }
        return maxProfit;
    }
}
