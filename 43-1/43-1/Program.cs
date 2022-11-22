namespace _43_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input;
            int number;
            Console.WriteLine("Skriv ett nummer mellan 1 och 10");
            input = Console.ReadLine();
            number = Int32.Parse(input);
            Console.WriteLine(number);
            if (number >= 1 && number <= 10) {
                Console.WriteLine("Valid");
            } else {
                Console.WriteLine("Invalid");
            }
        }
    }
}