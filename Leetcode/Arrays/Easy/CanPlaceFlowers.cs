using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Arrays.Easy;
public static class CanPlaceFlowers
{
    public static bool CanPlaceFlowers1(int[] flowerbed, int n)
    {
        int empty =1;
        for (int i = 0; i < flowerbed.Length; i++)
        {
            if (flowerbed[i] == 1)
            {
                empty = 0;
                continue;
            }
            else
            {
                if (i == flowerbed.Length - 1 && empty == 1) n--; 
                if (empty == 2)
                {
                    empty = 1;
                    n--;
                }
                else empty++;
            }
        }
        return n<= 0 ? true : false;
    }
}
