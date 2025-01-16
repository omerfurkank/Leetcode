using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Leetcode.Arrays.Easy;
public static class PlusOne
{
    public static int[] PlusOne1(int[] digits)
    {
        for (int i = digits.Length - 1; i > -1; i--)
        {
            if (digits[i] != 9)
            {
                digits[i]++;
                return digits;
            }
            digits[i] = 0;
        }
        int[] result = new int[digits.Length + 1];
        result[0] = 1;
        return result;
    }
}
