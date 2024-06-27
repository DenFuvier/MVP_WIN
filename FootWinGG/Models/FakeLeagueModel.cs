namespace FootWinGG.Models
{
    public class FakeLeagueModel : ILeagueModel
    {
        private List<League> leagues_ = new List<League>();

        public event Action DataChanged;

        public FakeLeagueModel() 
        {
            League l1 = new League("Премьер-Лига");

            {
                Team t1 = new Team("ФК Спартак");
                t1.AddPlayer(new Player("Квинси Промес", 10));
                t1.AddPlayer(new Player("Егор Одуванчиков", 22));
                l1.AddTeam(t1);

                Team t2 = new Team("ЦСКА");
                t2.AddPlayer(new Player("Вагнер Лав", 10));
                l1.AddTeam(t2);
            }

            League l2 = new League("Бундеслига");
            {
                Team t1 = new Team("Бавария");
                t1.AddPlayer(new Player("Мануэль Нойер", 39));
                t1.AddPlayer(new Player("Лука Тони", 33));
                l2.AddTeam(t1);
            }



            leagues_.Add(l1);
            leagues_.Add(l2);
        }    

        public void DeleteLeague(string LeagueName)
        {
            for (int i = 0; i < leagues_.Count; i++)
            {
                League league = leagues_[i];
                if (league.Name == LeagueName)
                {
                    leagues_.RemoveAt(i);
                    DataChanged?.Invoke();
                    return;
                }
            }
        }

        public List<League> GetLeagueList()
        {
            return leagues_;
        }
    }
}
