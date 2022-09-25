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
                Venue = "Al Bayt Stadium, Al Khor",
                Date = "2022-11-20 16:00:00"
            },
            new Match
            {
                Id = 2,
                Team1 = "England",
                Team2 = "Iran",
                GoalsTeam1 = 0,
                GoalsTeam2 = 0,
                Seed = 'B',
                Venue = "Khalifa International Stadium, Doha",
                Date = "2022-11-21 13:00:00"
            },
            new Match
            {
                Id = 3,
                Team1 = "Senegal",
                Team2 = "Netherlands",
                GoalsTeam1 = 0,
                GoalsTeam2 = 0,
                Seed = 'A',
                Venue = "Al Thumama Stadium, Doha",
                Date = "2022-11-21 16:00:00"
            },
            new Match
            {
                Id = 4,
                Team1 = "USA",
                Team2 = "Wales",
                GoalsTeam1 = 0,
                GoalsTeam2 = 0,
                Seed = 'B',
                Venue = "Ahmad bin Ali Stadium, Al Rayyan",
                Date = "2022-11-21 19:00:00"
            }
            ,
            new Match
            {
                Id = 5,
                Team1 = "Argentina",
                Team2 = "Saudi Arabia",
                GoalsTeam1 = 0,
                GoalsTeam2 = 0,
                Seed = 'C',
                Venue = "Lusail Iconic Stadium, Lusail",
                Date = "2022-11-22 10:00:00"
            },
            new Match
            {
                Id = 6,
                Team1 = "Denmark",
                Team2 = "Tunisia",
                GoalsTeam1 = 0,
                GoalsTeam2 = 0,
                Seed = 'D',
                Venue = "Education City Stadium, Al Rayyan",
                Date = "2022-11-22 13:00:00"
            },
            new Match
            {
                Id = 7,
                Team1 = "Mexico",
                Team2 = "Poland",
                GoalsTeam1 = 0,
                GoalsTeam2 = 0,
                Seed = 'D',
                Venue = "Stadium 974",
                Date = "2022-11-22 13:00:00"
            }
            );


        OnModelCreatingPartial(modelBuilder);
    }
    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}