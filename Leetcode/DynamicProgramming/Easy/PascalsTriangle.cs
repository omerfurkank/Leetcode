using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.DynamicProgramming.Easy;
public static class PascalsTriangle
{
    public static IList<IList<int>> Generate(int numRows)
    {
        var result = new List<IList<int>>();

        for (int i = 0; i < numRows; i++)
        {
            List<int> listRow = new() { 1 };

            for (int j = 1; j < i; j++) listRow.Add(result[i - 1][j - 1] + result[i - 1][j]);
            if (i > 0) listRow.Add(1);

            result.Add(listRow);
        }
        return result;
    }
}
