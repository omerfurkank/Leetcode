using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Arrays.Easy;
public static class ThirdMaximumNumber
{
    public static int ThirdMax(int[] nums)
    {
        Array.Sort(nums);
        List<int> result = new();
        int third = 0;
        for (int i = nums.Length - 1; i >= 0; i--)
        {
            if (!result.Contains(nums[i])) { result.Add(nums[i]); third++; }
            if (third == 3) return nums[i];
        }
        return nums[nums.Length - 1];
    }
}
