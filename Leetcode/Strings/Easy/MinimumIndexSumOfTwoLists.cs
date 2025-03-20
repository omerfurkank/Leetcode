using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Strings.Easy;
public static class MinimumIndexSumOfTwoLists
{
    public static string[] FindRestaurant(string[] list1, string[] list2)
    {
        Dictionary<string,int> commons = new();
        Dictionary<string, int> dict1 = list1.Select((value, index) => new { value, index }).ToDictionary(x => x.value, x => x.index);

        for (int i = 0; i < list2.Length; i++)
        {
            if (dict1.ContainsKey(list2[i])) commons.Add(list2[i], i + dict1[list2[i]]);
        }
        int minIndex = commons.Values.Min(s => s);
        return commons.Where(s => s.Value==minIndex).Select(s => s.Key).ToArray();
        
    }
}
