using Microsoft.EntityFrameworkCore;
using STUDY.Blazor.FifaWorldCup.Shared.Models;

namespace STUDY.Blazor.FifaWorldCup.Server.Models;

public partial class DatabaseContext : DbContext
{
    public DatabaseContext()
    {
    }
    public DatabaseContext(DbContextOptions<DatabaseContext> options)
        : base(options)
    {
    }
    public virtual DbSet<Match> Matches { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Match>().HasData(
            new Match
            {
                Id = 1,
                Team1 = "Qatar",
                Team2 = "Ecuador",
                GoalsTeam1 = 0,
                GoalsTeam2 = 0,
                Seed = 'A',
                Venue = Venue.AlBayt,
                Date = "2022-11-20 16:00:00",
                IsFinished = false,
            },
            new Match
            {
                Id = 2,
                Team1 = "England",
                Team2 = "Iran",
                GoalsTeam1 = 0,
                GoalsTeam2 = 0,
                Seed = 'B',
                Venue = Venue.Khalifa,
                Date = "2022-11-21 13:00:00",
                IsFinished = false
            },
            new Match
            {
                Id = 3,
                Team1 = "Senegal",
                Team2 = "Netherlands",
                GoalsTeam1 = 0,
                GoalsTeam2 = 0,
                Seed = 'A',
                Venue = Venue.AlThumama,
                Date = "2022-11-21 16:00:00",
                IsFinished = false
            },
            new Match
            {
                Id = 4,
                Team1 = "USA",
                Team2 = "Wales",
                GoalsTeam1 = 0,
                GoalsTeam2 = 0,
                Seed = 'B',
                Venue = Venue.Ahmad,
                Date = "2022-11-21 19:00:00",
                IsFinished = false
            },
            new Match
            {
                Id = 5,
                Team1 = "Argentina",
                Team2 = "Saudi Arabia",
                GoalsTeam1 = 0,
                GoalsTeam2 = 0,
                Seed = 'C',
                Venue = Venue.Lusail,
                Date = "2022-11-22 10:00:00",
                IsFinished = false
            },
            new Match
            {
                Id = 6,
                Team1 = "Denmark",
                Team2 = "Tunisia",
                GoalsTeam1 = 0,
                GoalsTeam2 = 0,
                Seed = 'D',
                Venue = Venue.Education,
                Date = "2022-11-22 13:00:00",
                IsFinished = false
            },
            new Match
            {
                Id = 7,
                Team1 = "Mexico",
                Team2 = "Poland",
                GoalsTeam1 = 0,
                GoalsTeam2 = 0,
                Seed = 'C',
                Venue = Venue.Stadium974,
                Date = "2022-11-22 16:00:00",
                IsFinished = false
            },
            new Match
            {
                Id = 8,
                Team1 = "France",
                Team2 = "Australia",
                GoalsTeam1 = 0,
                GoalsTeam2 = 0,
                Seed = 'D',
                Venue = Venue.AlJanoub,
                Date = "2022-11-22 19:00:00",
                IsFinished = false
            },
            new Match
            {
                Id = 9,
                Team1 = "Marrocos",
                Team2 = "Croatia",
                GoalsTeam1 = 0,
                GoalsTeam2 = 0,
                Seed = 'F',
                Venue = Venue.AlBayt,
                Date = "2022-11-23 10:00:00",
                IsFinished = false
            },
            new Match
            {
                Id = 10,
                Team1 = "Germany",
                Team2 = "Japan",
                GoalsTeam1 = 0,
                GoalsTeam2 = 0,
                Seed = 'E',
                Venue = Venue.Khalifa,
                Date = "2022-11-23 13:00:00",
                IsFinished = false
            },
            new Match
            {
                Id = 11,
                Team1 = "Spain",
                Team2 = "Costa Rica",
                GoalsTeam1 = 0,
                GoalsTeam2 = 0,
                Seed = 'E',
                Venue = "Al Thumama Stadium, Doha",
                Date = "2022-11-23 16:00:00",
                IsFinished = false
            },
            new Match
            {
                Id = 12,
                Team1 = "Belgium",
                Team2 = "Canada",
                GoalsTeam1 = 0,
                GoalsTeam2 = 0,
                Seed = 'F',
                Venue = "Ahmad bin Ali Stadium, Al Rayyan",
                Date = "2022-11-23 19:00:00",
                IsFinished = false
            },
            new Match
            {
                Id = 13,
                Team1 = "Switzerland",
                Team2 = "Cameroon",
                GoalsTeam1 = 0,
                GoalsTeam2 = 0,
                Seed = 'G',
                Venue = "Al Janoub Stadium, Al Wakrah",
                Date = "2022-11-23 10:00:00",
                IsFinished = false
            },
            new Match
            {
                Id = 14,
                Team1 = "Uruguay",
                Team2 = "Korea Republic",
                GoalsTeam1 = 0,
                GoalsTeam2 = 0,
                Seed = 'H',
                Venue = "Education City Stadium, Al Rayyan",
                Date = "2022-11-24 13:00:00",
                IsFinished = false
            },
            new Match
            {
                Id = 15,
                Team1 = "Portugal",
                Team2 = "Ghana",
                GoalsTeam1 = 0,
                GoalsTeam2 = 0,
                Seed = 'H',
                Venue = "Stadium 974, Doha",
                Date = "2022-11-24 16:00:00",
                IsFinished = false
            },
            new Match
            {
                Id = 16,
                Team1 = "Brazil",
                Team2 = "Serbia",
                GoalsTeam1 = 0,
                GoalsTeam2 = 0,
                Seed = 'E',
                Venue = "Khalifa International Stadium, Doha",
                Date = "2022-11-23 13:00:00",
                IsFinished = false
            },
            new Match
            {
                Id = 17,
                Team1 = "Wales",
                Team2 = "Iran",
                GoalsTeam1 = 0,
                GoalsTeam2 = 0,
                Seed = 'B',
                Venue = "Ahmad bin Ali Stadium, Al Rayyan",
                Date = "2022-11-25 10:00:00",
                IsFinished = false
            },
            new Match
            {
                Id = 18,
                Team1 = "Qatar",
                Team2 = "Senegal",
                GoalsTeam1 = 0,
                GoalsTeam2 = 0,
                Seed = 'A',
                Venue = "Al Thumama Stadium, Doha",
                Date = "2022-11-25 13:00:00",
                IsFinished = false
            },
            new Match
            {
                Id = 19,
                Team1 = "Netherlands",
                Team2 = "Ecuador",
                GoalsTeam1 = 0,
                GoalsTeam2 = 0,
                Seed = 'A',
                Venue = "Khalifa International Stadium, Doha",
                Date = "2022-11-25 16:00:00",
                IsFinished = false
            },
            new Match
            {
                Id = 20,
                Team1 = "England",
                Team2 = "USA",
                GoalsTeam1 = 0,
                GoalsTeam2 = 0,
                Seed = 'B',
                Venue = "Khalifa International Stadium, Doha",
                Date = "2022-11-25 19:00:00",
                IsFinished = false
            },
            new Match
            {
                Id = 21,
                Team1 = "Tunisia",
                Team2 = "Australia",
                GoalsTeam1 = 0,
                GoalsTeam2 = 0,
                Seed = 'D',
                Venue = "Al Janoub Stadium, Al Wakrah",
                Date = "2022-11-26 10:00:00",
                IsFinished = false
            },
            new Match
            {
                Id = 22,
                Team1 = "Poland",
                Team2 = "Saudi Arabia",
                GoalsTeam1 = 0,
                GoalsTeam2 = 0,
                Seed = 'C',
                Venue = "Education City Stadium, Al Rayyan",
                Date = "2022-11-26 13:00:00",
                IsFinished = false
            },
            new Match
            {
                Id = 23,
                Team1 = "France",
                Team2 = "Denmark",
                GoalsTeam1 = 0,
                GoalsTeam2 = 0,
                Seed = 'D',
                Venue = "Stadium 974, Doha",
                Date = "2022-11-26 16:00:00",
                IsFinished = false
            },
            new Match
            {
                Id = 24,
                Team1 = "Argentina",
                Team2 = "Mexico",
                GoalsTeam1 = 0,
                GoalsTeam2 = 0,
                Seed = 'C',
                Venue = "Lusail Iconic Stadium, Lusail",
                Date = "2022-11-26 19:00:00",
                IsFinished = false
            },
            new Match
            {
                Id = 25,
                Team1 = "Japan",
                Team2 = "Costa Rica",
                GoalsTeam1 = 0,
                GoalsTeam2 = 0,
                Seed = 'E',
                Venue = "Ahmad bin Ali Stadium, Al Rayyan",
                Date = "2022-11-27 10:00:00",
                IsFinished = false
            },
            new Match
            {
                Id = 26,
                Team1 = "Belgium",
                Team2 = "Morocco",
                GoalsTeam1 = 0,
                GoalsTeam2 = 0,
                Seed = 'F',
                Venue = "Al Thumama Stadium, Doha",
                Date = "2022-11-27 13:00:00",
                IsFinished = false
            },
            new Match
            {
                Id = 27,
                Team1 = "Croatia",
                Team2 = "Canada",
                GoalsTeam1 = 0,
                GoalsTeam2 = 0,
                Seed = 'F',
                Venue = "Khalifa International Stadium, Doha",
                Date = "2022-11-27 16:00:00",
                IsFinished = false
            },
            new Match
            {
                Id = 28,
                Team1 = "Spain",
                Team2 = "Germany",
                GoalsTeam1 = 0,
                GoalsTeam2 = 0,
                Seed = 'E',
                Venue = "Al Bayt Stadium, Al Khor",
                Date = "2022-11-27 19:00:00",
                IsFinished = false
            },
            new Match
            {
                Id = 29,
                Team1 = "Cameroon",
                Team2 = "Serbia",
                GoalsTeam1 = 0,
                GoalsTeam2 = 0,
                Seed = 'G',
                Venue = "Al Janoub Stadium, Al Wakrah",
                Date = "2022-11-28 10:00:00",
                IsFinished = false
            },
            new Match
            {
                Id = 30,
                Team1 = "Korea Republic",
                Team2 = "Ghana",
                GoalsTeam1 = 0,
                GoalsTeam2 = 0,
                Seed = 'H',
                Venue = "Education City Stadium, Al Rayyan",
                Date = "2022-11-28 13:00:00",
                IsFinished = false
            },
            new Match
            {
                Id = 31,
                Team1 = "Brazil",
                Team2 = "Switzerland",
                GoalsTeam1 = 0,
                GoalsTeam2 = 0,
                Seed = 'G',
                Venue = "Stadium 974, Doha",
                Date = "2022-11-28 16:00:00",
                IsFinished = false
            },
            new Match
            {
                Id = 32,
                Team1 = "Portugal",
                Team2 = "Uruguay",
                GoalsTeam1 = 0,
                GoalsTeam2 = 0,
                Seed = 'H',
                Venue = "Lusail Iconic Stadium, Lusail",
                Date = "2022-11-28 19:00:00",
                IsFinished = false
            },
            new Match
            {
                Id = 33,
                Team1 = "Netherlands",
                Team2 = "Qatar",
                GoalsTeam1 = 0,
                GoalsTeam2 = 0,
                Seed = 'A',
                Venue = "Khalifa International Stadium, Doha",
                Date = "2022-11-29 15:00:00",
                IsFinished = false
            },
            new Match
            {
                Id = 34,
                Team1 = "Ecuador",
                Team2 = "Senegal",
                GoalsTeam1 = 0,
                GoalsTeam2 = 0,
                Seed = 'A',
                Venue = "Al Bayt Stadium, Al Khor",
                Date = "2022-11-29 15:00:00",
                IsFinished = false
            },
            new Match
            {
                Id = 35,
                Team1 = "Wales",
                Team2 = "England",
                GoalsTeam1 = 0,
                GoalsTeam2 = 0,
                Seed = 'B',
                Venue = "Ahmad bin Ali Stadium, Al Rayyan",
                Date = "2022-11-29 19:00:00",
                IsFinished = false
            },
            new Match
            {
                Id = 36,
                Team1 = "Iran",
                Team2 = "USA",
                GoalsTeam1 = 0,
                GoalsTeam2 = 0,
                Seed = 'B',
                Venue = "Al Thumama Stadium, Doha",
                Date = "2022-11-29 19:00:00",
                IsFinished = false
            },
            new Match
            {
                Id = 37,
                Team1 = "Australia",
                Team2 = "Denmark",
                GoalsTeam1 = 0,
                GoalsTeam2 = 0,
                Seed = 'D',
                Venue = "Al Janoub Stadium, Al Wakrah",
                Date = "2022-11-30 15:00:00",
                IsFinished = false
            },
            new Match
            {
                Id = 38,
                Team1 = "Tunisia",
                Team2 = "France",
                GoalsTeam1 = 0,
                GoalsTeam2 = 0,
                Seed = 'D',
                Venue = "Education City Stadium, Al Rayyan",
                Date = "2022-11-30 15:00:00",
                IsFinished = false
            },
            new Match
            {
                Id = 39,
                Team1 = "Poland",
                Team2 = "Argentina",
                GoalsTeam1 = 0,
                GoalsTeam2 = 0,
                Seed = 'C',
                Venue = "Stadium 974, Doha",
                Date = "2022-11-30 19:00:00",
                IsFinished = false
            },
            new Match
            {
                Id = 40,
                Team1 = "Saudi Arabia",
                Team2 = "Mexico",
                GoalsTeam1 = 0,
                GoalsTeam2 = 0,
                Seed = 'C',
                Venue = "Lusail Iconic Stadium, Lusail",
                Date = "2022-11-30 19:00:00",
                IsFinished = false
            },
            new Match
            {
                Id = 41,
                Team1 = "Croatia",
                Team2 = "Belgium",
                GoalsTeam1 = 0,
                GoalsTeam2 = 0,
                Seed = 'F',
                Venue = "Ahmad bin Ali Stadium, Al Rayyan",
                Date = "2022-12-01 15:00:00",
                IsFinished = false
            },
            new Match
            {
                Id = 42,
                Team1 = "Canada",
                Team2 = "Morocco",
                GoalsTeam1 = 0,
                GoalsTeam2 = 0,
                Seed = 'F',
                Venue = "Al Thumama Stadium, Doha",
                Date = "2022-12-01 15:00:00",
                IsFinished = false
            },
            new Match
            {
                Id = 43,
                Team1 = "Japan",
                Team2 = "Spain",
                GoalsTeam1 = 0,
                GoalsTeam2 = 0,
                Seed = 'E',
                Venue = "Khalifa International Stadium, Doha",
                Date = "2022-12-01 19:00:00",
                IsFinished = false
            },
            new Match
            {
                Id = 44,
                Team1 = "Costa Rica",
                Team2 = "Germany",
                GoalsTeam1 = 0,
                GoalsTeam2 = 0,
                Seed = 'E',
                Venue = "Al Bayt Stadium, Al Khor",
                Date = "2022-12-01 19:00:00",
                IsFinished = false
            },
            new Match
            {
                Id = 45,
                Team1 = "Ghana",
                Team2 = "Uruguay",
                GoalsTeam1 = 0,
                GoalsTeam2 = 0,
                Seed = 'H',
                Venue = "Al Janoub Stadium, Al Wakrah",
                Date = "2022-12-02 15:00:00",
                IsFinished = false
            },
            new Match
            {
                Id = 46,
                Team1 = "Korea Republic",
                Team2 = "Portugal",
                GoalsTeam1 = 0,
                GoalsTeam2 = 0,
                Seed = 'H',
                Venue = "Education City Stadium, Al Rayyan",
                Date = "2022-12-02 15:00:00",
                IsFinished = false
            },
            new Match
            {
                Id = 47,
                Team1 = "Serbia",
                Team2 = "Switzerland",
                GoalsTeam1 = 0,
                GoalsTeam2 = 0,
                Seed = 'G',
                Venue = "Stadium 974, Doha",
                Date = "2022-12-02 19:00:00",
                IsFinished = false
            },
            new Match
            {
                Id = 48,
                Team1 = "Cameroon",
                Team2 = "Brazil",
                GoalsTeam1 = 0,
                GoalsTeam2 = 0,
                Seed = 'G',
                Venue = "Lusail Iconic Stadium, Lusail",
                Date = "2022-12-02 19:00:00",
                IsFinished = false
            }
            );


        OnModelCreatingPartial(modelBuilder);
    }
    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}