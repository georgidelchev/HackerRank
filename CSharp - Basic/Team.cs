namespace ConsoleApp1
{
    public class Team
    {
        public Team(string teamName, int noOfPlayers)
        {
            this.TeamName = teamName;
            this.NoOfPlayers = noOfPlayers;
        }

        public string TeamName { get; set; }

        public int NoOfPlayers { get; set; }

        public void AddPlayer(int count)
        {
            this.NoOfPlayers += count;
        }

        public bool RemovePlayer(int count)
        {
            if (this.NoOfPlayers - count < 0)
            {
                return false;
            }

            this.NoOfPlayers -= count;

            return true;
        }
    }
}