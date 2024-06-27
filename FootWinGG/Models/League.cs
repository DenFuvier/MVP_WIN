namespace FootWinGG.Models
{
    public  class League
    {
        private string name_;
        private List<Team> teams_ = new List<Team>();

        public League(string N)
        {
            name_ = N;
        }

        public void AddTeam(Team team) 
        {
            teams_.Add(team);
        }

        public List<Team> GetTeams()
        {
            return teams_;
        }

        public string Name { get { return name_; } }
    }
}
