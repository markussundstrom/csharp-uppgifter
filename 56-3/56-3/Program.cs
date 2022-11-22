namespace _56_3
{
    internal class Program
    {
        static void Main(string[] args) {
            var numbers = new List<int>();
            int input;

            Console.WriteLine("Please enter 5 numbers");
            while (numbers.Count < 5) {
                Console.WriteLine("Enter a number");
                input = Int32.Parse(Console.ReadLine());
                if (numbers.Contains(input)) {
                    Console.WriteLine("Number already entered");
                    continue;
                } else {
                    numbers.Add(input);
                }
            }
            numbers.Sort();
            Console.WriteLine("Numbers: ");
            foreach (int num in numbers) {
                Console.WriteLine(num);
            }




        }
    }
}