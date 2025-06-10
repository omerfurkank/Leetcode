namespace Leetcode._1Array_Hashing;

public static class ValidSudoku
{
    public static bool IsValidSudoku(char[][] board)
    {
        HashSet<char>[] rows = new HashSet<char>[9];
        HashSet<char>[] cols = new HashSet<char>[9];
        HashSet<char>[] boxes = new HashSet<char>[9];
        //var rows = new Dictionary<int, HashSet<char>>();
        //var cols = new Dictionary<int, HashSet<char>>();
        //var boxes = new Dictionary<int, HashSet<char>>();
        for (int i = 0; i < 9; i++)
        {
            rows[i] = new HashSet<char>();
            cols[i] = new HashSet<char>();
            boxes[i] = new HashSet<char>();
        }

        for (int i = 0; i < 9; i++)
        {
            for (int j = 0; j < 9; j++)
            {
                char val = board[i][j];
                if (val == '.') continue;

                int boxIndex = (i / 3) * 3 + (j / 3);

                if (!rows[i].Add(val) || !cols[j].Add(val) || !boxes[boxIndex].Add(val))
                    return false;
            }
        }

        return true;
    }
}
