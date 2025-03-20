using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Sorting.Easy;
public static class MajorityElement
{
    public static int MajorityElement1(int[] nums)
    {
        Array.Sort(nums);
        int med = nums.Length / 2;
        int counter = 1;
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] == nums[i - 1])
            {
                counter++;
                if (counter > med) return nums[i];
            }
            else counter = 1;
        }
        return nums[0];
    }
    //Boyer-Moore Voting Algorithm
    public static int MajorityElement2(int[] nums)
    {
        int candidate = nums[0];
        int count = 0;

        foreach (int num in nums)
        {
            if (count == 0) candidate = num;

            count += num == candidate ? 1 : -1;
        }

        return candidate;
    }
}
