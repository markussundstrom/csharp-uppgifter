namespace blackjack
{
    public class Player
    {
        public List<Card> Hand { get; private set; }

        public Player()
        {
            Hand = new List<Card>();
        }

        public void TakeCard(Card card)
        {
            Hand.Add(card);
        }


    }
}
