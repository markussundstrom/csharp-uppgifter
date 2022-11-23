namespace _76_1
{
    internal class Program
    {
        static void Main(string[] args) {
            string text;
            //string path = @"c:\users\marku\OneDrive\Dokument\lorem.txt";
            string path = AppDomain.CurrentDomain.BaseDirectory + "\\lorem.txt";
            text = File.ReadAllText(path);
            Console.WriteLine("{0} words in file", numWordsInText(text));
        }

        public static int numWordsInText(string text) {
            var words = new List<string>();
            words.AddRange(text.Split(' '));
            return words.Count;
        }
    }
}