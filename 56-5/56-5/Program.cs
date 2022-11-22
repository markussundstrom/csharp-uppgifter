namespace _56_5
{
    internal class Program
    {
        static void Main(string[] args) {
            string input;
            var numbers = new List<int>();
            int[] numarray;
            while (true) {
                numbers.Clear();
                Console.WriteLine("Supply a list of at least 5 comma separated numbers");
                input = Console.ReadLine();
                foreach (string str in input.Split(',')) { 
                    numbers.Add(Int32.Parse(str)); 
                }
                if (numbers.Count >= 5) {
                    break;
                } else {
                    Console.WriteLine("Invalid list, try again");
                }
            }
            Console.WriteLine("3 lowest numbers:");
            numbers.Sort();
            for (int i = 0; i < 3; i++) {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}