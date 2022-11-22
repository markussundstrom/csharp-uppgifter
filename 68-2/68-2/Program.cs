namespace _68_2
{
    internal class Program
    {
        static void Main(string[] args) {
            string input;
            var numbers = new List<int>();
            var distinct = new List<int>();
            Console.WriteLine("Enter numbers separated by hyphens");
            input = Console.ReadLine();
            if (!string.IsNullOrEmpty(input)) {
                foreach (string str in input.Split('-')) {
                    numbers.Add(int.Parse(str));
                }
                distinct.AddRange(numbers.Distinct());
                foreach (int i in distinct) {
                    if (numbers.IndexOf(i) != numbers.LastIndexOf(i)) {
                        Console.WriteLine("Duplicate");
                        break;
                    }
                }
            }
        }
    }
}