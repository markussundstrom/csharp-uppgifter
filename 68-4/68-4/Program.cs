namespace _68_4
{
    internal class Program
    {
        static void Main(string[] args) {
            var nameparts = new List<string>();
            var fixedparts = new List<char[]>();
            string final = "";
            string input;
            Console.WriteLine("Enter space separated variable name parts");
            input = Console.ReadLine();
            if (string.IsNullOrEmpty(input)) {
                Console.WriteLine("Error");
                return;
            }
            nameparts.AddRange(input.Split(' '));
            foreach (string part in nameparts) {
                fixedparts.Add(part.ToLower().ToCharArray());
            }
            foreach (char[] arrpart in fixedparts) {
                arrpart[0] = char.ToUpper(arrpart[0]);
                final += new string(arrpart);
            }
            Console.WriteLine(final);
        }
    }
}