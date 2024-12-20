using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.TwoPointers.Easy;
public static class IntersectionOfTwoArrays
{
    public static int[] Intersection(int[] nums1, int[] nums2)
    {
        var list = nums1.ToList();
        var set = new HashSet<int>();
        foreach (var item in nums2)
            if (list.Contains(item)) set.Add(item);

        return set.ToArray();
    }
}
