namespace gol
{
    internal class Program
    {
        static void Main(string[] args) {
            int seed;
            bool running = true;
            Screen screen = new Screen();
            Console.WriteLine("Type in seed, empty for random");
            Int32.TryParse(Console.ReadLine(), out seed);
            GameOfLife game = new GameOfLife(Console.WindowWidth, Console.WindowHeight, seed);
            while (running)
            {
                screen.DrawScreen(game.GetCells());
                Thread.Sleep(250);
                game.UpdateCells();
            }
        }
    }
}