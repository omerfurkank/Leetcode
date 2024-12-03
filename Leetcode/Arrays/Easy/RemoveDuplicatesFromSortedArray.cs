using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Arrays.Easy;
public static class RemoveDuplicatesFromSortedArray
{
    //in-place
    public static int RemoveDuplicates1(int[] nums)
    {
        if (nums.Length == 0) return 0;

        int uniqueIndex = 1;
        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] != nums[i - 1]) nums[uniqueIndex++] = nums[i];
        }
        return uniqueIndex;
    }
    public static int RemoveDuplicates2(int[] nums)
    {
        var list = new List<int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (!list.Contains(nums[i])) list.Add(nums[i]);
        }
        for (int i = 0; i < list.Count; i++)
        {
            nums[i] = list[i];
        }
        return list.Count;
    }
}
