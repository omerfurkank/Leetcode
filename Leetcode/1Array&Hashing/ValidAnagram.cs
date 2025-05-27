namespace Leetcode._1Array_Hashing;

static class ValidAnagram
{
    public static bool IsAnagram1(string s, string t)
    {
        if (s.Length != t.Length) return false;
        int[] arr = new int[26];
        for (int i = 0; i < s.Length; i++)
        {
            arr[s[i] - 'a']++;
            arr[t[i] - 'a']--;
        }
        foreach (var a in arr) if (a != 0) return false;
        return true;
    }
    public static bool IsAnagram2(string s, string t)
    {
        if (s.Length != t.Length) return false;
        return String.Concat(s.OrderBy(c => c)) == String.Concat(t.OrderBy(c => c));
    }
}

