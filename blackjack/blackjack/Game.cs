namespace blackjack
{
    public class Game
    {
        public Player _dealer {get; private set;}
        public List<Player> _players {get; private set;}

        public Game()
        {
            _players = new List<Player>();
            _dealer = new Player();
        }

        public void AddPlayer(Player player)
        {
            _players.Add(player);
        }
    }
}