using FootWinGG.Models;
using FootWinGG.View;
using FootWinGG.Presenter;
using Microsoft.VisualBasic.ApplicationServices;

namespace FootWinGG
{
    public partial class MainForm : Form, ILeagueView
    {
        public event Action<string> RemovingLeague;
        public event Action<string> SelectionLeague;
        public event Action<string> SelectionTeam;

        private LeaguePresenter presenter_;
        public MainForm()
        {
            InitializeComponent();
            presenter_ = new LeaguePresenter(this, new FakeLeagueModel());

            LigaItems.SelectedIndexChanged += LigaItems_SelectedIndexChanged;
            TeamsListBox.SelectedIndexChanged += TeamsListBox_SelectedIndexChanged;
        }

        private void TeamsListBox_SelectedIndexChanged(object? sender, EventArgs e)
        {
            Team t = (Team)TeamsListBox.SelectedItem;
            if (t != null)
            {
                SelectionTeam.Invoke(t.Name);
            }
        }

        private void LigaItems_SelectedIndexChanged(object? sender, EventArgs e)
        {
            League l = (League)LigaItems.SelectedItem;
            if (l != null)
            {
                SelectionLeague.Invoke(l.Name);
            }
        }

        public void ShowAllLeagues(List<League> leagues)
        {
            LigaItems.Items.Clear();
            foreach (League l in leagues)
            {
                LigaItems.Items.Add(l);
            }

            LigaItems.DisplayMember = "Name";
        }

        private void DeleteLiga_Click(object sender, EventArgs e)
        {
            League l = (League)LigaItems.SelectedItem;
            if (l != null)
            {
                RemovingLeague.Invoke(l.Name);
            }
        }

        public void ShowAllPlayersFromTeam(string teamName)
        {
            Team team = null;
            foreach (Team t in TeamsListBox.Items)
            {
                if (t.Name == teamName)
                {
                    team = t;
                    break;
                }
            }
            if (team == null)
            {
                return;
            }

            List<Player> players = team.GetPlayers();
            PlayersTable.DataSource = null;
            PlayersTable.DataSource = players;
        }

        public void ShowAllTeamsFromLeague(string leagueName)
        {
            League league = null;
            foreach(League l in LigaItems.Items)
            {
                if(l.Name == leagueName)
                {
                    league = l;
                    break;
                }
            }
            if(league == null)
            {
                return;
            }


            TeamsListBox.Items.Clear();
            List<Team> teams = league.GetTeams();
            foreach (Team t in teams) {
                  TeamsListBox.Items.Add(t);
             }

             TeamsListBox.DisplayMember = "Name"; 

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
