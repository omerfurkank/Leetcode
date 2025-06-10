namespace Leetcode._1Array_Hashing;

static class LongestCommonPrefix
{
    public static string LongestCommonPrefix1(string[] strs)
    {
        int minLength = strs.Min(s => s.Length);
        string prefix = "";
        for (int i = 0; i < minLength; i++)
        {
            char c = strs[0][i];
            foreach (var str in strs)
            {
                if (str[i] != c) return prefix;
            }
            prefix += c;
        }
        return prefix;
    }
    public static string LongestCommonPrefix2(string[] strs)
    {

        if (strs == null || strs.Length == 0) return "";

        string common = strs[0];

        for (int i = 1; i < strs.Length; i++)
        {
            while (!strs[i].StartsWith(common))
            {
                common = common.Substring(0, common.Length - 1);
                if (common == "") return "";
            }
        }
        return common;
    }
}