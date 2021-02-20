namespace ConsoleApp1
{
    public class SubTeam : Team
    {
        public SubTeam(string teamName, int noOfPlayers)
            : base(teamName, noOfPlayers)
        {
        }

        public void ChangeTeamName(string name)
        {
            this.TeamName = name;
        }
    }
}