namespace _56_4
{
    internal class Program
    {
        static void Main(string[] args) {
            var numbers = new List<int>();
            string input;
            var distinct = new List<int>();
            var unique = new List<int>();
            while (true) {
                Console.WriteLine("Enter number");
                input = Console.ReadLine();
                if (input == "Quit") {
                    break;
                } else {
                    numbers.Add(Int32.Parse(input));
                }
            }
            distinct.AddRange(numbers.Distinct());
            foreach (int number in distinct) {
                if (numbers.IndexOf(number) == numbers.LastIndexOf(number)) {
                    unique.Add(number);
                }
            }
            Console.WriteLine("Unique numbers: ");
            foreach (int number in unique) {
                Console.WriteLine(number);
            }

        }
    }
}