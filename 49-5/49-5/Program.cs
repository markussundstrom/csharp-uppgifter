namespace _49_5
{
    internal class Program
    {
        static void Main(string[] args) {
            string input;
            int max = 0;
            Console.WriteLine("Type a comma separated list of numbers");
            input = Console.ReadLine();
            string[] numStrings = input.Split(",");
            foreach (string str in numStrings) {
                max = (Int32.Parse(str) > max) ? Int32.Parse(str) : max;
            }
            Console.WriteLine("Max = {0}", max);
        }
    }
}