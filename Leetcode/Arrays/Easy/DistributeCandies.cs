using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Arrays.Easy;
public static class DistributeCandies
{
    public static int DistributeCandies1(int[] candyType)
    {
        int uniqueCandies = candyType.ToHashSet().Count;
        int canEat = candyType.Length/2;

        return uniqueCandies > canEat ? canEat : uniqueCandies;
    }
}
