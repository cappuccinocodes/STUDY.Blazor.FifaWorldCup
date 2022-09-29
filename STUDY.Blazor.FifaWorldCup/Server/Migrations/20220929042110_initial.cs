using System;
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
                    Date = table.Column<DateTime>(type: "TEXT", nullable: false),
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
                values: new object[] { 1, new DateTime(2022, 11, 20, 16, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, false, null, null, 0, 0, 3, 0 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "Date", "GoalsTeam1", "GoalsTeam2", "IsFinished", "Placeholder1", "Placeholder2", "Seed", "Team1", "Team2", "Venue" },
                values: new object[] { 2, new DateTime(2022, 11, 21, 13, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, false, null, null, 1, 4, 7, 1 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "Date", "GoalsTeam1", "GoalsTeam2", "IsFinished", "Placeholder1", "Placeholder2", "Seed", "Team1", "Team2", "Venue" },
                values: new object[] { 3, new DateTime(2022, 11, 21, 16, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, false, null, null, 0, 2, 1, 2 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "Date", "GoalsTeam1", "GoalsTeam2", "IsFinished", "Placeholder1", "Placeholder2", "Seed", "Team1", "Team2", "Venue" },
                values: new object[] { 4, new DateTime(2022, 11, 21, 19, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, false, null, null, 1, 5, 6, 3 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "Date", "GoalsTeam1", "GoalsTeam2", "IsFinished", "Placeholder1", "Placeholder2", "Seed", "Team1", "Team2", "Venue" },
                values: new object[] { 5, new DateTime(2022, 11, 22, 10, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, false, null, null, 2, 8, 11, 4 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "Date", "GoalsTeam1", "GoalsTeam2", "IsFinished", "Placeholder1", "Placeholder2", "Seed", "Team1", "Team2", "Venue" },
                values: new object[] { 6, new DateTime(2022, 11, 22, 13, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, false, null, null, 3, 13, 14, 5 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "Date", "GoalsTeam1", "GoalsTeam2", "IsFinished", "Placeholder1", "Placeholder2", "Seed", "Team1", "Team2", "Venue" },
                values: new object[] { 7, new DateTime(2022, 11, 22, 16, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, false, null, null, 2, 10, 9, 6 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "Date", "GoalsTeam1", "GoalsTeam2", "IsFinished", "Placeholder1", "Placeholder2", "Seed", "Team1", "Team2", "Venue" },
                values: new object[] { 8, new DateTime(2022, 11, 22, 19, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, false, null, null, 3, 12, 15, 7 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "Date", "GoalsTeam1", "GoalsTeam2", "IsFinished", "Placeholder1", "Placeholder2", "Seed", "Team1", "Team2", "Venue" },
                values: new object[] { 9, new DateTime(2022, 11, 23, 10, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, false, null, null, 5, 23, 21, 0 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "Date", "GoalsTeam1", "GoalsTeam2", "IsFinished", "Placeholder1", "Placeholder2", "Seed", "Team1", "Team2", "Venue" },
                values: new object[] { 10, new DateTime(2022, 11, 23, 13, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, false, null, null, 4, 16, 18, 1 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "Date", "GoalsTeam1", "GoalsTeam2", "IsFinished", "Placeholder1", "Placeholder2", "Seed", "Team1", "Team2", "Venue" },
                values: new object[] { 11, new DateTime(2022, 11, 23, 16, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, false, null, null, 4, 17, 19, 2 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "Date", "GoalsTeam1", "GoalsTeam2", "IsFinished", "Placeholder1", "Placeholder2", "Seed", "Team1", "Team2", "Venue" },
                values: new object[] { 12, new DateTime(2022, 11, 23, 19, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, false, null, null, 5, 20, 22, 3 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "Date", "GoalsTeam1", "GoalsTeam2", "IsFinished", "Placeholder1", "Placeholder2", "Seed", "Team1", "Team2", "Venue" },
                values: new object[] { 13, new DateTime(2022, 11, 23, 10, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, false, null, null, 6, 25, 27, 7 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "Date", "GoalsTeam1", "GoalsTeam2", "IsFinished", "Placeholder1", "Placeholder2", "Seed", "Team1", "Team2", "Venue" },
                values: new object[] { 14, new DateTime(2022, 11, 24, 13, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, false, null, null, 7, 29, 31, 5 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "Date", "GoalsTeam1", "GoalsTeam2", "IsFinished", "Placeholder1", "Placeholder2", "Seed", "Team1", "Team2", "Venue" },
                values: new object[] { 15, new DateTime(2022, 11, 24, 16, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, false, null, null, 7, 28, 30, 6 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "Date", "GoalsTeam1", "GoalsTeam2", "IsFinished", "Placeholder1", "Placeholder2", "Seed", "Team1", "Team2", "Venue" },
                values: new object[] { 16, new DateTime(2022, 11, 23, 13, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, false, null, null, 6, 24, 26, 1 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "Date", "GoalsTeam1", "GoalsTeam2", "IsFinished", "Placeholder1", "Placeholder2", "Seed", "Team1", "Team2", "Venue" },
                values: new object[] { 17, new DateTime(2022, 11, 25, 10, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, false, null, null, 1, 6, 7, 3 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "Date", "GoalsTeam1", "GoalsTeam2", "IsFinished", "Placeholder1", "Placeholder2", "Seed", "Team1", "Team2", "Venue" },
                values: new object[] { 18, new DateTime(2022, 11, 25, 13, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, false, null, null, 0, 0, 2, 2 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "Date", "GoalsTeam1", "GoalsTeam2", "IsFinished", "Placeholder1", "Placeholder2", "Seed", "Team1", "Team2", "Venue" },
                values: new object[] { 19, new DateTime(2022, 11, 25, 16, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, false, null, null, 0, 1, 3, 1 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "Date", "GoalsTeam1", "GoalsTeam2", "IsFinished", "Placeholder1", "Placeholder2", "Seed", "Team1", "Team2", "Venue" },
                values: new object[] { 20, new DateTime(2022, 11, 25, 19, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, false, null, null, 1, 4, 5, 1 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "Date", "GoalsTeam1", "GoalsTeam2", "IsFinished", "Placeholder1", "Placeholder2", "Seed", "Team1", "Team2", "Venue" },
                values: new object[] { 21, new DateTime(2022, 11, 26, 10, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, false, null, null, 3, 14, 15, 7 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "Date", "GoalsTeam1", "GoalsTeam2", "IsFinished", "Placeholder1", "Placeholder2", "Seed", "Team1", "Team2", "Venue" },
                values: new object[] { 22, new DateTime(2022, 11, 26, 13, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, false, null, null, 2, 9, 11, 5 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "Date", "GoalsTeam1", "GoalsTeam2", "IsFinished", "Placeholder1", "Placeholder2", "Seed", "Team1", "Team2", "Venue" },
                values: new object[] { 23, new DateTime(2022, 11, 26, 16, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, false, null, null, 3, 12, 13, 6 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "Date", "GoalsTeam1", "GoalsTeam2", "IsFinished", "Placeholder1", "Placeholder2", "Seed", "Team1", "Team2", "Venue" },
                values: new object[] { 24, new DateTime(2022, 11, 26, 19, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, false, null, null, 2, 8, 10, 4 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "Date", "GoalsTeam1", "GoalsTeam2", "IsFinished", "Placeholder1", "Placeholder2", "Seed", "Team1", "Team2", "Venue" },
                values: new object[] { 25, new DateTime(2022, 11, 27, 10, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, false, null, null, 4, 18, 19, 3 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "Date", "GoalsTeam1", "GoalsTeam2", "IsFinished", "Placeholder1", "Placeholder2", "Seed", "Team1", "Team2", "Venue" },
                values: new object[] { 26, new DateTime(2022, 11, 27, 13, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, false, null, null, 5, 20, 23, 2 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "Date", "GoalsTeam1", "GoalsTeam2", "IsFinished", "Placeholder1", "Placeholder2", "Seed", "Team1", "Team2", "Venue" },
                values: new object[] { 27, new DateTime(2022, 11, 27, 16, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, false, null, null, 5, 21, 22, 1 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "Date", "GoalsTeam1", "GoalsTeam2", "IsFinished", "Placeholder1", "Placeholder2", "Seed", "Team1", "Team2", "Venue" },
                values: new object[] { 28, new DateTime(2022, 11, 27, 19, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, false, null, null, 4, 17, 16, 0 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "Date", "GoalsTeam1", "GoalsTeam2", "IsFinished", "Placeholder1", "Placeholder2", "Seed", "Team1", "Team2", "Venue" },
                values: new object[] { 29, new DateTime(2022, 11, 28, 10, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, false, null, null, 6, 27, 26, 7 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "Date", "GoalsTeam1", "GoalsTeam2", "IsFinished", "Placeholder1", "Placeholder2", "Seed", "Team1", "Team2", "Venue" },
                values: new object[] { 30, new DateTime(2022, 11, 28, 13, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, false, null, null, 7, 31, 30, 5 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "Date", "GoalsTeam1", "GoalsTeam2", "IsFinished", "Placeholder1", "Placeholder2", "Seed", "Team1", "Team2", "Venue" },
                values: new object[] { 31, new DateTime(2022, 11, 28, 16, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, false, null, null, 6, 24, 25, 6 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "Date", "GoalsTeam1", "GoalsTeam2", "IsFinished", "Placeholder1", "Placeholder2", "Seed", "Team1", "Team2", "Venue" },
                values: new object[] { 32, new DateTime(2022, 11, 28, 19, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, false, null, null, 7, 28, 29, 4 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "Date", "GoalsTeam1", "GoalsTeam2", "IsFinished", "Placeholder1", "Placeholder2", "Seed", "Team1", "Team2", "Venue" },
                values: new object[] { 33, new DateTime(2022, 11, 29, 15, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, false, null, null, 0, 1, 0, 1 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "Date", "GoalsTeam1", "GoalsTeam2", "IsFinished", "Placeholder1", "Placeholder2", "Seed", "Team1", "Team2", "Venue" },
                values: new object[] { 34, new DateTime(2022, 11, 29, 15, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, false, null, null, 0, 3, 2, 0 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "Date", "GoalsTeam1", "GoalsTeam2", "IsFinished", "Placeholder1", "Placeholder2", "Seed", "Team1", "Team2", "Venue" },
                values: new object[] { 35, new DateTime(2022, 11, 29, 19, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, false, null, null, 1, 6, 4, 3 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "Date", "GoalsTeam1", "GoalsTeam2", "IsFinished", "Placeholder1", "Placeholder2", "Seed", "Team1", "Team2", "Venue" },
                values: new object[] { 36, new DateTime(2022, 11, 29, 19, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, false, null, null, 1, 7, 5, 2 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "Date", "GoalsTeam1", "GoalsTeam2", "IsFinished", "Placeholder1", "Placeholder2", "Seed", "Team1", "Team2", "Venue" },
                values: new object[] { 37, new DateTime(2022, 11, 30, 15, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, false, null, null, 3, 15, 13, 7 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "Date", "GoalsTeam1", "GoalsTeam2", "IsFinished", "Placeholder1", "Placeholder2", "Seed", "Team1", "Team2", "Venue" },
                values: new object[] { 38, new DateTime(2022, 11, 30, 15, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, false, null, null, 3, 14, 12, 5 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "Date", "GoalsTeam1", "GoalsTeam2", "IsFinished", "Placeholder1", "Placeholder2", "Seed", "Team1", "Team2", "Venue" },
                values: new object[] { 39, new DateTime(2022, 11, 30, 19, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, false, null, null, 2, 9, 8, 6 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "Date", "GoalsTeam1", "GoalsTeam2", "IsFinished", "Placeholder1", "Placeholder2", "Seed", "Team1", "Team2", "Venue" },
                values: new object[] { 40, new DateTime(2022, 11, 30, 19, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, false, null, null, 2, 11, 10, 4 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "Date", "GoalsTeam1", "GoalsTeam2", "IsFinished", "Placeholder1", "Placeholder2", "Seed", "Team1", "Team2", "Venue" },
                values: new object[] { 41, new DateTime(2022, 12, 1, 15, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, false, null, null, 5, 21, 20, 3 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "Date", "GoalsTeam1", "GoalsTeam2", "IsFinished", "Placeholder1", "Placeholder2", "Seed", "Team1", "Team2", "Venue" },
                values: new object[] { 42, new DateTime(2022, 12, 1, 15, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, false, null, null, 5, 22, 23, 2 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "Date", "GoalsTeam1", "GoalsTeam2", "IsFinished", "Placeholder1", "Placeholder2", "Seed", "Team1", "Team2", "Venue" },
                values: new object[] { 43, new DateTime(2022, 12, 1, 19, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, false, null, null, 4, 18, 17, 1 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "Date", "GoalsTeam1", "GoalsTeam2", "IsFinished", "Placeholder1", "Placeholder2", "Seed", "Team1", "Team2", "Venue" },
                values: new object[] { 44, new DateTime(2022, 12, 1, 19, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, false, null, null, 4, 19, 16, 0 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "Date", "GoalsTeam1", "GoalsTeam2", "IsFinished", "Placeholder1", "Placeholder2", "Seed", "Team1", "Team2", "Venue" },
                values: new object[] { 45, new DateTime(2022, 12, 2, 15, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, false, null, null, 7, 30, 29, 7 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "Date", "GoalsTeam1", "GoalsTeam2", "IsFinished", "Placeholder1", "Placeholder2", "Seed", "Team1", "Team2", "Venue" },
                values: new object[] { 46, new DateTime(2022, 12, 2, 15, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, false, null, null, 7, 31, 28, 5 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "Date", "GoalsTeam1", "GoalsTeam2", "IsFinished", "Placeholder1", "Placeholder2", "Seed", "Team1", "Team2", "Venue" },
                values: new object[] { 47, new DateTime(2022, 12, 2, 19, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, false, null, null, 6, 26, 25, 6 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "Date", "GoalsTeam1", "GoalsTeam2", "IsFinished", "Placeholder1", "Placeholder2", "Seed", "Team1", "Team2", "Venue" },
                values: new object[] { 48, new DateTime(2022, 12, 2, 19, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, false, null, null, 6, 27, 24, 4 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "Date", "GoalsTeam1", "GoalsTeam2", "IsFinished", "Placeholder1", "Placeholder2", "Seed", "Team1", "Team2", "Venue" },
                values: new object[] { 49, new DateTime(2022, 12, 3, 15, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, false, "1st Group A", "2nd Group B", 8, null, null, 1 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "Date", "GoalsTeam1", "GoalsTeam2", "IsFinished", "Placeholder1", "Placeholder2", "Seed", "Team1", "Team2", "Venue" },
                values: new object[] { 50, new DateTime(2022, 12, 3, 19, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, false, "1st Group C", "2nd Group D", 8, null, null, 3 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "Date", "GoalsTeam1", "GoalsTeam2", "IsFinished", "Placeholder1", "Placeholder2", "Seed", "Team1", "Team2", "Venue" },
                values: new object[] { 51, new DateTime(2022, 12, 4, 19, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, false, "1st Group B", "2nd Group A", 8, null, null, 2 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "Date", "GoalsTeam1", "GoalsTeam2", "IsFinished", "Placeholder1", "Placeholder2", "Seed", "Team1", "Team2", "Venue" },
                values: new object[] { 52, new DateTime(2022, 12, 4, 15, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, false, "1st Group D", "2nd Group C", 8, null, null, 0 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "Date", "GoalsTeam1", "GoalsTeam2", "IsFinished", "Placeholder1", "Placeholder2", "Seed", "Team1", "Team2", "Venue" },
                values: new object[] { 53, new DateTime(2022, 12, 5, 15, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, false, "1st Group E", "2nd Group F", 8, null, null, 7 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "Date", "GoalsTeam1", "GoalsTeam2", "IsFinished", "Placeholder1", "Placeholder2", "Seed", "Team1", "Team2", "Venue" },
                values: new object[] { 54, new DateTime(2022, 12, 5, 19, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, false, "1st Group G", "2nd Group H", 8, null, null, 6 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "Date", "GoalsTeam1", "GoalsTeam2", "IsFinished", "Placeholder1", "Placeholder2", "Seed", "Team1", "Team2", "Venue" },
                values: new object[] { 55, new DateTime(2022, 12, 6, 15, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, false, "1st Group F", "2nd Group E", 8, null, null, 5 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "Date", "GoalsTeam1", "GoalsTeam2", "IsFinished", "Placeholder1", "Placeholder2", "Seed", "Team1", "Team2", "Venue" },
                values: new object[] { 56, new DateTime(2022, 12, 6, 19, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, false, "1st Group H", "2nd Group G", 8, null, null, 4 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "Date", "GoalsTeam1", "GoalsTeam2", "IsFinished", "Placeholder1", "Placeholder2", "Seed", "Team1", "Team2", "Venue" },
                values: new object[] { 57, new DateTime(2022, 12, 9, 15, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, false, "Winners Match 49", "Winners Match 50", 8, null, null, 5 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "Date", "GoalsTeam1", "GoalsTeam2", "IsFinished", "Placeholder1", "Placeholder2", "Seed", "Team1", "Team2", "Venue" },
                values: new object[] { 58, new DateTime(2022, 12, 9, 19, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, false, "Winners Match 53", "Winners Match 54", 8, null, null, 4 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "Date", "GoalsTeam1", "GoalsTeam2", "IsFinished", "Placeholder1", "Placeholder2", "Seed", "Team1", "Team2", "Venue" },
                values: new object[] { 59, new DateTime(2022, 12, 10, 19, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, false, "Winners Match 51", "Winners Match 52", 8, null, null, 0 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "Date", "GoalsTeam1", "GoalsTeam2", "IsFinished", "Placeholder1", "Placeholder2", "Seed", "Team1", "Team2", "Venue" },
                values: new object[] { 60, new DateTime(2022, 12, 10, 15, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, false, "Winners Match 55", "Winners Match 56", 8, null, null, 2 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "Date", "GoalsTeam1", "GoalsTeam2", "IsFinished", "Placeholder1", "Placeholder2", "Seed", "Team1", "Team2", "Venue" },
                values: new object[] { 61, new DateTime(2022, 12, 13, 19, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, false, "Winners Match 57", "Winners Match 58", 8, null, null, 4 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "Date", "GoalsTeam1", "GoalsTeam2", "IsFinished", "Placeholder1", "Placeholder2", "Seed", "Team1", "Team2", "Venue" },
                values: new object[] { 62, new DateTime(2022, 12, 14, 19, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, false, "Winners Match 59", "Winners Match 60", 8, null, null, 0 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "Date", "GoalsTeam1", "GoalsTeam2", "IsFinished", "Placeholder1", "Placeholder2", "Seed", "Team1", "Team2", "Venue" },
                values: new object[] { 63, new DateTime(2022, 12, 17, 15, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, false, "Losers Match 61", "Losers Match 62", 8, null, null, 1 });

            migrationBuilder.InsertData(
                table: "Matches",
                columns: new[] { "Id", "Date", "GoalsTeam1", "GoalsTeam2", "IsFinished", "Placeholder1", "Placeholder2", "Seed", "Team1", "Team2", "Venue" },
                values: new object[] { 64, new DateTime(2022, 12, 18, 15, 0, 0, 0, DateTimeKind.Unspecified), 0, 0, false, "Winners Match 61", "Winners Match 62", 8, null, null, 4 });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Matches");
        }
    }
}
