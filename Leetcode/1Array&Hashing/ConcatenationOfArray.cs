using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode._1Array_Hashing;

static class ConcatenationOfArray
{
    public static int[] GetConcatenation(int[] nums)
    {
        int[] result = new int[nums.Length * 2];

        for (int i = 0; i <= nums.Length - 1; i++)
        {
            result[i] = nums[i];
            result[i + nums.Length] = nums[i];
        }
        return result;
    }
}
