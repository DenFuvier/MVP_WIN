namespace FootWinGG.Models
{
    public class Player
    {
        private string name_;
        private int number_;

        public Player(string FIO, int n)
        {
            name_ = FIO;
            number_ = n;
        }

        public string Name { get { return name_; } } 
        public int Number { get { return number_; } }
    }
}
