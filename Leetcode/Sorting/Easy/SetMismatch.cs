using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Sorting.Easy;
public static class SetMismatch
{
    public static int[] FindErrorNums(int[] nums)
    {
        HashSet<int> seen = new HashSet<int>();
        int duplicate = -1, missing = -1;

        foreach (int num in nums)
        {
            if (!seen.Add(num)) duplicate = num;
        }

        for (int i = 1; i <= nums.Length; i++)
        {
            if (!seen.Contains(i)) missing = i;
        }

        return [duplicate, missing];
    }
}
