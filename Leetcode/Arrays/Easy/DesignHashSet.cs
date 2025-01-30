using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Arrays.Easy;
public  class DesignHashSet
{
    private readonly bool[] data;

    public DesignHashSet()
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
