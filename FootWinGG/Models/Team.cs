namespace FootWinGG.Models
{
    public class Team
    {
        private string name_;
        private List<Player> players_ = new List<Player>();

        public Team(string N)
        {
            name_ = N;
        }

        public void AddPlayer(Player p) 
        {
            players_.Add(p);
        }

        public List<Player> GetPlayers()
        {
            return players_;
        }

        public string Name { get { return name_; } }    
    }
}
