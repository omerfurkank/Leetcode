using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Sorting.Easy;
public static class RelativeRanks
{
    public static string[] FindRelativeRanks(int[] score)
    {
        string[] strings = new string[score.Length];
        var list = score.ToList().OrderByDescending(s => s).ToList();

        int first = Array.IndexOf(score, list[0]);
        strings[first] = "Gold Medal";

        if (score.Length > 1)
        {
            int second = Array.IndexOf(score, list[1]);
            strings[second] = "Silver Medal";
        }
        if (score.Length > 2)
        {
            int third = Array.IndexOf(score, list[2]);
            strings[third] = "Bronze Medal";
        }
        for (int i = 3; i < score.Length; i++)
        {
            int rank = Array.IndexOf(score, list[i]);
            strings[rank] = $"{i + 1}";
        }
        return strings;
    }
    public static string[] FindRelativeRanks2(int[] score)
    {
        string[] strings = new string[score.Length];
        var indexedScore = score //select overload, select knows index and value
            .Select((value, index) => new { Value = value, Index = index })
            .OrderByDescending(x => x.Value)
            .ToList();

        for (int i = 0; i < indexedScore.Count; i++)
        {
            int index = indexedScore[i].Index;
            strings[index] = i switch
            {
                0 => "Gold Medal",
                1 => "Silver Medal",
                2 => "Bronze Medal",
                _ => (i + 1).ToString()
            };
        }
        return strings;
    }
}
