using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Strings.Easy;
public static class KeyboardRow
{
    public static string[] FindWords(string[] words)
    {
        HashSet<char> row1 = "qwertyuiopQWERTYUIOP".ToHashSet();
        HashSet<char> row2 = ['a', 's', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'A', 'S', 'D', 'F', 'G', 'H', 'J', 'K', 'L'];
        HashSet<char> row3 = ['z', 'x', 'c', 'v', 'b', 'n', 'm', 'Z', 'X', 'C', 'V', 'B', 'N', 'M'];
        List<string> result = new();

        foreach (string word in words)
        {
            HashSet<char> currentRow = row3;           
            bool exitLoop = false;

            if (row1.Contains(word[0])) currentRow = row1;
            else if (row2.Contains(word[0])) currentRow = row2;

            for (int i = 1; i < word.Length; i++)
            {
                if (!currentRow.Contains(word[i]))
                {
                    exitLoop = true;
                    break; 
                }
            }
            if(!exitLoop) result.Add(word);
            //if (word.All(c => currentRow.Contains(c)))
            //{
            //    result.Add(word);
            //}

        }
        return result.ToArray();
    }
}
