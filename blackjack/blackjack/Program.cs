namespace blackjack
{

    internal class Program
    {
        static void Main(string[] args)
        {
            Deck deck = new Deck();
            deck.Shuffle();
            foreach (var card in deck.Cards)
            {
                Console.WriteLine(card);
            }
        }
    }
}