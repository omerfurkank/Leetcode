namespace Leetcode._1Array_Hashing;

public class SortAnArray
{
    public int[] SortArray(int[] nums)
    {
        QuickSort(nums, 0, nums.Length - 1);
        return nums;
    }
    void QuickSort(int[] arr, int left, int right)
    {
        if (left < right)
        {
            int pivotIndex = Partition(arr, left, right);
            QuickSort(arr, left, pivotIndex - 1);
            QuickSort(arr, pivotIndex + 1, right);
        }
    }
    Random rand = new();
    int Partition(int[] arr, int left, int right)
    {
        int randomIndex = rand.Next(left, right + 1);
        (arr[randomIndex], arr[right]) = (arr[right], arr[randomIndex]); // Rastgele pivot sona alınır

        int pivot = arr[right];
        int i = left - 1;

        for (int j = left; j < right; j++)
            if (arr[j] < pivot)
                (arr[++i], arr[j]) = (arr[j], arr[i]);

        (arr[i + 1], arr[right]) = (arr[right], arr[i + 1]);
        return i + 1;
    }
}
