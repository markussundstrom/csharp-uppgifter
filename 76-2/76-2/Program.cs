namespace _76_2
{
    internal class Program
    {
        static void Main(string[] args) {
            string path = @"c:\users\marku\OneDrive\Dokument\lorem.txt";
            Console.WriteLine("Longest word: " + longestWord(File.ReadAllText(path)));
        }

        public static string longestWord(string text) {
            List<string> words = new List<string>();
            int indexLongest = 0;
            words.AddRange(text.Split(' '));
            for (int i = 0; i < words.Count; i++) {
                if (indexLongest < words[i].Length) {
                    indexLongest = i;
                }
            }
            return words[indexLongest];
        }
    }
}