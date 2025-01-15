using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Arrays.Easy;
public static class BaseballGame
{
    public static int CalPoints(string[] operations)
    {
        int sum = 0;
        List<int> points = new List<int>();
        for (int i = 0; i < operations.Length; i++) {
            if (operations[i] == "C") points.RemoveAt(points.Count - 1);
            else if (operations[i] == "D") points.Add((points[points.Count - 1]) * 2);
            else if (operations[i] == "+") points.Add(points[points.Count - 1] + points[points.Count - 2]);
            else points.Add(int.Parse(operations[i]));
        }
        foreach (int i in points) sum += i;
        return sum;
    }
}
