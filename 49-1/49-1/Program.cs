namespace _49_1
{
    internal class Program
    {
        static void Main(string[] args) {
            int divisibleby3 = 0;
            for (int i = 1; i <= 100; i++) {
                if (i % 3 == 0) {
                    divisibleby3++;
                }
            }
            Console.WriteLine("{0} numbers divisible by 3", divisibleby3);
        }
    }
}