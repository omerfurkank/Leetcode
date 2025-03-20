using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Arrays.Easy;
public static class _1bitand2bitCharacters
{
    public static bool IsOneBitCharacter(int[] bits)
    {
        int index = 0;
        while (index < bits.Length - 1) index += bits[index] + 1;

        return index == bits.Length - 1;
    }
}

