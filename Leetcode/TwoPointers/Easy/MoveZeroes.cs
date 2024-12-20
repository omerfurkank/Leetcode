using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.TwoPointers.Easy;
public static class MoveZeroes
{
    public static int[] MoveZeroes1(int[] nums)
    {
        int uniqueIndex = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != 0)
            {
                nums[uniqueIndex++] = nums[i];
            }
        }
        for (int i = uniqueIndex; i < nums.Length; i++)
        {
            nums[i] = 0;
        }
        return nums;
    }
}
