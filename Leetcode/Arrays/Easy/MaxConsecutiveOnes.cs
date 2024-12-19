using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Arrays.Easy;
public static class MaxConsecutiveOnes
{
    public static int FindMaxConsecutiveOnes(int[] nums)
    {
        int counter = 0;
        int max = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 1) counter++;
            else 
            {
                if (counter > max)
                    max = counter;

                counter = 0;
            }
        }
        return max > counter ? max : counter;
    }
}
