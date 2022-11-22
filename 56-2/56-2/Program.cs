namespace _56_2
{
    internal class Program
    {
        static void Main(string[] args) {
            string input;
            char[] nameArr;
            char[] revArr;
            Console.WriteLine("Enter your name");
            input = Console.ReadLine();
            nameArr = input.ToArray();
            Array.Reverse(nameArr);
            Console.WriteLine(nameArr);
        }
    }
}