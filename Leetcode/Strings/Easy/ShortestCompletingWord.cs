using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Strings.Easy;
public static class ShortestCompletingWord
{
    public static string ShortestCompletingWord3(string licensePlate, string[] words)
    {
        int[] count = new int[26];
        foreach (char c in licensePlate)
        {
            int val = GetValidChar(c);
            if (val == -1) continue;
            count[val]++;
        }
        string candidate = "";
        foreach (string word in words)
        {
            int[] count2 = new int[26];
            if (candidate != "" && candidate.Length <= word.Length) continue;
            foreach (char c in word)
            {
                int val = GetValidChar(c);
                if (val == -1) continue;
                count2[val]++;
            }
            bool match = true;
            for (int i = 0; i < 26; i++)
            {
                if (count2[i] >= count[i]) continue;
                match = false;
                break;
            }
            if (!match) continue;
            candidate = word;
        }

        return candidate;
    }

    public static int GetValidChar(char c)
    {
        int val = (c - 'a');
        if (val >= 0 && val < 26)
        {
            return val;
        }
        val = (c - 'A');
        if (val >= 0 && val < 26)
        {
            return val;
        }
        return -1;
    }
    public static string ShortestCompletingWord4(string licensePlate, string[] words)
    {
        Dictionary<char, int> initialMap = new();
        List<string> validWords = new();

        foreach (char ch in licensePlate)
        {
            char lowerChar = char.ToLower(ch);
            if (char.IsLetter(lowerChar))
            {
                if (!initialMap.ContainsKey(lowerChar)) initialMap[lowerChar] = 0;
                initialMap[lowerChar]++;
            }
        }

        foreach (string word in words)
        {
            Dictionary<char, int> currentMap = new(initialMap);

            foreach (char ch in word) if (currentMap.ContainsKey(ch)) currentMap[ch]--;

            if (currentMap.All(kvp => kvp.Value <= 0)) validWords.Add(word);
        }
        return validWords.OrderBy(word => word.Length).First();
    }

    public static string ShortestCompletingWord1(string licensePlate, string[] words)
    {
        return words
            .Where(word => {
                int[] target = new int[26], wordCount = new int[26];

                foreach (char c in licensePlate.ToLower())
                    if (char.IsLetter(c)) target[c - 'a']++;

                foreach (char c in word.ToLower())
                    wordCount[c - 'a']++;

                return target.Zip(wordCount, (t, w) => w >= t).All(x => x);
            })
            .OrderBy(word => word.Length)
            .First();
    }
    public static string ShortestCompletingWord2(string licensePlate, string[] words)
    {
        string letters = new string(licensePlate.ToLower().Where(char.IsLetter).ToArray());

        return words
            .Where(word => letters.All(c => word.Count(x => x == c) >= letters.Count(y => y == c)))
            .OrderBy(word => word.Length)
            .First();
    }
}
