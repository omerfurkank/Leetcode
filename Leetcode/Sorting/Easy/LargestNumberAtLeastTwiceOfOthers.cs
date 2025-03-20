using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Sorting.Easy;
public static class LargestNumberAtLeastTwiceOfOthers
{
    public static int DominantIndex(int[] nums)
    {
        if (nums.Length == 1) return 0; // Tek eleman varsa otomatik olarak dominanttır.

        int maxIndex = 0;
        int maxValue = nums[0];
        int secondMax = int.MinValue; // En küçük olası değerden başlat

        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] > maxValue)
            {
                secondMax = maxValue; // Önceki en büyüğü ikinci büyük yap
                maxValue = nums[i];
                maxIndex = i;
            }
            else if (nums[i] > secondMax)
            {
                secondMax = nums[i]; // İkinci en büyük değeri güncelle
            }
        }

        return maxValue >= secondMax * 2 ? maxIndex : -1;

    }
}
