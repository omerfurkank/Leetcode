using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Strings.Medium;

public static class LongestSubstringWithoutRepeatingCharacters
{
    public static int LengthOfLongestSubstring(string s)
    {
        HashSet<char> set = new();
        int left = 0, maxLength = 0;

        for (int right = 0; right < s.Length; right++)
        {
            while (set.Contains(s[right]))
            {
                set.Remove(s[left]);
                left++;
            }
            set.Add(s[right]);
            maxLength = Math.Max(maxLength, right - left + 1);
        }

        return maxLength;
    }
    public static int LengthOfLongestSubstring2(string s)
    {
        Dictionary<char, int> dict = new();
        int left = 0, maxLength = 0;

        for (int right = 0; right < s.Length; right++)
        {
            if (dict.ContainsKey(s[right]))
            {
                left = Math.Max(dict[s[right]] + 1, left);
            }
            dict[s[right]] = right;
            maxLength = Math.Max(maxLength, right - left + 1);
        }

        return maxLength;
    }
    public static int LengthOfLongestSubstring3(string s)
    {
        int maxLen = 0;
        int left = 0;
        Span<int> lastIndex = stackalloc int[256];
        for (int i = 0; i < lastIndex.Length; i++)
        {
            lastIndex[i] = -1;
        }

        for (int right = 0; right < s.Length; right++)
        {
            int index = s[right];
            if (lastIndex[index] >= left)
            {
                left = lastIndex[index] + 1;
            }

            lastIndex[index] = right;
            maxLen = Math.Max(maxLen, right - left + 1);
        }

        return maxLen;
    }
}
