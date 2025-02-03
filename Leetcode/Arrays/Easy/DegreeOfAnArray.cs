using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Arrays.Easy;
public static class DegreeOfAnArray
{
    public static int FindShortestSubArray(int[] nums)
    {
        Dictionary<int, int> frequency = new();
        Dictionary<int, int> firstIndex = new();
        Dictionary<int, int> lastIndex = new();

        int degree = 0;
        int result = int.MaxValue;

        for (int i = 0; i < nums.Length; i++)
        {
            int num = nums[i];

            if (!firstIndex.ContainsKey(num))
            {
                firstIndex[num] = i;
            }

            frequency[num] = frequency.GetValueOrDefault(num, 0) + 1;
            lastIndex[num] = i;

            if (frequency[num] > degree)
            {
                degree = frequency[num];
            }
        }

        foreach (var num in frequency.Keys)
        {
            if (frequency[num] == degree)
            {
                int length = lastIndex[num] - firstIndex[num] + 1;
                result = Math.Min(result, length);
            }
        }

        return result;
    }
    public static int FindShortestSubArray2(int[] nums)
    {
        // Her sayının bilgilerini saklamak için sözlük
        var map = new Dictionary<int, MySet>();

        // Maksimum frekans ve minimum mesafeyi tutmak için değişkenler
        int maxorder = 0, mindist = 0, n = nums.Length;

        // Diziyi dolaşıyoruz
        for (int i = 0; i < n; i++)
        {
            if (!map.ContainsKey(nums[i]))
            {
                // Eğer sayı ilk kez görülüyorsa, MySet oluşturup ekliyoruz
                map.Add(nums[i], new MySet(1, i, 0));
            }
            else
            {
                // Sayı daha önce görülmüş, frekansı ve mesafeyi güncelliyoruz
                var set = map[nums[i]];
                set.occur++; // Frekansı artır
                int tempIndex = set.lastIndex; // Önceki son indeks
                set.lastIndex = i; // Yeni son indeks
                set.dist += (set.lastIndex - tempIndex); // Mesafeyi güncelle

                // Eğer frekans daha büyükse, maksimum frekansı ve mesafeyi güncelle
                if (set.occur > maxorder)
                {
                    maxorder = set.occur;
                    mindist = set.dist;
                }
                // Eğer frekans eşitse, mesafeyi kontrol et
                else if (set.occur == maxorder && set.dist < mindist)
                {
                    mindist = set.dist;
                }
            }
        }

        // Son olarak, mesafeye 1 ekleyerek en kısa alt diziyi döndürüyoruz
        return mindist + 1;
    }
    public class MySet
    {
        public int occur;  // Sayının dizideki frekansı
        public int lastIndex;  // Sayının son görüldüğü indeks
        public int dist;  // Sayının tüm tekrarları arasındaki mesafe toplamı

        public MySet(int o, int l, int d)
        {
            occur = o;
            lastIndex = l;
            dist = d;
        }
    }
}
