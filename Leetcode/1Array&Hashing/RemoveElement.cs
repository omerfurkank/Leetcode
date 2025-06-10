namespace Leetcode._1Array_Hashing;

static class RemoveElement
{
    public static int RemoveElement1(int[] nums, int val)
    {
        int unique = 0;
        for (int i = 0; i < nums.Length; i++) if (nums[i] != val) nums[unique++] = nums[i];
        return unique;
    }
}