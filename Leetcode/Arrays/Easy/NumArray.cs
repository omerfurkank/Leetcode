using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Arrays.Easy;
public class NumArray1
{
    private int[] _nums;
    public NumArray1(int[] nums)
    {
        _nums = nums;
    }

    public int SumRange(int left, int right)
    {
        int sum = 0;
        for (int i = left; i <= right; i++)
        {
            sum += _nums[i];
        }
        return sum;
    }
}
public class NumArray2
{
    private int[] prefixSum;

    public NumArray2(int[] nums)
    {
        prefixSum = new int[nums.Length + 1];

        // Prefix toplamlarını hesapla
        for (int i = 0; i < nums.Length; i++)
        {
            prefixSum[i + 1] = prefixSum[i] + nums[i];
        }
    }

    public int SumRange(int left, int right)
    {
        // Prefix toplamını kullanarak sumRange sonucu döndür
        return prefixSum[right + 1] - prefixSum[left];
    }
}

