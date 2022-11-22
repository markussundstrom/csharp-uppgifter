namespace _49_4
{
    internal class Program
    {
        static void Main(string[] args) {
            var random = new Random();
            int randomNum = random.Next(1, 10);
            int guess;
            bool correct = false;
            for (int i = 0; i < 4; i++) {
                Console.WriteLine("Make a guess");
                guess = Int32.Parse(Console.ReadLine());
                if (guess == randomNum) {
                    correct = true;
                    break;
                }
            }
            Console.WriteLine("You {0}!", (correct) ? "won" : "lost");
        }
    }
}