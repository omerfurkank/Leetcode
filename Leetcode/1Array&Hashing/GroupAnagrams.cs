namespace Leetcode._1Array_Hashing;

static class GroupAnagrams
{
    public static IList<IList<string>> GroupAnagrams1(string[] strs)
    {
        Dictionary<string, List<string>> groups = new();

        foreach (string word in strs)
        {
            char[] chars = word.ToCharArray();
            Array.Sort(chars);
            string key = new string(chars);

            // string key = string.Concat(word.OrderBy(c => c));

            if (!groups.ContainsKey(key))
                groups[key] = new List<string>();

            groups[key].Add(word);
        }
        return groups.Values.Select(group => (IList<string>)group).ToList();
    }
}
