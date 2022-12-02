namespace blackjack
{

    public class Card
    {
        public enum CardSuit
        {
            Hearts,
            Spades,
            Diamonds,
            Clubs
        }
        public  static readonly int MinValue = 1;
        public  static readonly int MaxValue = 13;

        public int Value { get; }
        public CardSuit Suit { get; }

        public Card(int value, CardSuit suit)
        {
            if (1 > value || value > 13)
            {
                throw new ArgumentOutOfRangeException();
            }
            if (CardSuit.Hearts > suit || suit > CardSuit.Clubs)
            {
                throw new ArgumentOutOfRangeException();
            }
            this.Value = value;
            this.Suit = suit;
        }

        public override string ToString()
        {
            string valueToString = Value switch
            {
                1 => "A",
                11 => "J",
                12 => "Q",
                13 => "K",
                _ => Value.ToString(),
            };
            return $"{Enum.GetName(Suit).Substring(0, 2)} {valueToString}";
        }

        public string ToLongString()
        {
            string valueToString = Value switch
            {
                1 => "Ace",
                11 => "Jack",
                12 => "Queen",
                13 => "King",
                _ => Value.ToString(),
            };
            return $"{valueToString} of {Enum.GetName(Suit)}";
        }
    }
}