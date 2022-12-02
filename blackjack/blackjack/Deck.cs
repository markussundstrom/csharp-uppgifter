namespace blackjack
{
    public class Deck
    {
        public List<Card> Cards;
        private Random _random;

        public Deck()
        {
            Cards = new List<Card>();
            foreach (Card.CardSuit suit in Enum.GetValues(typeof(Card.CardSuit)))
            {
                for (int i = Card.MinValue; i <= Card.MaxValue; i++)
                {
                    Cards.Add(new Card(i, suit));
                }
            }
            _random = new Random();
        }

        public void Shuffle()
        {
            int n = Cards.Count;
            while (n > 1)
            {
                int k = _random.Next(n);
                --n;
                Card current = Cards[k];
                Cards[k] = Cards[n];
                Cards[n] = current;
            }
        }
    }
}