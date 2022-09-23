namespace STUDY.Blazor.FifaWorldCup.Shared.Models;

public class Match
{
    public int Id { get; set; }
    public string Team1 { get; set; }
    public string Team2 { get; set; }
    public int GoalsTeam1 { get; set; }
    public int GoalsTeam2 { get; set; }
    public char Seed { get; set; }
    public string Venue { get; set; }
    public string Date { get; set; }
}
