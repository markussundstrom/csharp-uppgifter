namespace _68_5
{
    internal class Program
    {
        static void Main(string[] args) {
            char[] vowels = { 'a', 'e', 'o', 'u', 'i' };
            char[] word;
            string input;
            int numVowels = 0;
            Console.WriteLine("Enter a word");
            input = Console.ReadLine().ToLower;
            word = input.ToCharArray();
            for (int i = 0; i < word.Length; i++) {
                if (vowels.Contains(word[i])) {
                    numVowels++;
                }
            }
            Console.WriteLine("{0} vowels", numVowels);
        }
    }
}