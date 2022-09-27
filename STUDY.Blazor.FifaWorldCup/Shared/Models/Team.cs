namespace STUDY.Blazor.FifaWorldCup.Shared.Models
{
    public class Team
    {
        public Country Name { get; set; }
        public int Points { get; set; }
        public int Goals { get; set; }
        public int GoalsAgainst { get; set; }
        public int GoalsDifference { get; set; }
        public int MatchesPlayed { get; set; }
    }
}
