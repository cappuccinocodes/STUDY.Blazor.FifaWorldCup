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
            });


        OnModelCreatingPartial(modelBuilder);
    }
    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}