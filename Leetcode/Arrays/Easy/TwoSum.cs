using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Arrays.Easy;

public static class TwoSum
{
    //brute force
    public static int[] TwoSum1(int[] nums, int target)
    {
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                if (nums[i] + nums[j] == target) return new int[] { i, j };
            }
        }
        return new int[2];
    }

    //hashset
    public static int[] TwoSum2(int[] nums, int target)
    {
        var set = new HashSet<int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (set.Contains(target - nums[i])) return new int[] { i, Array.IndexOf(nums, target - nums[i]) };
            else set.Add(nums[i]);
        }
        return new int[2];
    }

    //dictionary
    public static int[] TwoSum3(int[] nums, int target)
    {
        var dict = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (dict.ContainsKey(target - nums[i])) return new int[] { i, dict[target - nums[i]] };
            if (!dict.ContainsKey(nums[i])) dict.Add(nums[i], i);
        }
        return new int[2];
    }
}