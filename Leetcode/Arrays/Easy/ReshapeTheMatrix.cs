using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Arrays.Easy;

public static class ReshapeTheMatrix
{
    public static int[][] MatrixReshape(int[][] mat, int r, int c)
    {
        bool possible = mat.Length * mat[0].Length  == r*c;
        if (!possible) return mat;

        int[][] result = new int[r][];
        List<int> numbers = new();

        for (int i = 0; i < mat.Length; i++)
            for (int j = 0; j < mat[i].Length; j++) numbers.Add(mat[i][j]);

        int k = 0;
        for (int i = 0;i<r; i++)
        {
            result[i] = new int[c];
            for(int j = 0;j < c; j++)
            {
                result[i][j] = numbers[k];
                k++;
            }
        }
        return result;
}
}
