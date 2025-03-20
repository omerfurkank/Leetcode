using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Sorting.Algorithms;

public static class BubbleSort
{
    public static void Sort<T>(T[] arr)
    {
        bool swapped;
        for (int i = 0; i < arr.Length; i++)
        {
            swapped = false;
            for (int j = 0; j < arr.Length - 1 - i; j++)
            {
                if (Comparer<T>.Default.Compare(arr[j], arr[j + 1]) > 0)
                {
                    (arr[j], arr[j + 1]) = (arr[j + 1], arr[j]);
                    swapped = true;
                }

            }
            if (!swapped) break;
        }
    }
}

