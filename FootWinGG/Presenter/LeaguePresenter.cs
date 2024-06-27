using FootWinGG.Models;
using FootWinGG.View;

namespace FootWinGG.Presenter
{
    internal class LeaguePresenter 
    {
        private readonly ILeagueView view_;
        private readonly ILeagueModel model_;

        public LeaguePresenter(ILeagueView view, ILeagueModel model)
        {
            view_ = view;
            model_ = model;
            UpdateLeaguesInfo();


            model_.DataChanged += UpdateLeaguesInfo;
            view_.RemovingLeague += View__RemovingLeague;
            view_.SelectionLeague += View__SelectionLeague;
            view_.SelectionTeam += View__SelectionTeam;
        }

        private void View__SelectionTeam(string teamName)
        {
            view_.ShowAllPlayersFromTeam(teamName);
        }

        private void View__SelectionLeague(string leagueName)
        { 
            view_.ShowAllTeamsFromLeague(leagueName);
        }

        private void View__RemovingLeague(string leagueName)
        {
            model_.DeleteLeague(leagueName);
        }

        private void UpdateLeaguesInfo()
        {
            List<League> leagues = model_.GetLeagueList();
            view_.ShowAllLeagues(leagues);
        }

    }
}
