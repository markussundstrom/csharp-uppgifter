namespace tic_tac_toe
{
    public class TicTacToe {
        private int[,] _board = new int[3, 3] { { 0, 0, 0 },
                                               { 0, 0, 0 },
                                               { 0, 0, 0 }}; 
        public int CurrentPlayer { get; private set; } = 1; 
        public bool GameEnded = false;
        public int WinningPlayer { get; private set; } = 0;

        public Array getBoard() {
            return (int[,])_board.Clone() ;
        }

        public void setSquare(int x, int y) {
            if ((0 > x || x > 2) || (0 > y || y > 2)) {
                throw new ArgumentException("Invalid coordinate");
            }

            if (_board[x,y] != 0) {
                throw new InvalidOperationException("Unable to make move, try again");
            } 
            
            _board[x,y] = CurrentPlayer;

            int[] winnerCheck = new int[4]; // cols, rows, diag, reverse diag
            for (int i = 0; i < _board.GetLength(0); i++) {
                if (_board[x,i] == CurrentPlayer) {
                    winnerCheck[0]++;
                }
                if (_board[i,y] == CurrentPlayer) {
                    winnerCheck[1]++;
                }
                if (_board[i,i] == CurrentPlayer) {
                    winnerCheck[2]++;
                }
                if (_board[i,_board.GetLength(1) - (i + 1)] == CurrentPlayer) {
                    winnerCheck[3]++;
                }
            }
            if (winnerCheck.Contains(3)) {
                WinningPlayer = CurrentPlayer;
                GameEnded = true;
                return;
            }
            GameEnded = true;
            for (int i = 0; i < _board.GetLength(0); i++) {
                for (int j = 0; j < _board.GetLength(1); j++) {
                    if (_board[i, j] == 0) {
                        GameEnded = false;
                    }
                }
            }
            if (GameEnded) {
                return;
            }

            CurrentPlayer = (CurrentPlayer == 1) ? 2 : 1;
        }
    }
}