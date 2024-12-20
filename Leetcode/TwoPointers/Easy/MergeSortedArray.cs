using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.TwoPointers.Easy;
public static class MergeSortedArray
{
    public static void Merge(int[] nums1, int m, int[] nums2, int n)
    {
        int[] newNums = new int[m + n];
        for (int i = 0; i < m; i++)
        {
            newNums[i] = nums1[i];
        }
        for (int i = m; i < m + n; i++)
        {
            newNums[i] = nums2[i - m];
        }
        Array.Sort(newNums);
        for (int i = 0; i < m + n; i++)
        {
            nums1[i] = newNums[i];
        }
    }
}
