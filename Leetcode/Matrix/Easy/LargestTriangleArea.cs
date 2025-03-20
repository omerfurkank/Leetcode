using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Matrix.Easy;
public static class LargestTriangleArea
{
    public static double LargestTriangleArea1(int[][] points)
    {
        int n = points.Length;
        double maxArea = 0.0;

        // Tüm üçlü kombinasyonları deneyelim
        for (int i = 0; i < n; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                for (int k = j + 1; k < n; k++)
                {
                    // Üçgen alanını hesapla
                    double area = CalculateArea(points[i], points[j], points[k]);
                    // En büyük alanı güncelle
                    maxArea = Math.Max(maxArea, area);
                }
            }
        }
        return maxArea;
    }

    // Üç noktanın oluşturduğu üçgenin alanını hesaplayan fonksiyon
    private static double CalculateArea(int[] p1, int[] p2, int[] p3)
    {
        return 0.5 * Math.Abs(
            p1[0] * (p2[1] - p3[1]) +
            p2[0] * (p3[1] - p1[1]) +
            p3[0] * (p1[1] - p2[1])
        );
    }
}
