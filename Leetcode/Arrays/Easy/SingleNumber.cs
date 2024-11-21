using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Arrays.Easy;

public static class SingleNumber
{
    public static int SingleNumber1(int[] nums)
    {
        Array.Sort(nums);
        if (nums.Length == 1) return nums[0];

        if (nums[0] != nums[1]) return nums[0];
        for (int i = 1; i < nums.Length - 1; i++)
        {
            if (nums[i] != nums[i - 1] && nums[i] != nums[i + 1])
            {
                return nums[i];
            }
        }
        return nums[nums.Length - 1];
    }
    public static int SingleNumber2(int[] nums)
    {
        if (nums.Length == 1) return nums[0];

        int num = 0;
        for (int i = 0; i < nums.Length; i++)
            num = nums[i] ^ num;

        return num;
    }
}

