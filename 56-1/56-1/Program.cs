namespace _56_1
{
    internal class Program
    {
        static void Main(string[] args) {
            var likes = new List<string>();
            string input;
            while (true) {
                Console.WriteLine("Enter a name");
                input = Console.ReadLine();
                if (string.IsNullOrEmpty(input)) {
                    break;
                }
                likes.Add(input);
            }
            switch (likes.Count) {
                case 0:
                    break;
                case 1:
                    Console.WriteLine("{0} likes your post", likes[0]);
                    break;
                case 2:
                    Console.WriteLine("{0} and {1} like your post", likes[0], likes[1]);
                    break;
                default:
                    Console.WriteLine("{0}, {1} and {2} others like your post", likes[0], likes[1], likes.Count - 2);
                    break;
            }
        }
    }
}