namespace _49_2
{
    internal class Program
    {
        static void Main(string[] args) {
            string input;
            int sum = 0;
            while (true) {
                Console.WriteLine("Enter a number or ok");
                input = Console.ReadLine();
                if (input.Equals("ok")) {
                    break;
                }
                sum += Int32.Parse(input);
            }
            Console.WriteLine("Sum = {0}", sum);
        }
    }
}