using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace STUDY.Blazor.FifaWorldCup.Shared.Models;

public class Match
{
    public int Id { get; set; }
    public Country Team1 { get; set; }
    public Country Team2 { get; set; }
    public int GoalsTeam1 { get; set; }
    public int GoalsTeam2 { get; set; }
    public Seed Seed { get; set; }
    public Venue Venue { get; set; }
    public string Date { get; set; }
    public bool IsFinished { get; set; }
}

public enum Venue
{
    [Display(Name = "Al Bayt Stadium, Al Khor")]
    AlBayt,
    [Display(Name = "Khalifa International Stadium, Doha")]
    Khalifa,
    [Display(Name = "Al Thumama Stadium, Doha")]
    AlThumama,
    [Display(Name = "Ahmad bin Ali Stadium, Al Rayyan")]
    Ahmad,
    [Display(Name = "Lusail Iconic Stadium, Lusail")]
    Lusail,
    [Display(Name = "Education City Stadium, Al Rayyan")]
    Education,
    [Display(Name = "Stadium 974, Doha")]
    Stadium974,
    [Display(Name = "Al Janoub Stadium, Al Wakrah")]
    AlJanoub,
}

public enum Seed
{
    A,
    B,
    C,
    D,
    E,
    F,
    G,
    H,
    P
}

public enum Country
{
    Qatar,
    Netherlands,
    Senegal,
    Ecuador,
    England,
    USA,
    Wales,
    Iran,
    Argentina,
    Poland,
    Mexico,
    SaudiArabia,
    France,
    Denmark,
    Tunisia,
    Australia,
    Germany,
    Spain,
    Japan,
    CostaRica,
    Belgium,
    Croatia,
    Canada,
    Morocco,
    Brazil,
    Switzerland,
    Serbia,
    Cameroon,
    Portugal,
    Uruguay,
    Ghana,
    Korea
}