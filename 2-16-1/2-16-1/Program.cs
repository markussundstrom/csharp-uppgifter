namespace _2_16_1
{
    internal class Program
    {
        static void Main(string[] args) {
            StopWatch stopwatch = new StopWatch();
            bool running = true;
            Console.WriteLine("1 = Start\n2 = Stop\nS = Show time\nQ = Quit");
            while (running) {
                switch (Console.ReadKey(true).KeyChar) {
                    case '1':
                        try {
                            stopwatch.Start();
                        }
                        catch (Exception e) {
                            Console.WriteLine(e.Message);
                        }
                        break;
                    case '2':
                        try {
                            stopwatch.Stop();
                        }
                        catch (Exception e) {
                            Console.WriteLine(e.Message);
                        }
                        break;
                    case 's':
                        try {
                            Console.WriteLine(stopwatch.ShowTime());
                        }
                        catch (Exception e) {
                            Console.WriteLine(e.Message);
                        }
                        break;
                    case 'S':
                        try {
                            stopwatch.ShowTime();
                        }
                        catch (Exception e) {
                            Console.WriteLine(e.Message);
                        }
                        break;
                    case 'q':
                        running = false;
                        break;
                    case 'Q':
                        running = false;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}