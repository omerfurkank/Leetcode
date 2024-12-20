namespace Leetcode.TwoPointers.Easy;

public static class IntersectionOfTwoArraysII
{
    public static int[] Intersect1(int[] nums1, int[] nums2)
    {
        List<int> listNums1 = nums1.ToList();
        List<int> interceptList = new();

        foreach (var item in nums2)
            if (listNums1.Contains(item))
            {
                listNums1.Remove(item);
                interceptList.Add(item);
            }

        return interceptList.ToArray();
    }
    public static int[] Intersect2(int[] nums1, int[] nums2)
    {
        int[] d1 = new int[1001];
        for (int i = 0; i < nums1.Length; i++)
            d1[nums1[i]]++;

        List<int> l = new List<int>();
        for (int i = 0; i < nums2.Length; i++)
        {
            int n = nums2[i];
            if (d1[n] > 0)
            {
                d1[n]--;
                l.Add(n);
            }
        }
        int[] res = l.ToArray();

        return res;

    }
}
