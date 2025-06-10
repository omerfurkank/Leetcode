namespace Leetcode._1Array_Hashing;

static class MajorityElement
{
    public static int MajorityElement1(int[] nums)
    {
        Dictionary<int, int> dict = new();
        for (int i = 0; i < nums.Length; i++)
        {
            if (!dict.ContainsKey(nums[i])) dict.Add(nums[i], 1);
            else dict[nums[i]]++;
        }
        return dict.OrderByDescending(p => p.Value).First().Key;
    }
    public static int MajorityElement2(int[] nums)
    {// sayı yarıdan fazla olduğu için kazanan kalır mantığı
        int count = 0, candidate = 0;
        foreach (int num in nums)
        {
            if (count == 0) candidate = num;

            count += (num == candidate) ? 1 : -1;
        }
        return candidate;
    }
}
