using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Arrays.Easy;
public static class FindSmallestLetterGreaterThanTarget
{
    public static char NextGreatestLetter(char[] letters, char target)
    {
        int left = 0, right = letters.Length - 1;

        // İkili arama ile hedeften büyük en küçük harfi buluyoruz
        while (left <= right)
        {
            int mid = left + (right - left) / 2;

            if (letters[mid] > target)
            {
                right = mid - 1; // Daha küçük bir öğeye bakmamız gerek
            }
            else
            {
                left = mid + 1; // Daha büyük bir öğeye bakmamız gerek
            }
        }

        // left indeksindeki harf, target'tan büyük olan en küçük harftir
        return letters[left % letters.Length];
    }
}
