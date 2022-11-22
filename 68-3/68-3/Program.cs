namespace _68_3
{
    internal class Program
    {
        static void Main(string[] args) {
            string input;
            var time = new List<string>();
            bool validTime = false;
            Console.WriteLine("Enter time");
            input = Console.ReadLine();
            time.AddRange(input.Split(':'));
            if (time.Count == 2) {
                if (time[0].Length == 2 && time[1].Length == 2) {
                    if ((0 <= int.Parse(time[0]) && int.Parse(time[0]) <= 23) &&
                        (0 <= int.Parse(time[1]) && int.Parse(time[1]) <= 59)) {
                        validTime = true;
                    }
                }
            }
            Console.WriteLine("{0}", (validTime) ? "OK" : "Invalid Time");
        }
    }
}