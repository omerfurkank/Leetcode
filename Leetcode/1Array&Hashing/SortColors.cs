namespace Leetcode._1Array_Hashing;

public static class SortColors
{
    public static void SortColors1(int[] nums)
    {
        int low = 0, mid = 0, high = nums.Length - 1;

        while (mid <= high)
        {
            if (nums[mid] == 0)
                (nums[low++], nums[mid++]) = (nums[mid], nums[low]);
            else if (nums[mid] == 1)
                mid++;
            else
                (nums[mid], nums[high--]) = (nums[high], nums[mid]);
        }
    }
}
