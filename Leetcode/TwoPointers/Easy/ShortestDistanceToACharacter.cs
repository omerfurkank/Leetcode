using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.TwoPointers.Easy;
public static class ShortestDistanceToACharacter
{
    public static int[] ShortestToChar(string s, char c)
    {
        int[] result = new int[s.Length];
        int distance = -1;
        for (int i = 0; i < s.Length; i++)
        {

            if (s[i] == c)
            {
                result[i] = 0;
                distance = 1;
            }
            else if (distance == -1) result[i] = int.MaxValue;
            else
            {
                result[i] = distance++;
            }
        }
         distance = -1;
        for (int i = s.Length - 1; i > -1; i--)
        {

            if (s[i] == c)
            {
                distance = 1;
            }
            else if (distance == -1) continue;
            else
            {
                result[i] = Math.Min(result[i],distance++);
            }
        }
        return result;
    }
}
