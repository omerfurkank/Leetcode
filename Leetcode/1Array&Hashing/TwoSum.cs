namespace Leetcode._1Array_Hashing;

public class TwoSum
{
    public int[] TwoSum1(int[] nums, int target)
    {
        Dictionary<int, int> dict = new();
        for (int i = 0; i < nums.Length; i++)
        {
            if (dict.ContainsKey(target - nums[i])) return [i, dict[target - nums[i]]];
            else if (!dict.ContainsKey(nums[i])) dict.Add(nums[i], i);

        }
        return [0, 0];
    }
}