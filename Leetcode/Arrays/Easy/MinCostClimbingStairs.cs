using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Arrays.Easy;
public static class MinCostClimbingStairs
{
    public static int MinCostClimbingStairs1(int[] cost)
    {
        int n = cost.Length;
        int oneStepBefore = 0;  // Represents dp[i-1]
        int twoStepsBefore = 0; // Represents dp[i-2]

        for (int i = 2; i <= n; i++)
        {
            int current = Math.Min(
                oneStepBefore + cost[i - 1],
                twoStepsBefore + cost[i - 2]
            );
            twoStepsBefore = oneStepBefore;
            oneStepBefore = current;
        }

        return oneStepBefore;


    }
}
