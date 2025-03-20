using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Sorting.Easy;
public static class SortArrayByParity
{
    public static int[] SortArrayByParity1(int[] nums)
    {
        int left = 0, right = nums.Length - 1;

        while (left < right)
        {
            if (nums[left] % 2 > nums[right] % 2) // Sol tek, sağ çiftse değiştir
            {
                (nums[left], nums[right]) = (nums[right], nums[left]);
            }

            if (nums[left] % 2 == 0) left++;  // Çiftse ilerle
            if (nums[right] % 2 == 1) right--; // Tekse geriye gel
        }

        return nums;
    }
    public static int[] SortArrayByParity2(int[] nums)
    {
        List<int> list = new();
        foreach (var num in nums) if (num % 2 == 0) list.Add(num);
        foreach (var num in nums) if (num % 2 == 1) list.Add(num);
        return list.ToArray();
    }
    public static int[] SortArrayByParity3(int[] nums)
    {
        int e = 0;
        int o = nums.Length - 1;

        while (o > e)
        {
            if (nums[e] % 2 == 0) e++;
            else
            {
                if (nums[o] % 2 != 0) o--;
                else
                {
                    var temp = nums[e];
                    nums[e] = nums[o];
                    nums[o] = temp;
                    e++;
                    o--;
                }
            }
        }
        return nums;
    }
}
