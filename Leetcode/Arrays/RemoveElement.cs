using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Arrays;
public static class RemoveElement
{
    public static int RemoveElement1(int[] nums, int val)
    {
        int uniqueIndex = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != val) {
                nums[uniqueIndex++] = nums[i];
            }
        }
        return uniqueIndex;
    }
}
