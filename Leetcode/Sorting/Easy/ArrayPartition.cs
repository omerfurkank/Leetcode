using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Sorting.Easy;
public static class ArrayPartition
{
    public static int ArrayPairSum(int[] nums)
    {
        Array.Sort(nums);
        int result = 0;
        for (int i = 0; i < nums.Length; i += 2) result += Math.Min(nums[i], nums[i + 1]);
        return result;
    }
}

