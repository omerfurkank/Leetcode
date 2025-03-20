using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Strings.Easy;
public static class MostCommonWord
{
    public static string MostCommonWord1(string paragraph, string[] banned)
    {
        var wordCount = new Dictionary<string, int>();
        var bannedWords = new HashSet<string>(banned);
        var word = "";
        for (int i = 0; i < paragraph.Length; i++)
        {
            char t = char.ToLowerInvariant(paragraph[i]);
            if (char.IsLetter(t))
            {
                word += t;
                continue;
            }
            if (bannedWords.Contains(word))
            {
                word = "";
                continue;
            }
            else if (word.Length > 0)
            {
                wordCount[word] = wordCount.GetValueOrDefault(word, 0) + 1;
                word = "";
            }
        }
        if (!bannedWords.Contains(word) && word.Length > 0)
        {
            wordCount[word] = wordCount.GetValueOrDefault(word, 0) + 1;
        }

        return wordCount.OrderByDescending(x => x.Value).First().Key;
    }
    public static string MostCommonWord2(string paragraph, string[] banned)
    {
        char[] delimeters = { ' ', '!', '?', '\'', ',', ';', '.' };
        var words = paragraph.Split(delimeters, StringSplitOptions.RemoveEmptyEntries);
        var dict = new Dictionary<string, int>();
        var bannedSet = new HashSet<string>(banned);
        foreach (var word in words)
        {
            var normWord = word.ToLower();
            if (!bannedSet.Contains(normWord))
            {
                dict[normWord] = dict.GetValueOrDefault(normWord) + 1;
            }
        }

        var mostCommon = "";
        foreach (var pair in dict)
        {
            if (mostCommon == "")
            {
                mostCommon = pair.Key;
            }
            else if (dict[mostCommon] < pair.Value)
            {
                mostCommon = pair.Key;
            }
        }

        return mostCommon;
    }
}
