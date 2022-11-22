namespace _2_27_1
{

    internal class Program
    {
        static void Main(string[] args) {
            bool running = true;
            Stack stack = new Stack();
            Console.WriteLine("a: add value r: remove value c: clear q: quit");
            while (running) {
                switch (Console.ReadKey(true).KeyChar) {
                    case 'a':
                        Console.WriteLine("Add value:");
                        String input = Console.ReadLine();
                        stack.Push(input);
                        break;
                    case 'r':
                        try {
                            Console.WriteLine(stack.Pop());
                        }
                        catch (Exception e) {
                            Console.WriteLine(e.Message);
                        }
                        break;
                    case 'c':
                        stack.Clear();
                        break;
                    case 'q':
                        running = false;
                        break;
                    default:
                        break;
                }
            }
        }
    }
}