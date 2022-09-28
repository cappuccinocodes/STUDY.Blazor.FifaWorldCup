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
                Team1 = Country.Qatar,
                Team2 = Country.Ecuador,
                GoalsTeam1 = 0,
                GoalsTeam2 = 0,
                Seed = Seed.A,
                Venue = Venue.AlBayt,
                Date = "2022-11-20 16:00:00",
                IsFinished = false,
            },
            new Match
            {
                Id = 2,
                Team1 = Country.England,
                Team2 = Country.Iran,
                GoalsTeam1 = 0,
                GoalsTeam2 = 0,
                Seed = Seed.B,
                Venue = Venue.Khalifa,
                Date = "2022-11-21 13:00:00",
                IsFinished = false
            },
            new Match
            {
                Id = 3,
                Team1 = Country.Senegal,
                Team2 = Country.Netherlands,
                GoalsTeam1 = 0,
                GoalsTeam2 = 0,
                Seed = Seed.A,
                Venue = Venue.AlThumama,
                Date = "2022-11-21 16:00:00",
                IsFinished = false
            },
            new Match
            {
                Id = 4,
                Team1 = Country.USA,
                Team2 = Country.Wales,
                GoalsTeam1 = 0,
                GoalsTeam2 = 0,
                Seed = Seed.B,
                Venue = Venue.Ahmad,
                Date = "2022-11-21 19:00:00",
                IsFinished = false
            },
            new Match
            {
                Id = 5,
                Team1 = Country.Argentina,
                Team2 = Country.SaudiArabia,
                GoalsTeam1 = 0,
                GoalsTeam2 = 0,
                Seed = Seed.C,
                Venue = Venue.Lusail,
                Date = "2022-11-22 10:00:00",
                IsFinished = false
            },
            new Match
            {
                Id = 6,
                Team1 = Country.Denmark,
                Team2 = Country.Tunisia,
                GoalsTeam1 = 0,
                GoalsTeam2 = 0,
                Seed = Seed.D,
                Venue = Venue.Education,
                Date = "2022-11-22 13:00:00",
                IsFinished = false
            },
            new Match
            {
                Id = 7,
                Team1 = Country.Mexico,
                Team2 = Country.Poland,
                GoalsTeam1 = 0,
                GoalsTeam2 = 0,
                Seed = Seed.C,
                Venue = Venue.Stadium974,
                Date = "2022-11-22 16:00:00",
                IsFinished = false
            },
            new Match
            {
                Id = 8,
                Team1 = Country.France,
                Team2 = Country.Australia,
                GoalsTeam1 = 0,
                GoalsTeam2 = 0,
                Seed = Seed.D,
                Venue = Venue.AlJanoub,
                Date = "2022-11-22 19:00:00",
                IsFinished = false
            },
            new Match
            {
                Id = 9,
                Team1 = Country.Morocco,
                Team2 = Country.Croatia,
                GoalsTeam1 = 0,
                GoalsTeam2 = 0,
                Seed = Seed.F,
                Venue = Venue.AlBayt,
                Date = "2022-11-23 10:00:00",
                IsFinished = false
            },
            new Match
            {
                Id = 10,
                Team1 = Country.Germany,
                Team2 = Country.Japan,
                GoalsTeam1 = 0,
                GoalsTeam2 = 0,
                Seed = Seed.E,
                Venue = Venue.Khalifa,
                Date = "2022-11-23 13:00:00",
                IsFinished = false
            },
            new Match
            {
                Id = 11,
                Team1 = Country.Spain,
                Team2 = Country.CostaRica,
                GoalsTeam1 = 0,
                GoalsTeam2 = 0,
                Seed = Seed.E,
                Venue = Venue.AlThumama,
                Date = "2022-11-23 16:00:00",
                IsFinished = false
            },
            new Match
            {
                Id = 12,
                Team1 = Country.Belgium,
                Team2 = Country.Canada,
                GoalsTeam1 = 0,
                GoalsTeam2 = 0,
                Seed = Seed.F,
                Venue = Venue.Ahmad,
                Date = "2022-11-23 19:00:00",
                IsFinished = false
            },
            new Match
            {
                Id = 13,
                Team1 = Country.Switzerland,
                Team2 = Country.Cameroon,
                GoalsTeam1 = 0,
                GoalsTeam2 = 0,
                Seed = Seed.G,
                Venue = Venue.AlJanoub,
                Date = "2022-11-23 10:00:00",
                IsFinished = false
            },
            new Match
            {
                Id = 14,
                Team1 = Country.Uruguay,
                Team2 = Country.Korea,
                GoalsTeam1 = 0,
                GoalsTeam2 = 0,
                Seed = Seed.H,
                Venue = Venue.Education,
                Date = "2022-11-24 13:00:00",
                IsFinished = false
            },
            new Match
            {
                Id = 15,
                Team1 = Country.Portugal,
                Team2 = Country.Ghana,
                GoalsTeam1 = 0,
                GoalsTeam2 = 0,
                Seed = Seed.H,
                Venue = Venue.Stadium974,
                Date = "2022-11-24 16:00:00",
                IsFinished = false
            },
            new Match
            {
                Id = 16,
                Team1 = Country.Brazil,
                Team2 = Country.Serbia,
                GoalsTeam1 = 0,
                GoalsTeam2 = 0,
                Seed = Seed.G,
                Venue = Venue.Khalifa,
                Date = "2022-11-23 13:00:00",
                IsFinished = false
            },
            new Match
            {
                Id = 17,
                Team1 = Country.Wales,
                Team2 = Country.Iran,
                GoalsTeam1 = 0,
                GoalsTeam2 = 0,
                Seed = Seed.B,
                Venue = Venue.Ahmad,
                Date = "2022-11-25 10:00:00",
                IsFinished = false
            },
            new Match
            {
                Id = 18,
                Team1 = Country.Qatar,
                Team2 = Country.Senegal,
                GoalsTeam1 = 0,
                GoalsTeam2 = 0,
                Seed = Seed.A,
                Venue = Venue.AlThumama,
                Date = "2022-11-25 13:00:00",
                IsFinished = false
            },
            new Match
            {
                Id = 19,
                Team1 = Country.Netherlands,
                Team2 = Country.Ecuador,
                GoalsTeam1 = 0,
                GoalsTeam2 = 0,
                Seed = Seed.A,
                Venue = Venue.Khalifa,
                Date = "2022-11-25 16:00:00",
                IsFinished = false
            },
            new Match
            {
                Id = 20,
                Team1 = Country.England,
                Team2 = Country.USA,
                GoalsTeam1 = 0,
                GoalsTeam2 = 0,
                Seed = Seed.B,
                Venue = Venue.Khalifa,
                Date = "2022-11-25 19:00:00",
                IsFinished = false
            },
            new Match
            {
                Id = 21,
                Team1 = Country.Tunisia,
                Team2 = Country.Australia,
                GoalsTeam1 = 0,
                GoalsTeam2 = 0,
                Seed = Seed.D,
                Venue = Venue.AlJanoub,
                Date = "2022-11-26 10:00:00",
                IsFinished = false
            },
            new Match
            {
                Id = 22,
                Team1 = Country.Poland,
                Team2 = Country.SaudiArabia,
                GoalsTeam1 = 0,
                GoalsTeam2 = 0,
                Seed = Seed.C,
                Venue = Venue.Education,
                Date = "2022-11-26 13:00:00",
                IsFinished = false
            },
            new Match
            {
                Id = 23,
                Team1 = Country.France,
                Team2 = Country.Denmark,
                GoalsTeam1 = 0,
                GoalsTeam2 = 0,
                Seed = Seed.D,
                Venue = Venue.Stadium974,
                Date = "2022-11-26 16:00:00",
                IsFinished = false
            },
            new Match
            {
                Id = 24,
                Team1 = Country.Argentina,
                Team2 = Country.Mexico,
                GoalsTeam1 = 0,
                GoalsTeam2 = 0,
                Seed = Seed.C,
                Venue = Venue.Lusail,
                Date = "2022-11-26 19:00:00",
                IsFinished = false
            },
            new Match
            {
                Id = 25,
                Team1 = Country.Japan,
                Team2 = Country.CostaRica,
                GoalsTeam1 = 0,
                GoalsTeam2 = 0,
                Seed = Seed.E,
                Venue = Venue.Ahmad,
                Date = "2022-11-27 10:00:00",
                IsFinished = false
            },
            new Match
            {
                Id = 26,
                Team1 = Country.Belgium,
                Team2 = Country.Morocco,
                GoalsTeam1 = 0,
                GoalsTeam2 = 0,
                Seed = Seed.F,
                Venue = Venue.AlThumama,
                Date = "2022-11-27 13:00:00",
                IsFinished = false
            },
            new Match
            {
                Id = 27,
                Team1 = Country.Croatia,
                Team2 = Country.Canada,
                GoalsTeam1 = 0,
                GoalsTeam2 = 0,
                Seed = Seed.F,
                Venue = Venue.Khalifa,
                Date = "2022-11-27 16:00:00",
                IsFinished = false
            },
            new Match
            {
                Id = 28,
                Team1 = Country.Spain,
                Team2 = Country.Germany,
                GoalsTeam1 = 0,
                GoalsTeam2 = 0,
                Seed = Seed.E,
                Venue = Venue.AlBayt,
                Date = "2022-11-27 19:00:00",
                IsFinished = false
            },
            new Match
            {
                Id = 29,
                Team1 = Country.Cameroon,
                Team2 = Country.Serbia,
                GoalsTeam1 = 0,
                GoalsTeam2 = 0,
                Seed = Seed.G,
                Venue = Venue.AlJanoub,
                Date = "2022-11-28 10:00:00",
                IsFinished = false
            },
            new Match
            {
                Id = 30,
                Team1 = Country.Korea,
                Team2 = Country.Ghana,
                GoalsTeam1 = 0,
                GoalsTeam2 = 0,
                Seed = Seed.H,
                Venue = Venue.Education,
                Date = "2022-11-28 13:00:00",
                IsFinished = false
            },
            new Match
            {
                Id = 31,
                Team1 = Country.Brazil,
                Team2 = Country.Switzerland,
                GoalsTeam1 = 0,
                GoalsTeam2 = 0,
                Seed = Seed.G,
                Venue = Venue.Stadium974,
                Date = "2022-11-28 16:00:00",
                IsFinished = false
            },
            new Match
            {
                Id = 32,
                Team1 = Country.Portugal,
                Team2 = Country.Uruguay,
                GoalsTeam1 = 0,
                GoalsTeam2 = 0,
                Seed = Seed.H,
                Venue = Venue.Lusail,
                Date = "2022-11-28 19:00:00",
                IsFinished = false
            },
            new Match
            {
                Id = 33,
                Team1 = Country.Netherlands,
                Team2 = Country.Qatar,
                GoalsTeam1 = 0,
                GoalsTeam2 = 0,
                Seed = Seed.A,
                Venue = Venue.Khalifa,
                Date = "2022-11-29 15:00:00",
                IsFinished = false
            },
            new Match
            {
                Id = 34,
                Team1 = Country.Ecuador,
                Team2 = Country.Senegal,
                GoalsTeam1 = 0,
                GoalsTeam2 = 0,
                Seed = Seed.A,
                Venue = Venue.AlBayt,
                Date = "2022-11-29 15:00:00",
                IsFinished = false
            },
            new Match
            {
                Id = 35,
                Team1 = Country.Wales,
                Team2 = Country.England,
                GoalsTeam1 = 0,
                GoalsTeam2 = 0,
                Seed = Seed.B,
                Venue = Venue.Ahmad,
                Date = "2022-11-29 19:00:00",
                IsFinished = false
            },
            new Match
            {
                Id = 36,
                Team1 = Country.Iran,
                Team2 = Country.USA,
                GoalsTeam1 = 0,
                GoalsTeam2 = 0,
                Seed = Seed.B,
                Venue = Venue.AlThumama,
                Date = "2022-11-29 19:00:00",
                IsFinished = false
            },
            new Match
            {
                Id = 37,
                Team1 = Country.Australia,
                Team2 = Country.Denmark,
                GoalsTeam1 = 0,
                GoalsTeam2 = 0,
                Seed = Seed.D,
                Venue = Venue.AlJanoub,
                Date = "2022-11-30 15:00:00",
                IsFinished = false
            },
            new Match
            {
                Id = 38,
                Team1 = Country.Tunisia,
                Team2 = Country.France,
                GoalsTeam1 = 0,
                GoalsTeam2 = 0,
                Seed = Seed.D,
                Venue = Venue.Education,
                Date = "2022-11-30 15:00:00",
                IsFinished = false
            },
            new Match
            {
                Id = 39,
                Team1 = Country.Poland,
                Team2 = Country.Argentina,
                GoalsTeam1 = 0,
                GoalsTeam2 = 0,
                Seed = Seed.C,
                Venue = Venue.Stadium974,
                Date = "2022-11-30 19:00:00",
                IsFinished = false
            },
            new Match
            {
                Id = 40,
                Team1 = Country.SaudiArabia,
                Team2 = Country.Mexico,
                GoalsTeam1 = 0,
                GoalsTeam2 = 0,
                Seed = Seed.C,
                Venue = Venue.Lusail,
                Date = "2022-11-30 19:00:00",
                IsFinished = false
            },
            new Match
            {
                Id = 41,
                Team1 = Country.Croatia,
                Team2 = Country.Belgium,
                GoalsTeam1 = 0,
                GoalsTeam2 = 0,
                Seed = Seed.F,
                Venue = Venue.Ahmad,
                Date = "2022-12-01 15:00:00",
                IsFinished = false
            },
            new Match
            {
                Id = 42,
                Team1 = Country.Canada,
                Team2 = Country.Morocco,
                GoalsTeam1 = 0,
                GoalsTeam2 = 0,
                Seed = Seed.F,
                Venue = Venue.AlThumama,
                Date = "2022-12-01 15:00:00",
                IsFinished = false
            },
            new Match
            {
                Id = 43,
                Team1 = Country.Japan,
                Team2 = Country.Spain,
                GoalsTeam1 = 0,
                GoalsTeam2 = 0,
                Seed = Seed.E,
                Venue = Venue.Khalifa,
                Date = "2022-12-01 19:00:00",
                IsFinished = false
            },
            new Match
            {
                Id = 44,
                Team1 = Country.CostaRica,
                Team2 = Country.Germany,
                GoalsTeam1 = 0,
                GoalsTeam2 = 0,
                Seed = Seed.E,
                Venue = Venue.AlBayt,
                Date = "2022-12-01 19:00:00",
                IsFinished = false
            },
            new Match
            {
                Id = 45,
                Team1 = Country.Ghana,
                Team2 = Country.Uruguay,
                GoalsTeam1 = 0,
                GoalsTeam2 = 0,
                Seed = Seed.H,
                Venue = Venue.AlJanoub,
                Date = "2022-12-02 15:00:00",
                IsFinished = false
            },
            new Match
            {
                Id = 46,
                Team1 = Country.Korea,
                Team2 = Country.Portugal,
                GoalsTeam1 = 0,
                GoalsTeam2 = 0,
                Seed = Seed.H,
                Venue = Venue.Education,
                Date = "2022-12-02 15:00:00",
                IsFinished = false
            },
            new Match
            {
                Id = 47,
                Team1 = Country.Serbia,
                Team2 = Country.Switzerland,
                GoalsTeam1 = 0,
                GoalsTeam2 = 0,
                Seed = Seed.G,
                Venue = Venue.Stadium974,
                Date = "2022-12-02 19:00:00",
                IsFinished = false
            },
            new Match
            {
                Id = 48,
                Team1 = Country.Cameroon,
                Team2 = Country.Brazil,
                GoalsTeam1 = 0,
                GoalsTeam2 = 0,
                Seed = Seed.G,
                Venue = Venue.Lusail,
                Date = "2022-12-02 19:00:00",
                IsFinished = false
            },
             new Match
             {
                 Id = 49,
                 GoalsTeam1 = 0,
                 GoalsTeam2 = 0,
                 Placeholder1 = "1st Group A",
                 Placeholder2 = "2nd Group B",
                 Seed = Seed.P,
                 Venue = Venue.Khalifa,
                 Date = "2022-12-03 15:00:00",
                 IsFinished = false
             },
             new Match
             {
                 Id = 50,
                 GoalsTeam1 = 0,
                 GoalsTeam2 = 0,
                 Placeholder1 = "1st Group C",
                 Placeholder2 = "2nd Group D",
                 Seed = Seed.P,
                 Venue = Venue.Ahmad,
                 Date = "2022-12-03 19:00:00",
                 IsFinished = false
             },
             new Match
             {
                 Id = 51,
                 GoalsTeam1 = 0,
                 GoalsTeam2 = 0,
                 Placeholder1 = "1st Group B",
                 Placeholder2 = "2nd Group A",
                 Seed = Seed.P,
                 Venue = Venue.AlThumama,
                 Date = "2022-12-04 19:00:00",
                 IsFinished = false
             },
             new Match
             {
                 Id = 52,
                 GoalsTeam1 = 0,
                 GoalsTeam2 = 0,
                 Placeholder1 = "1st Group D",
                 Placeholder2 = "2nd Group C",
                 Seed = Seed.P,
                 Venue = Venue.AlBayt,
                 Date = "2022-12-04 15:00:00",
                 IsFinished = false
             },
             new Match
             {
                 Id = 53,
                 Placeholder1 = "1st Group E",
                 Placeholder2 = "2nd Group F",
                 GoalsTeam1 = 0,
                 GoalsTeam2 = 0,
                 Seed = Seed.P,
                 Venue = Venue.AlJanoub,
                 Date = "2022-12-05 15:00:00",
                 IsFinished = false
             },
             new Match
             {
                 Id = 54,
                 GoalsTeam1 = 0,
                 GoalsTeam2 = 0,
                 Placeholder1 = "1st Group G",
                 Placeholder2 = "2nd Group H",
                 Seed = Seed.P,
                 Venue = Venue.Stadium974,
                 Date = "2022-12-05 19:00:00",
                 IsFinished = false
             },
             new Match
             {
                 Id = 55,
                 GoalsTeam1 = 0,
                 GoalsTeam2 = 0,
                 Placeholder1 = "1st Group F",
                 Placeholder2 = "2nd Group E",
                 Seed = Seed.P,
                 Venue = Venue.Education,
                 Date = "2022-12-06 15:00:00",
                 IsFinished = false
             },
             new Match
             {
                 Id = 56,
                 GoalsTeam1 = 0,
                 GoalsTeam2 = 0,
                 Placeholder1 = "1st Group H",
                 Placeholder2 = "2nd Group G",
                 Seed = Seed.P,
                 Venue = Venue.Lusail,
                 Date = "2022-12-06 19:00:00",
                 IsFinished = false
             },
             new Match
             {
                 Id = 57,
                 GoalsTeam1 = 0,
                 GoalsTeam2 = 0,
                 Placeholder1 = "Winners Match 49",
                 Placeholder2 = "Winners Match 50",
                 Seed = Seed.P,
                 Venue = Venue.Education,
                 Date = "2022-12-09 15:00:00",
                 IsFinished = false
             },
             new Match
             {
                 Id = 58,
                 GoalsTeam1 = 0,
                 GoalsTeam2 = 0,
                 Placeholder1 = "Winners Match 53",
                 Placeholder2 = "Winners Match 54",
                 Seed = Seed.P,
                 Venue = Venue.Lusail,
                 Date = "2022-12-09 19:00:00",
                 IsFinished = false
             }, 
             new Match
             {
                 Id = 59,
                 GoalsTeam1 = 0,
                 GoalsTeam2 = 0,
                 Placeholder1 = "Winners Match 51",
                 Placeholder2 = "Winners Match 52",
                 Seed = Seed.P,
                 Venue = Venue.AlBayt,
                 Date = "2022-12-10 19:00:00",
                 IsFinished = false
             },
             new Match
             {
                 Id = 60,
                 GoalsTeam1 = 0,
                 GoalsTeam2 = 0,
                 Placeholder1 = "Winners Match 55",
                 Placeholder2 = "Winners Match 56",
                 Seed = Seed.P,
                 Venue = Venue.AlThumama,
                 Date = "2022-12-10 15:00:00",
                 IsFinished = false
             }, 
             new Match
             {
                 Id = 61,
                 GoalsTeam1 = 0,
                 GoalsTeam2 = 0,
                 Placeholder1 = "Winners Match 57",
                 Placeholder2 = "Winners Match 58",
                 Seed = Seed.P,
                 Venue = Venue.Lusail,
                 Date = "2022-12-13 19:00:00",
                 IsFinished = false
             },
             new Match
             {
                 Id = 62,
                 GoalsTeam1 = 0,
                 GoalsTeam2 = 0,
                 Placeholder1 = "Winners Match 59",
                 Placeholder2 = "Winners Match 60",
                 Seed = Seed.P,
                 Venue = Venue.AlBayt,
                 Date = "2022-12-14 19:00:00",
                 IsFinished = false
             },
             new Match
             {
                 Id = 63,
                 GoalsTeam1 = 0,
                 GoalsTeam2 = 0,
                 Placeholder1 = "Losers Match 61",
                 Placeholder2 = "Losers Match 62",
                 Seed = Seed.P,
                 Venue = Venue.Khalifa,
                 Date = "2022-12-17 15:00:00",
                 IsFinished = false
             },
             new Match
             {
                 Id = 64,
                 GoalsTeam1 = 0,
                 GoalsTeam2 = 0,
                 Placeholder1 = "Winners Match 61",
                 Placeholder2 = "Winners Match 62",
                 Seed = Seed.P,
                 Venue = Venue.Lusail,
                 Date = "2022-12-18 15:00:00",
                 IsFinished = false
             }
            );


        OnModelCreatingPartial(modelBuilder);
    }
    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}