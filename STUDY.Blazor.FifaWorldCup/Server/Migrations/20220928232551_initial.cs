using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace STUDY.Blazor.FifaWorldCup.Server.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Matches",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INTEGER", nullable: false)
                        .Annotation("Sqlite:Autoincrement", true),
                    Team1 = table.Column<int>(type: "INTEGER", nullable: true),
                    Team2 = table.Column<int>(type: "INTEGER", nullable: true),
                    GoalsTeam1 = table.Column<int>(type: "INTEGER", nullable: false),
                    GoalsTeam2 = table.Column<int>(type: "INTEGER", nullable: false),
                    Seed = table.Column<int>(type: "INTEGER", nullable: false),
                    Venue = table.Column<int>(type: "INTEGER", nullable: false),
                    Date = table.Column<string>(type: "TEXT", nullable: false),
                    Placeholder1 = table.Column<string>(type: "TEXT", nullable: true),
                    Placeholder2 = table.Column<string>(type: "TEXT", nullable: true),
                    IsFinished = table.Column<bool>(type: "INTEGER", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Matches", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "Date", "GoalsTeam1", "GoalsTeam2", "IsFinished", "Placeholder1", "Placeholder2", "Seed", "Team1", "Team2", "Venue" },
                values: new object[] { 1, "2022-11-20 16:00:00", 0, 0, false, null, null, 0, 1, 4, 0 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "Date", "GoalsTeam1", "GoalsTeam2", "IsFinished", "Placeholder1", "Placeholder2", "Seed", "Team1", "Team2", "Venue" },
                values: new object[] { 2, "2022-11-21 13:00:00", 0, 0, false, null, null, 1, 5, 8, 1 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "Date", "GoalsTeam1", "GoalsTeam2", "IsFinished", "Placeholder1", "Placeholder2", "Seed", "Team1", "Team2", "Venue" },
                values: new object[] { 3, "2022-11-21 16:00:00", 0, 0, false, null, null, 0, 3, 2, 2 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "Date", "GoalsTeam1", "GoalsTeam2", "IsFinished", "Placeholder1", "Placeholder2", "Seed", "Team1", "Team2", "Venue" },
                values: new object[] { 4, "2022-11-21 19:00:00", 0, 0, false, null, null, 1, 6, 7, 3 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "Date", "GoalsTeam1", "GoalsTeam2", "IsFinished", "Placeholder1", "Placeholder2", "Seed", "Team1", "Team2", "Venue" },
                values: new object[] { 5, "2022-11-22 10:00:00", 0, 0, false, null, null, 2, 9, 12, 4 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "Date", "GoalsTeam1", "GoalsTeam2", "IsFinished", "Placeholder1", "Placeholder2", "Seed", "Team1", "Team2", "Venue" },
                values: new object[] { 6, "2022-11-22 13:00:00", 0, 0, false, null, null, 3, 14, 15, 5 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "Date", "GoalsTeam1", "GoalsTeam2", "IsFinished", "Placeholder1", "Placeholder2", "Seed", "Team1", "Team2", "Venue" },
                values: new object[] { 7, "2022-11-22 16:00:00", 0, 0, false, null, null, 2, 11, 10, 6 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "Date", "GoalsTeam1", "GoalsTeam2", "IsFinished", "Placeholder1", "Placeholder2", "Seed", "Team1", "Team2", "Venue" },
                values: new object[] { 8, "2022-11-22 19:00:00", 0, 0, false, null, null, 3, 13, 16, 7 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "Date", "GoalsTeam1", "GoalsTeam2", "IsFinished", "Placeholder1", "Placeholder2", "Seed", "Team1", "Team2", "Venue" },
                values: new object[] { 9, "2022-11-23 10:00:00", 0, 0, false, null, null, 5, 24, 22, 0 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "Date", "GoalsTeam1", "GoalsTeam2", "IsFinished", "Placeholder1", "Placeholder2", "Seed", "Team1", "Team2", "Venue" },
                values: new object[] { 10, "2022-11-23 13:00:00", 0, 0, false, null, null, 4, 17, 19, 1 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "Date", "GoalsTeam1", "GoalsTeam2", "IsFinished", "Placeholder1", "Placeholder2", "Seed", "Team1", "Team2", "Venue" },
                values: new object[] { 11, "2022-11-23 16:00:00", 0, 0, false, null, null, 4, 18, 20, 2 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "Date", "GoalsTeam1", "GoalsTeam2", "IsFinished", "Placeholder1", "Placeholder2", "Seed", "Team1", "Team2", "Venue" },
                values: new object[] { 12, "2022-11-23 19:00:00", 0, 0, false, null, null, 5, 21, 23, 3 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "Date", "GoalsTeam1", "GoalsTeam2", "IsFinished", "Placeholder1", "Placeholder2", "Seed", "Team1", "Team2", "Venue" },
                values: new object[] { 13, "2022-11-23 10:00:00", 0, 0, false, null, null, 6, 26, 28, 7 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "Date", "GoalsTeam1", "GoalsTeam2", "IsFinished", "Placeholder1", "Placeholder2", "Seed", "Team1", "Team2", "Venue" },
                values: new object[] { 14, "2022-11-24 13:00:00", 0, 0, false, null, null, 7, 30, 32, 5 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "Date", "GoalsTeam1", "GoalsTeam2", "IsFinished", "Placeholder1", "Placeholder2", "Seed", "Team1", "Team2", "Venue" },
                values: new object[] { 15, "2022-11-24 16:00:00", 0, 0, false, null, null, 7, 29, 31, 6 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "Date", "GoalsTeam1", "GoalsTeam2", "IsFinished", "Placeholder1", "Placeholder2", "Seed", "Team1", "Team2", "Venue" },
                values: new object[] { 16, "2022-11-23 13:00:00", 0, 0, false, null, null, 6, 25, 27, 1 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "Date", "GoalsTeam1", "GoalsTeam2", "IsFinished", "Placeholder1", "Placeholder2", "Seed", "Team1", "Team2", "Venue" },
                values: new object[] { 17, "2022-11-25 10:00:00", 0, 0, false, null, null, 1, 7, 8, 3 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "Date", "GoalsTeam1", "GoalsTeam2", "IsFinished", "Placeholder1", "Placeholder2", "Seed", "Team1", "Team2", "Venue" },
                values: new object[] { 18, "2022-11-25 13:00:00", 0, 0, false, null, null, 0, 1, 3, 2 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "Date", "GoalsTeam1", "GoalsTeam2", "IsFinished", "Placeholder1", "Placeholder2", "Seed", "Team1", "Team2", "Venue" },
                values: new object[] { 19, "2022-11-25 16:00:00", 0, 0, false, null, null, 0, 2, 4, 1 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "Date", "GoalsTeam1", "GoalsTeam2", "IsFinished", "Placeholder1", "Placeholder2", "Seed", "Team1", "Team2", "Venue" },
                values: new object[] { 20, "2022-11-25 19:00:00", 0, 0, false, null, null, 1, 5, 6, 1 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "Date", "GoalsTeam1", "GoalsTeam2", "IsFinished", "Placeholder1", "Placeholder2", "Seed", "Team1", "Team2", "Venue" },
                values: new object[] { 21, "2022-11-26 10:00:00", 0, 0, false, null, null, 3, 15, 16, 7 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "Date", "GoalsTeam1", "GoalsTeam2", "IsFinished", "Placeholder1", "Placeholder2", "Seed", "Team1", "Team2", "Venue" },
                values: new object[] { 22, "2022-11-26 13:00:00", 0, 0, false, null, null, 2, 10, 12, 5 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "Date", "GoalsTeam1", "GoalsTeam2", "IsFinished", "Placeholder1", "Placeholder2", "Seed", "Team1", "Team2", "Venue" },
                values: new object[] { 23, "2022-11-26 16:00:00", 0, 0, false, null, null, 3, 13, 14, 6 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "Date", "GoalsTeam1", "GoalsTeam2", "IsFinished", "Placeholder1", "Placeholder2", "Seed", "Team1", "Team2", "Venue" },
                values: new object[] { 24, "2022-11-26 19:00:00", 0, 0, false, null, null, 2, 9, 11, 4 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "Date", "GoalsTeam1", "GoalsTeam2", "IsFinished", "Placeholder1", "Placeholder2", "Seed", "Team1", "Team2", "Venue" },
                values: new object[] { 25, "2022-11-27 10:00:00", 0, 0, false, null, null, 4, 19, 20, 3 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "Date", "GoalsTeam1", "GoalsTeam2", "IsFinished", "Placeholder1", "Placeholder2", "Seed", "Team1", "Team2", "Venue" },
                values: new object[] { 26, "2022-11-27 13:00:00", 0, 0, false, null, null, 5, 21, 24, 2 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "Date", "GoalsTeam1", "GoalsTeam2", "IsFinished", "Placeholder1", "Placeholder2", "Seed", "Team1", "Team2", "Venue" },
                values: new object[] { 27, "2022-11-27 16:00:00", 0, 0, false, null, null, 5, 22, 23, 1 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "Date", "GoalsTeam1", "GoalsTeam2", "IsFinished", "Placeholder1", "Placeholder2", "Seed", "Team1", "Team2", "Venue" },
                values: new object[] { 28, "2022-11-27 19:00:00", 0, 0, false, null, null, 4, 18, 17, 0 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "Date", "GoalsTeam1", "GoalsTeam2", "IsFinished", "Placeholder1", "Placeholder2", "Seed", "Team1", "Team2", "Venue" },
                values: new object[] { 29, "2022-11-28 10:00:00", 0, 0, false, null, null, 6, 28, 27, 7 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "Date", "GoalsTeam1", "GoalsTeam2", "IsFinished", "Placeholder1", "Placeholder2", "Seed", "Team1", "Team2", "Venue" },
                values: new object[] { 30, "2022-11-28 13:00:00", 0, 0, false, null, null, 7, 32, 31, 5 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "Date", "GoalsTeam1", "GoalsTeam2", "IsFinished", "Placeholder1", "Placeholder2", "Seed", "Team1", "Team2", "Venue" },
                values: new object[] { 31, "2022-11-28 16:00:00", 0, 0, false, null, null, 6, 25, 26, 6 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "Date", "GoalsTeam1", "GoalsTeam2", "IsFinished", "Placeholder1", "Placeholder2", "Seed", "Team1", "Team2", "Venue" },
                values: new object[] { 32, "2022-11-28 19:00:00", 0, 0, false, null, null, 7, 29, 30, 4 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "Date", "GoalsTeam1", "GoalsTeam2", "IsFinished", "Placeholder1", "Placeholder2", "Seed", "Team1", "Team2", "Venue" },
                values: new object[] { 33, "2022-11-29 15:00:00", 0, 0, false, null, null, 0, 2, 1, 1 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "Date", "GoalsTeam1", "GoalsTeam2", "IsFinished", "Placeholder1", "Placeholder2", "Seed", "Team1", "Team2", "Venue" },
                values: new object[] { 34, "2022-11-29 15:00:00", 0, 0, false, null, null, 0, 4, 3, 0 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "Date", "GoalsTeam1", "GoalsTeam2", "IsFinished", "Placeholder1", "Placeholder2", "Seed", "Team1", "Team2", "Venue" },
                values: new object[] { 35, "2022-11-29 19:00:00", 0, 0, false, null, null, 1, 7, 5, 3 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "Date", "GoalsTeam1", "GoalsTeam2", "IsFinished", "Placeholder1", "Placeholder2", "Seed", "Team1", "Team2", "Venue" },
                values: new object[] { 36, "2022-11-29 19:00:00", 0, 0, false, null, null, 1, 8, 6, 2 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "Date", "GoalsTeam1", "GoalsTeam2", "IsFinished", "Placeholder1", "Placeholder2", "Seed", "Team1", "Team2", "Venue" },
                values: new object[] { 37, "2022-11-30 15:00:00", 0, 0, false, null, null, 3, 16, 14, 7 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "Date", "GoalsTeam1", "GoalsTeam2", "IsFinished", "Placeholder1", "Placeholder2", "Seed", "Team1", "Team2", "Venue" },
                values: new object[] { 38, "2022-11-30 15:00:00", 0, 0, false, null, null, 3, 15, 13, 5 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "Date", "GoalsTeam1", "GoalsTeam2", "IsFinished", "Placeholder1", "Placeholder2", "Seed", "Team1", "Team2", "Venue" },
                values: new object[] { 39, "2022-11-30 19:00:00", 0, 0, false, null, null, 2, 10, 9, 6 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "Date", "GoalsTeam1", "GoalsTeam2", "IsFinished", "Placeholder1", "Placeholder2", "Seed", "Team1", "Team2", "Venue" },
                values: new object[] { 40, "2022-11-30 19:00:00", 0, 0, false, null, null, 2, 12, 11, 4 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "Date", "GoalsTeam1", "GoalsTeam2", "IsFinished", "Placeholder1", "Placeholder2", "Seed", "Team1", "Team2", "Venue" },
                values: new object[] { 41, "2022-12-01 15:00:00", 0, 0, false, null, null, 5, 22, 21, 3 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "Date", "GoalsTeam1", "GoalsTeam2", "IsFinished", "Placeholder1", "Placeholder2", "Seed", "Team1", "Team2", "Venue" },
                values: new object[] { 42, "2022-12-01 15:00:00", 0, 0, false, null, null, 5, 23, 24, 2 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "Date", "GoalsTeam1", "GoalsTeam2", "IsFinished", "Placeholder1", "Placeholder2", "Seed", "Team1", "Team2", "Venue" },
                values: new object[] { 43, "2022-12-01 19:00:00", 0, 0, false, null, null, 4, 19, 18, 1 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "Date", "GoalsTeam1", "GoalsTeam2", "IsFinished", "Placeholder1", "Placeholder2", "Seed", "Team1", "Team2", "Venue" },
                values: new object[] { 44, "2022-12-01 19:00:00", 0, 0, false, null, null, 4, 20, 17, 0 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "Date", "GoalsTeam1", "GoalsTeam2", "IsFinished", "Placeholder1", "Placeholder2", "Seed", "Team1", "Team2", "Venue" },
                values: new object[] { 45, "2022-12-02 15:00:00", 0, 0, false, null, null, 7, 31, 30, 7 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "Date", "GoalsTeam1", "GoalsTeam2", "IsFinished", "Placeholder1", "Placeholder2", "Seed", "Team1", "Team2", "Venue" },
                values: new object[] { 46, "2022-12-02 15:00:00", 0, 0, false, null, null, 7, 32, 29, 5 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "Date", "GoalsTeam1", "GoalsTeam2", "IsFinished", "Placeholder1", "Placeholder2", "Seed", "Team1", "Team2", "Venue" },
                values: new object[] { 47, "2022-12-02 19:00:00", 0, 0, false, null, null, 6, 27, 26, 6 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "Date", "GoalsTeam1", "GoalsTeam2", "IsFinished", "Placeholder1", "Placeholder2", "Seed", "Team1", "Team2", "Venue" },
                values: new object[] { 48, "2022-12-02 19:00:00", 0, 0, false, null, null, 6, 28, 25, 4 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "Date", "GoalsTeam1", "GoalsTeam2", "IsFinished", "Placeholder1", "Placeholder2", "Seed", "Team1", "Team2", "Venue" },
                values: new object[] { 49, "2022-12-03 15:00:00", 0, 0, false, "1st Group A", "2nd Group B", 8, null, null, 1 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "Date", "GoalsTeam1", "GoalsTeam2", "IsFinished", "Placeholder1", "Placeholder2", "Seed", "Team1", "Team2", "Venue" },
                values: new object[] { 50, "2022-12-03 19:00:00", 0, 0, false, "1st Group C", "2nd Group D", 8, null, null, 3 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "Date", "GoalsTeam1", "GoalsTeam2", "IsFinished", "Placeholder1", "Placeholder2", "Seed", "Team1", "Team2", "Venue" },
                values: new object[] { 51, "2022-12-04 19:00:00", 0, 0, false, "1st Group B", "2nd Group A", 8, null, null, 2 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "Date", "GoalsTeam1", "GoalsTeam2", "IsFinished", "Placeholder1", "Placeholder2", "Seed", "Team1", "Team2", "Venue" },
                values: new object[] { 52, "2022-12-04 15:00:00", 0, 0, false, "1st Group D", "2nd Group C", 8, null, null, 0 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "Date", "GoalsTeam1", "GoalsTeam2", "IsFinished", "Placeholder1", "Placeholder2", "Seed", "Team1", "Team2", "Venue" },
                values: new object[] { 53, "2022-12-05 15:00:00", 0, 0, false, "1st Group E", "2nd Group F", 8, null, null, 7 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "Date", "GoalsTeam1", "GoalsTeam2", "IsFinished", "Placeholder1", "Placeholder2", "Seed", "Team1", "Team2", "Venue" },
                values: new object[] { 54, "2022-12-05 19:00:00", 0, 0, false, "1st Group G", "2nd Group H", 8, null, null, 6 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "Date", "GoalsTeam1", "GoalsTeam2", "IsFinished", "Placeholder1", "Placeholder2", "Seed", "Team1", "Team2", "Venue" },
                values: new object[] { 55, "2022-12-06 15:00:00", 0, 0, false, "1st Group F", "2nd Group E", 8, null, null, 5 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "Date", "GoalsTeam1", "GoalsTeam2", "IsFinished", "Placeholder1", "Placeholder2", "Seed", "Team1", "Team2", "Venue" },
                values: new object[] { 56, "2022-12-06 19:00:00", 0, 0, false, "1st Group H", "2nd Group G", 8, null, null, 4 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "Date", "GoalsTeam1", "GoalsTeam2", "IsFinished", "Placeholder1", "Placeholder2", "Seed", "Team1", "Team2", "Venue" },
                values: new object[] { 57, "2022-12-09 15:00:00", 0, 0, false, "Winners Match 49", "Winners Match 50", 8, null, null, 5 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "Date", "GoalsTeam1", "GoalsTeam2", "IsFinished", "Placeholder1", "Placeholder2", "Seed", "Team1", "Team2", "Venue" },
                values: new object[] { 58, "2022-12-09 19:00:00", 0, 0, false, "Winners Match 53", "Winners Match 54", 8, null, null, 4 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "Date", "GoalsTeam1", "GoalsTeam2", "IsFinished", "Placeholder1", "Placeholder2", "Seed", "Team1", "Team2", "Venue" },
                values: new object[] { 59, "2022-12-10 19:00:00", 0, 0, false, "Winners Match 51", "Winners Match 52", 8, null, null, 0 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "Date", "GoalsTeam1", "GoalsTeam2", "IsFinished", "Placeholder1", "Placeholder2", "Seed", "Team1", "Team2", "Venue" },
                values: new object[] { 60, "2022-12-10 15:00:00", 0, 0, false, "Winners Match 55", "Winners Match 56", 8, null, null, 2 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "Date", "GoalsTeam1", "GoalsTeam2", "IsFinished", "Placeholder1", "Placeholder2", "Seed", "Team1", "Team2", "Venue" },
                values: new object[] { 61, "2022-12-13 19:00:00", 0, 0, false, "Winners Match 57", "Winners Match 58", 8, null, null, 4 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "Date", "GoalsTeam1", "GoalsTeam2", "IsFinished", "Placeholder1", "Placeholder2", "Seed", "Team1", "Team2", "Venue" },
                values: new object[] { 62, "2022-12-14 19:00:00", 0, 0, false, "Winners Match 59", "Winners Match 60", 8, null, null, 0 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "Date", "GoalsTeam1", "GoalsTeam2", "IsFinished", "Placeholder1", "Placeholder2", "Seed", "Team1", "Team2", "Venue" },
                values: new object[] { 63, "2022-12-17 15:00:00", 0, 0, false, "Losers Match 61", "Losers Match 62", 8, null, null, 1 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "Date", "GoalsTeam1", "GoalsTeam2", "IsFinished", "Placeholder1", "Placeholder2", "Seed", "Team1", "Team2", "Venue" },
                values: new object[] { 64, "2022-12-18 15:00:00", 0, 0, false, "Winners Match 61", "Winners Match 62", 8, null, null, 4 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Matches");
        }
    }
}
