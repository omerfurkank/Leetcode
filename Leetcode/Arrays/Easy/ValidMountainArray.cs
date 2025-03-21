using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Arrays.Easy;

public static class ValidMountainArray
{
    public static bool ValidMountainArray1(int[] arr)
    {
        if (arr.Length < 3) return false; // En az 3 eleman olmalı

        int i = 0;

        while (i < arr.Length - 1 && arr[i] < arr[i + 1]) i++;

        if (i == 0 || i == arr.Length - 1) return false;

        while (i < arr.Length - 1 && arr[i] > arr[i + 1]) i++;

        return i == arr.Length - 1;
    }
    public static bool ValidMountainArray2(int[] arr)
    {
        int left = 0;
        int right = arr.Length - 1;
        while (left + 1 < arr.Length && arr[left] < arr[left + 1])
        {
            left++;
            if (left == right)
                return false;
        }
        while (right - 1 > 0 && arr[right - 1] > arr[right])
            right--;
        return left > 0 && right < arr.Length - 1 && left == right;
    }
}
