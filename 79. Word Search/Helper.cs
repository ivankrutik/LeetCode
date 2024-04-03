namespace _79._Word_Search
{
    internal class Helper
    {
        private class Point
        {
            public int X { get; set; }
            public int Y { get; set; }
        }

        private bool _isExist = false;
        private string? _word;

        private void isExistPath(char[][] board, int x, int y, int targetPosition, List<Point> lp)
        {
            if (targetPosition >= _word?.Length)
            {
                _isExist = true;
                return;
            }
            lp.Add(new Point { X = x, Y = y });

            if (x + 1 < board.Length && board[x + 1][y] == _word?[targetPosition] && !lp.Any(z => z.X == x + 1 && z.Y == y))
            {
                isExistPath(board, x + 1, y, targetPosition + 1, lp);
                lp.Remove(lp.FirstOrDefault(z => z.X == x + 1 && z.Y == y));
            }
            if (x - 1 >= 0 && board[x - 1][y] == _word?[targetPosition] && !lp.Any(z => z.X == x - 1 && z.Y == y))
            {
                isExistPath(board, x - 1, y, targetPosition + 1, lp);
                lp.Remove(lp.FirstOrDefault(z => z.X == x - 1 && z.Y == y));
            }
            if (y + 1 < board[x].Length && board[x][y + 1] == _word?[targetPosition] && !lp.Any(z => z.X == x && z.Y == y + 1))
            {
                isExistPath(board, x, y + 1, targetPosition + 1, lp);
                lp.Remove(lp.FirstOrDefault(z => z.X == x && z.Y == y + 1));
            }
            if (y - 1 >= 0 && board[x][y - 1] == _word?[targetPosition] && !lp.Any(z => z.X == x && z.Y == y - 1))
            {
                isExistPath(board, x, y - 1, targetPosition + 1, lp);
                lp.Remove(lp.FirstOrDefault(z => z.X == x && z.Y == y - 1));
            }
        }

        public bool Exist(char[][] board, string word)
        {
            var firstChar = word[0];
            _word = word;
            var lp = new List<Point>();
            var dictChar = new HashSet<char>();

            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board[i].Length; j++)
                {
                    if (!dictChar.Contains(board[i][j]))
                    {
                        dictChar.Add(board[i][j]);
                    }
                }
            }
            foreach (char c in word) 
            {
                if (!dictChar.Contains(c))
                {
                    return false;
                }
            }

            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board[i].Length; j++)
                {
                    if (firstChar == board[i][j] && !_isExist)
                    {
                        lp.Clear();
                        isExistPath(board, i, j, 1, lp);
                    }
                }
            }
            return _isExist;
        }
    }
}
