namespace FootWinGG.Models
{

    public interface ILeagueModel
    {
        public event Action DataChanged;

        void DeleteLeague(string LeagueName);

        List<League> GetLeagueList();   

    }
}
