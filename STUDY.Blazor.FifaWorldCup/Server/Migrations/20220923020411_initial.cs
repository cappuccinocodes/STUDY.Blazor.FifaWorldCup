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
                    Team1 = table.Column<string>(type: "TEXT", nullable: false),
                    Team2 = table.Column<string>(type: "TEXT", nullable: false),
                    GoalsTeam1 = table.Column<int>(type: "INTEGER", nullable: false),
                    GoalsTeam2 = table.Column<int>(type: "INTEGER", nullable: false),
                    Seed = table.Column<char>(type: "TEXT", nullable: false),
                    Venue = table.Column<string>(type: "TEXT", nullable: false),
                    Date = table.Column<string>(type: "TEXT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Matches", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "Date", "GoalsTeam1", "GoalsTeam2", "Seed", "Team1", "Team2", "Venue" },
                values: new object[] { 1, "2022-11-20 16:00:00", 0, 0, 'A', "Qatar", "Ecuador", "Al Bayt Stadium, Al Khor" });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "Date", "GoalsTeam1", "GoalsTeam2", "Seed", "Team1", "Team2", "Venue" },
                values: new object[] { 2, "2022-11-21 13:00:00", 0, 0, 'B', "England", "Iran", "Khalifa International Stadium, Doha" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Matches");
        }
    }
}
