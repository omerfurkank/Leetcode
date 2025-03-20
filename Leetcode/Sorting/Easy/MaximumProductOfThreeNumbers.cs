using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Sorting.Easy;
public static class MaximumProductOfThreeNumbers
{
    public static int MaximumProduct(int[] nums)
    {
        Array.Sort(nums);
        int max1 = nums[0] * nums[1] * nums[nums.Length - 1];
        int max2 = nums[nums.Length - 1] * nums[nums.Length - 2] * nums[nums.Length - 3];
        return Math.Max(max1, max2);
    }
}
