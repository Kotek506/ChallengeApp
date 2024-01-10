namespace ChallengeApp
{
    public class User
    {

        public static string GameName = "Diablo";
        private List<int> score = new List<int>();

        private string login;
        private string password;
        private string name;

        //public User(string login)
        //{
        //     this.login = login;
        //     this.password = "-";
        //     this.name = "-";
        //}
        //public User(string login, string password)
        //{
        //    this.login = login;
        //    this.password = password;
        //    this.name = "-";
        //}
        //public User()
        //{
        //    this.login = "-";
        //    this.password = "-";
        //    this.name = "-";
        //}
        public User(string login)
        {
            this.Login = login;
           //  this.Password = password;
        }

        public string Login { get; private set; }

        public string Password { get; private set; }

        public int Result
        {
            get
            {
                return this.score.Sum();
            }
        }

        public void AddScore(int number)
        {
            this.score.Add(number);
        }
    }
}
