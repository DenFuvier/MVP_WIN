using FootWinGG.Models;

namespace FootWinGG.View
{
    public interface ILeagueView
    {
        public event Action<string> RemovingLeague;
        public event Action<string> SelectionLeague;
        public event Action<string> SelectionTeam;
        void ShowAllLeagues(List<League> leagues);
        void ShowAllTeamsFromLeague(string leagueName);

        void ShowAllPlayersFromTeam(string teamName);
    }
}
