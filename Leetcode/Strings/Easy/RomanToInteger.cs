using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Strings.Easy;
public static class RomanToInteger
{
    public static int RomanToInt1(string s)
    {
        int total = 0;
        int lastValue = 0;
        Dictionary<char, int> map = new(){
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 }
    };
        for (int i = s.Length - 1; i > -1; i--)
        {
            int value = map[s[i]];

            if (value >= lastValue) total += value;
            else total -= value;

            lastValue = value;
        }
        return total;
    }
    public static int RomanToInt2(string s)
    {
        int total = 0;
        int currentValue = 0;

        for (int i = s.Length - 1; i > -1; i--)
        {
            if (GetValue(s[i]) >= currentValue)
            {
                currentValue = GetValue(s[i]);
                total += currentValue;
            }
            else
            {
                total -= GetValue(s[i]);
            }
        }
        return total;
    }
    static int GetValue(char c)
    {
        if (c == 'I') return 1;
        if (c == 'V') return 5;
        if (c == 'X') return 10;
        if (c == 'L') return 50;
        if (c == 'C') return 100;
        if (c == 'D') return 500;
        if (c == 'M') return 1000;
        return 0;
    }
}
