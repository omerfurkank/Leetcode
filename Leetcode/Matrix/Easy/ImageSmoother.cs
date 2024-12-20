using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leetcode.Matrix.Easy;
public static class ImageSmoother
{
    public static int[][] ImageSmoother1(int[][] img)
    {
        int rows = img.Length;
        int cols = img[0].Length;

        // Yeni matris oluştur
        int[][] result = new int[rows][];
        for (int i = 0; i < rows; i++)
            result[i] = new int[cols];

        // Tüm hücreleri dolaş
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                int sum = 0;
                int count = 0;

                // Komşuları kontrol et (kendisi dahil)
                for (int x = i - 1; x <= i + 1; x++)
                {
                    for (int y = j - 1; y <= j + 1; y++)
                    {
                        // Geçerli bir hücre mi? (matris sınırları içinde)
                        if (x >= 0 && x < rows && y >= 0 && y < cols)
                        {
                            sum += img[x][y];
                            count++;
                        }
                    }
                }

                // Yeni değeri hesapla
                result[i][j] = sum / count;
            }
        }

        return result;
    }
}
