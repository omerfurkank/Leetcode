namespace Leetcode._1Array_Hashing;

public class MyHashSet
{

    private readonly bool[] data;

    public MyHashSet()
    {
        data = new bool[1000001];
    }

    public void Add(int key)
    {
        data[key] = true;
    }

    public void Remove(int key)
    {
        data[key] = false;
    }

    public bool Contains(int key)
    {
        return data[key];
    }
}
public class MyHashMap
{
    private Dictionary<int, int> map;

    public MyHashMap()
    {
        map = new Dictionary<int, int>();
    }

    public void Put(int key, int value)
    {
        map[key] = value; // Eğer varsa günceller, yoksa ekler
    }

    public int Get(int key)
    {
        return map.ContainsKey(key) ? map[key] : -1; // Anahtar varsa değeri döndür, yoksa -1 döndür
    }

    public void Remove(int key)
    {
        if (map.ContainsKey(key))
        {
            map.Remove(key);
        }
    }
}