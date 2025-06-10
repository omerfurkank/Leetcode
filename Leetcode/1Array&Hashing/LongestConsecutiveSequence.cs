namespace Leetcode._1Array_Hashing;

public static class LongestConsecutiveSequence
{
    public static int LongestConsecutive(int[] nums) // nlogn
    {
        if (nums.Length == 0) return 0;

        Array.Sort(nums);
        List<int> list = [nums[0]];
        int result = 0;

        for (int i = 1; i < nums.Length; i++)
        {
            if (nums[i] == nums[i - 1]) continue;

            if (nums[i] - nums[i - 1] == 1)
            {
                list.Add(nums[i]);
            }
            else
            {
                result = Math.Max(result, list.Count);
                list.Clear();
                list.Add(nums[i]);
            }
        }

        return Math.Max(result, list.Count);
    }
    public static int LongestConsecutive2(int[] nums)
    {
        HashSet<int> set = [.. nums];
        int max = 0;

        foreach (var n in set)
        {
            if (!set.Contains(n - 1))
            {
                int len = 1;
                while (set.Contains(n + len)) len++;
                max = Math.Max(max, len);
            }
        }

        return max;
    }
    public static int LongestConsecutive3(int[] nums)
    {
        Dictionary<int, int> map = [];
        int maxLen = 0;

        foreach (int num in nums)
        {
            if (map.ContainsKey(num))
                continue;

            int left = map.ContainsKey(num - 1) ? map[num - 1] : 0;
            int right = map.ContainsKey(num + 1) ? map[num + 1] : 0;
            int totalLen = left + 1 + right;

            map[num] = totalLen;
            maxLen = Math.Max(maxLen, totalLen);

            if (left > 0) map[num - left] = totalLen;
            if (right > 0) map[num + right] = totalLen;
        }

        return maxLen;
    }
}