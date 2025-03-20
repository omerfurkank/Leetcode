using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.SlidingWindow.Easy;
public static class LongestHarmoniousSubsequence
{
    public static int FindLHS(int[] nums)
    {
        int max = 0;
        Dictionary<int, int> map = new();

        foreach (int num in nums)
        {
            if (map.ContainsKey(num)) map[num]++;
            else map[num] = 1;
        }
        foreach (int key in map.Keys)
        {
            if (map.ContainsKey(key + 1))
                max = Math.Max(max, map[key] + map[key + 1]);
        }
        return max;
    }
}
