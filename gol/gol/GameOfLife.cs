namespace gol
{
    public class GameOfLife 
    {
        private bool[,] _cells;

        public GameOfLife(int sizeX, int sizeY, int seed) 
        {
            Random random = new Random(seed);
            _cells = new bool[sizeX, sizeY];
            for (int i = 0; i < sizeX; i++)
            {
                for (int j = 0; j < sizeY; j++)
                {
                    _cells[i, j] = (random.Next(2) == 0) ? true : false;
                }
            }
        }

        public void UpdateCells()
        {
            bool[,] nextgen = new bool[_cells.GetLength(0), _cells.GetLength(1)];

            for (int i = 0; i < _cells.GetLength(0); i++)
            {
                for (int j = 0; j < _cells.GetLength(1); j++)
                {
                    int neighbors = GetNumNeighbors(i, j);
                    if (neighbors == 3)
                    {
                        nextgen[i, j] = true;
                    }
                    else if (neighbors == 2 && _cells[i, j])
                    {
                        nextgen[i, j] = true;
                    }
                    else
                    {
                        nextgen[i, j] = false;
                    }
                }
            }
            _cells = nextgen;
        }

        private int GetNumNeighbors(int x, int y) 
        {
            int n = 0;
            for (int i = x - 1; i <= x + 1; i++)
            {
                if (i < 0 || i >= _cells.GetLength(0))
                {
                    continue;
                }
                for (int j = y - 1; j <= y + 1; j++)
                {
                    if (j < 0 || j >= _cells.GetLength(1))
                    {
                        continue;
                    }
                    if (_cells[i, j])
                    {
                        n++;
                    }
                }
            }
            if (_cells[x, y])
            {
                n--;
            }
            return n;
        }
        public bool[,] GetCells() 
        {
            return (bool[,])_cells;
        }
    }
}