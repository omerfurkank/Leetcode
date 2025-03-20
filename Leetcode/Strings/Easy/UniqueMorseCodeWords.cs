using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Strings.Easy;
public static class UniqueMorseCodeWords
{
    public static int UniqueMorseRepresentations(string[] words)
    {
        string[] morseCodes = {".-","-...","-.-.","-..",".","..-.","--.","....","..",".---","-.-",".-..",
            "--","-.","---",".--.","--.-",".-.","...","-","..-","...-",".--","-..-","-.--","--.."};

        HashSet<string> uniqueTransformations = new HashSet<string>();

        foreach (string word in words)
        {
            string morseWord = "";
            foreach (char c in word)
            {
                morseWord += morseCodes[c - 'a']; // Harfi Morse karşılığına çevir
            }
            uniqueTransformations.Add(morseWord); // HashSet ile benzersiz hale getir
        }

        return uniqueTransformations.Count; // Farklı Morse kodlarının sayısı
    }
    public static int UniqueMorseRepresentations2(string[] words)
    {
        string[] morseCodes = {".-","-...","-.-.","-..",".","..-.","--.","....","..",".---","-.-",".-..",
            "--","-.","---",".--.","--.-",".-.","...","-","..-","...-",".--","-..-","-.--","--.."};

        return words.Select(word => string.Concat(word.Select(c => morseCodes[c - 'a']))).ToHashSet().Count;
    }
}
