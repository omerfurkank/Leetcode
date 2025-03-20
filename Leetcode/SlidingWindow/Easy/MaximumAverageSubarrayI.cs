using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.SlidingWindow.Easy;
public static class MaximumAverageSubarrayI
{
    public static double FindMaxAverage(int[] nums, int k)
    {
        int n = nums.Length;
        double max = int.MinValue;
        double sum = 0;

        int left = 0;
        int right = 0;

        while (left + k <= n)
        {
            while (right - left < k)
            {
                sum += nums[right];
                right++;
            }
            max = Math.Max(max, sum);
            sum -= nums[left];
            left++;
        }

        return max / k;

    }
    public static double FindMaxAverage3(int[] nums, int k)
    {
        int localMax = 0;

        for (int i = 0; i < k; i++) localMax += nums[i];

        int max = localMax;

        for (int i = k; i < nums.Length; i++)
        {
            localMax += nums[i];          // Yeni elemanı ekle
            localMax -= nums[i - k];      // Eski elemanı çıkar
            max = Math.Max(max, localMax); // Maksimumu güncelle
        }

        return (double)max / k;
    }
    public static double FindMaxAverage2(int[] nums, int k)
    {
        var sum = 0;

        for (int i = 0; i < k; i++)
            sum += nums[i];

        var maxSum = sum;
        var nextIndex = k;

        while (nextIndex <= nums.Length - 1)
        {
            sum += nums[nextIndex];
            sum -= nums[nextIndex - k];

            if (sum > maxSum) maxSum = sum;

            nextIndex++;
        }
        return maxSum / (double)k;
    }
}
