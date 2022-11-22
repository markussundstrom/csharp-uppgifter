namespace _68_1
{
    internal class Program
    {
        static void Main(string[] args) {
            string input;
            var numbers = new List<int>();
            bool consecutive = true;
            Console.WriteLine("Enter numbers separated by hyphen");
            input = Console.ReadLine();
            foreach (string str in input.Split('-')) {
                numbers.Add(int.Parse(str));
            }
            numbers.Sort();
            for (int i = 1; i < numbers.Count; i++) {
                if (numbers[i] != numbers[i - 1] + 1) {
                    consecutive = false;
                    break;
                }
            }
            Console.WriteLine("{0} Consecutive", (consecutive) ? "" : "Not ");
        }
    }
}