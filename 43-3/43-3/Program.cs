namespace _43_3
{
    internal class Program
    {
        static void Main(string[] args) {
            string input;
            int width, height;
            Console.WriteLine("Enter width");
            input = Console.ReadLine();
            width = Int32.Parse(input);
            Console.WriteLine("Enter height");
            input = Console.ReadLine();
            height = Int32.Parse(input);
            Console.WriteLine("The image is {0}", (width > height) ? "landscape" : "portrait");
        }
    }
}