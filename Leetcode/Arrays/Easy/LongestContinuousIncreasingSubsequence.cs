using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Arrays.Easy;
public static class LongestContinuousIncreasingSubsequence
{
    public static int FindLengthOfLCIS(int[] nums)
    {
        int counter = 1;
        int max = 1;
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] > nums[i - 1])
            {
                counter++;
                if (counter > max) max = counter;
            }
            else counter = 1;
        }
        return max; ;
    }
}
