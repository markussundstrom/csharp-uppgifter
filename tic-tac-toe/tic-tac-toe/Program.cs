using System.ComponentModel;

namespace tic_tac_toe
{
    internal class Program
    {
        static void Main(string[] args) {
            TicTacToe game;
            Screen screen = new Screen();
            bool play = true;
            string input;
            int x, y;
            char key;

            while (play) {
                game = new TicTacToe();
                while (!game.GameEnded) {
                    screen.setBoard((int[,])game.getBoard());
                    screen.Message = $"Player {game.CurrentPlayer}\'s move";
                    screen.drawScreen();
                    input = Console.ReadLine();
                    try {
                        x = int.Parse(input.Split(',')[0]);
                        y = int.Parse(input.Split(',')[1]);
                    } catch {
                        screen.Error = "Invalid input";
                        continue;
                    }
                    try {
                        game.setSquare(x, y);
                    } catch (Exception e) {
                        screen.Error = e.Message;
                        continue;
                    }
                }
                if (game.WinningPlayer == 0) {
                    screen.Message = "Draw!";
                } else {
                    screen.Message = $"Player {game.WinningPlayer} wins!";
                }
                screen.drawScreen();
                Console.WriteLine("Play again? (y/n)");
                while (true) {
                    key = Console.ReadKey(true).KeyChar;
                    if (key == 'y') {
                        break;
                    } else if (key == 'n') {
                        play = false;
                        break;
                    }
                }
            }
            Console.Clear();
            Console.WriteLine("The only winning move!");
            Thread.Sleep(1000);
        }
    }
}