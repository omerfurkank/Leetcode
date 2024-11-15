using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Arrays.Easy;
public static class SummaryRanges
{
    public static IList<string> SummaryRanges1(int[] nums)
    {
        List<string> result = new();
        int left = 0, right = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == nums[nums.Length - 1])
            {
                right = i;

                if (left == right)
                {
                    result.Add($"{nums[i]}"); left++;
                    right++;
                }
                else
                {
                    result.Add($"{nums[left]}->{nums[right]}");
                    left = i + 1;
                    right = i + 1;
                }
            }
            else if (nums[i + 1] - nums[i] == 1)
            {
                right++;
            }
            else if (nums[i + 1] - nums[i] != 1)
            {
                if (left == right)
                {
                    result.Add($"{nums[i]}"); left++;
                    right++;
                }
                else
                {
                    result.Add($"{nums[left]}->{nums[right]}");
                    left = i + 1;
                    right = i + 1;
                }
            }
        }
        return result;
    }
    public static IList<string> SummaryRanges2(int[] nums)
    {
        List<string> result = [];
        if (nums.Length != 0)
        {
            int start = nums[0];
            int end = nums[0];
            for (int i = 1; i < nums.Length; i++)
            {
                if (nums[i] - nums[i - 1] == 1)
                {
                    end = nums[i];
                }
                else if (start == end)
                {
                    result.Add(start.ToString());
                    start = nums[i];
                    end = nums[i];
                }
                else
                {
                    result.Add(start.ToString() + "->" + end.ToString());
                    start = nums[i];
                    end = nums[i];
                }
            }
            if (start == end) result.Add(start.ToString());
            else result.Add(start.ToString() + "->" + end.ToString());
        }
        return result;
    }
}
