using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Strings.Medium;
public static class IntegerToRoman
{
    public static string IntToRoman(int num)
    {
        Dictionary<int, string> dict = new() { { 1000, "M" }, { 500, "D" }, { 400, "CD" }, { 100, "C" }, { 50, "L" }, { 40, "XL" }, { 10, "X" }, { 5, "V" }, { 1, "I" } };

        string result = "";
        foreach (var (value, roman) in dict)
        {
            while (num > value)
            {
                result += roman;
                num -= value;
            }
        }
        return result;

    }
}
