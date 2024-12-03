using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Arrays.Easy;

public static class AssignCookies
{
    //greedy
    public static int FindContentChildren(int[] g, int[] s)
    {
        Array.Sort(g);
        Array.Sort(s);
        int ate = 0;
        for (int i = 0; i < g.Length; i++)
        {
            for (int j = 0; j < s.Length; j++)
            {
                if (g[i] <= s[j])
                {
                    s[j] = 0;
                    ate++;
                    break;
                }
            }
        }
        return ate;
    }
    public static int FindContentChildren2(int[] g, int[] s)
    {
        Array.Sort(g);
        Array.Sort(s);
        var ch = 0;
        var eat = 0;

        while (eat < s.Length && ch < g.Length)
            if (s[eat] >= g[ch])
                ch++;

        eat++;

        return ch;
    }
}
