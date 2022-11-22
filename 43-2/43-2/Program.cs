namespace _43_2
{
    internal class Program
    {
        static void Main(string[] args) {
            string input;
            int number1, number2;
            Console.WriteLine("Skriv ett nummer");
            input = Console.ReadLine(); 
            number1 = Int32.Parse(input);
            Console.WriteLine("Skriv ett till nummer");
            input = Console.ReadLine(); 
            number2 = Int32.Parse(input);
            Console.WriteLine("Det största talet är {0}", (number1 > number2) ? number1 : number2);
        }
    }
}