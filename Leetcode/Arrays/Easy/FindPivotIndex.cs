using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Arrays.Easy;
public static class FindPivotIndex
{
    public static int PivotIndex(int[] nums)
    {
        int leftSum = 0;
        int total = 0;
        foreach (var i in nums) total += i;

        for (int i = 0; i < nums.Length; i++)
        {
            if (leftSum == total  - nums[i]) return i;
            else
            {
                leftSum += nums[i];
                total -= nums[i];
            }
        }
        return 0;
    }
}
