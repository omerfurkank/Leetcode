using System.Linq;

namespace Leetcode.Arrays.Easy;

public static class ContainsDuplicateII
{
    public static bool ContainsNearbyDuplicate1(int[] nums, int k)
    {
        Dictionary<int, int> map = new();

        for (int i = 0; i < nums.Length; i++)
            if (map.ContainsKey(nums[i]))
            {
                if (i - map[nums[i]] <= k) return true;
                map[nums[i]] = i;
            }
            else map.Add(nums[i], i);

        return false;
    }
    public static bool ContainsNearbyDuplicate2(int[] nums, int k)
    {
        HashSet<int> set = new();
        int left = 0, right = 0;

        while (right < nums.Length)
        {     
            if (right - left > k)
            {
                set.Remove(nums[left]);
                left++;
            }

            if (!set.Add(nums[right]))
                return true;

            right++;
        }
        return false;
    }
}
