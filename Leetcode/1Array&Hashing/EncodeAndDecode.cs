using System.Text;

namespace Leetcode._1Array_Hashing;

public static class EncodeAndDecode
{

    public static string Encode(IList<string> strs)
    {
        var sb = new StringBuilder();
        foreach (var s in strs)
            sb.Append(s.Length).Append('#').Append(s);

        return sb.ToString();
    }

    public static List<string> Decode(string s)
    {
        List<string> result = new();

        for (int i = 0; i < s.Length;)
        {
            int j = i;
            while (s[j] != '#') j++; // uzunluğu alacağımız yere kadar git

            int len = int.Parse(s.Substring(i, j - i)); // i ile j arası = uzunluk
            string str = s.Substring(j + 1, len);       // içerik

            result.Add(str);
            i = j + 1 + len; // bir sonraki string'in başına geç
        }

        return result;
    }
}