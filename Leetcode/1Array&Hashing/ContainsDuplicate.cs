namespace Leetcode._1Array_Hashing;

static class ContainsDuplicate
{
    public static bool ContainsDuplicate1(int[] nums)
    {
        HashSet<int> set = new();
        foreach (var num in nums) if (!set.Add(num)) return true;
        return false;
    }
}
