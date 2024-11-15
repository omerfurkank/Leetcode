using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Arrays.Easy;
public static class ContainsDuplicate
{
    public static bool ContainsDuplicate1(int[] nums)
    {
        HashSet<int> set = new();
        foreach (int i in nums)
        {
            if (!set.Contains(i)) set.Add(i);
            else return true;
        }
        return false;
    }
}
