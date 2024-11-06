using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Arrays
{
    public static class SearchInsertPosition
    {
        public static int SearchInsert(int[] nums, int target)
        {
            int index = 0;
            while (index < nums.Length) {
                if (nums[index] >= target) break;
                index++;
            }
            return index;
        }
    }
}
