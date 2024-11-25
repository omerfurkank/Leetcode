using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Arrays.Easy;
public static class FindAllNumbersDisappearedInAnArray
{
    public static IList<int> FindDisappearedNumbers(int[] nums)
    {
        List<int> result = new List<int>();

        // 1. Adım: Her değeri uygun indeksine işaretlemek için negatif yap
        for (int i = 0; i < nums.Length; i++)
        {
            int index = Math.Abs(nums[i]) - 1;  // Dizideki değerlerin 1'den başladığını varsayarak
            nums[index] = Math.Abs(nums[index]) * -1;
        }

        // 2. Adım: Pozitif kalan indeksler eksik sayılara karşılık gelir
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] > 0)
                result.Add(i + 1);  // Eksik sayıyı bulup ekle
        }

        return result;
    }
    public static IList<int> FindDisappearedNumbers2(int[] nums)
    {
        bool[] visited = new bool[nums.Length];

        foreach (var num in nums) visited[num - 1] = true;

        List<int> result = new();

        for (int i = 0; i < visited.Length; i++) if (visited[i] == false) result.Add(i + 1);

        return result;
    }
}
