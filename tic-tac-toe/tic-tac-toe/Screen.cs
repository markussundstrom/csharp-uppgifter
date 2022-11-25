namespace tic_tac_toe
{
    public class Screen {
        private char[] _board;
        public string Message { get; set; }
        public string Error { get; set; }

        public Screen() {
            /*_board = new[] { (char)218, (char)196, (char)194, (char)196, (char)194, (char)196, (char)191, '\n',
                             (char)179, ' ', (char)179, ' ',  (char)179, ' ', (char)179, '\n',
                             (char)195, (char)196, (char)197, (char)196, (char)197, (char)196, (char)180, '\n',
                             (char)179, ' ', (char)179, ' ',  (char)179, ' ', (char)179, '\n',
                             (char)195, (char)196, (char)197, (char)196, (char)197, (char)196, (char)180,  '\n',
                             (char)179, ' ', (char)179, ' ',  (char)179, ' ', (char)179, '\n',
                             (char)192, (char)196, (char)193, (char)196, (char)193, (char)196, (char)217, '\n'};*/
            _board = new[] { '+', '-', '+', '-', '+', '-', '+', '\n',
                             '|', ' ', '|', ' ', '|', ' ', '|', '\n',
                             '+', '-', '+', '-', '+', '-', '+', '\n',
                             '|', ' ', '|', ' ', '|', ' ', '|', '\n',
                             '+', '-', '+', '-', '+', '-', '+', '\n',
                             '|', ' ', '|', ' ', '|', ' ', '|', '\n',
                             '+', '-', '+', '-', '+', '-', '+', '\n' };
        }

        public void setBoard(int[,] data) {
            for (int i = 0; i < data.GetLength(0); i++) {
                for (int j = 0; j < data.GetLength(1); j++) {
                    char tile;
                    switch (data[i,j]) {
                        case 1:
                            tile = 'X';
                            break;
                        case 2:
                            tile = 'O';
                            break;
                        default:
                            tile = ' ';
                            break;
                    }

                    _board[(2 * i + 1) + (16 * j + 8)] = tile;
                }
            }
        }
        public void drawScreen() {
            Console.Clear();
            //Console.OutputEncoding = System.Text.Encoding.GetEncoding(437);
            Console.WriteLine(_board);
            Console.WriteLine(Error);
            Console.WriteLine(Message);
            Error = "";
            Message = "";

        }
    }
}
