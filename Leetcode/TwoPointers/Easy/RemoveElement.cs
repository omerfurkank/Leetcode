using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.TwoPointers.Easy;
public static class RemoveElement
{
    public static int RemoveElement1(int[] nums, int val)
    {
        int uniqueNums = 0;

        for (int i = 0; i < nums.Length; i++) if (nums[i] != val) nums[uniqueNums++] = nums[i];

        return uniqueNums;
    }
}
