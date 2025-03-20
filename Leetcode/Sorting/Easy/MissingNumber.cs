using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Sorting.Easy;

public class MissingNumber
{
    public static int MissingNumber1(int[] nums)
    {
        int n = nums.Length;
        Array.Sort(nums);
        var arr = new int[n + 1];
        for (int i = 0; i < n + 1; i++)
        {
            { arr[i] = i; }
        }
        for (int i = 0; i < n; i++)
        {
            if (nums[i] != arr[i]) return i;
        }
        return arr[n];
    }
    public static int MissingNumber2(int[] nums)
    {
        int index = 0;
        Array.Sort(nums);
        while (index < nums.Length)
        {
            if (nums[index] != index++) return index - 1;
        }
        return nums[index - 1] + 1;
    }
    public static int MissingNumber3(int[] nums)
    {
        int n = nums.Length;
        int sum = 0;
        for (int i = 0; i < n; i++) sum += nums[i];

        int orgSum = n * (n + 1) / 2;
        return orgSum - sum;
    }
}
