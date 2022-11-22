namespace _49_3
{
    internal class Program
    {
        static void Main(string[] args) {
            int number; 
            int factorial = 1;
            Console.WriteLine("Enter a number");
            number = Int32.Parse(Console.ReadLine());
            for (int i = number; i > 0; i--) {
                factorial *= i;
            }
            Console.WriteLine("{0}! = {1}", number, factorial);
        }
    }
}