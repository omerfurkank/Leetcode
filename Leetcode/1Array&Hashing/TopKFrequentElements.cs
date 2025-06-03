namespace Leetcode._1Array_Hashing;

public static class TopKFrequentElements
{
    public static int[] TopKFrequent(int[] nums, int k) //o(nlogn)
    {
        Dictionary<int, int> dict = new();

        foreach (var n in nums)
            dict[n] = dict.GetValueOrDefault(n, 0) + 1;
        //for (int i = 0; i < nums.Length; i++)
        //{
        //    if (!dict.ContainsKey(nums[i])) dict.Add(nums[i], 1);
        //    else dict[nums[i]]++;
        //}
        return dict.OrderByDescending(d => d.Value).Take(k).Select(d => d.Key).ToArray(); 
    }
    public static int[] TopKFrequent2(int[] nums, int k)//bucketsort o(n)
    {
        Dictionary<int, int> freqMap = new ();
        foreach (var num in nums)
            freqMap[num] = freqMap.GetValueOrDefault(num, 0) + 1;

        List<int>[] bucket = new List<int>[nums.Length + 1];
        foreach (var (num, freq) in freqMap)
        {
            bucket[freq] ??= new List<int>();
            bucket[freq].Add(num);
        }

        var result = new List<int>();
        for (int i = bucket.Length - 1; i >= 0 && result.Count < k; i--)
            if (bucket[i] != null)
                result.AddRange(bucket[i]);

        return result.Take(k).ToArray(); 
    }
}
