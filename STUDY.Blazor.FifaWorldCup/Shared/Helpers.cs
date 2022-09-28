using STUDY.Blazor.FifaWorldCup.Shared.Models;

namespace STUDY.Blazor.FifaWorldCup.Shared;

public class Helpers
{
    public static List<Team> GetTeams(List<Match> matches)
    {
        var teams = new List<Team>();
        var teamNames = matches.Select(m => m.Team1).Concat(matches.Select(m => m.Team2)).Distinct();
        foreach (var team in teamNames)
        {
            var groupData = GetGroupData(team, matches);
            teams.Add(new Team
            {
                Name = team,
                Points = groupData[0],
                Goals = groupData[1],
                GoalsAgainst = groupData[2],
                GoalsDifference = groupData[3],
                MatchesPlayed = groupData[4]
            });
        }

        return teams.OrderByDescending(x => x.Points)
        .ThenBy(x => x.GoalsDifference)
        .ThenBy(x => x.Goals)
        .ToList();
    }

    internal static int[] GetGroupData(Country team, List<Match> matches)
    {
        var result = new int[5];
        var points = 0;
        var goals = 0;
        var goalsAgainst = 0;
        var matchesPlayed = 0;

        foreach (var match in matches)
        {
            if (match.IsFinished)
            {
                if (match.Team1 == team)
                {
                    if (match.GoalsTeam1 > match.GoalsTeam2)
                    {
                        points += 3;
                    }
                    else if (match.GoalsTeam1 == match.GoalsTeam2)
                    {
                        points += 1;
                    }

                    goals = match.GoalsTeam1 + goals;
                    goalsAgainst = match.GoalsTeam2 + goalsAgainst;
                    matchesPlayed += 1;

                }
                else if (match.Team2 == team)
                {
                    if (match.GoalsTeam2 > match.GoalsTeam1)
                    {
                        points += 3;
                    }
                    else if (match.GoalsTeam1 == match.GoalsTeam2)
                    {
                        points += 1;
                    }

                    goals = match.GoalsTeam2 + goals;
                    goalsAgainst = match.GoalsTeam1 + goalsAgainst;
                    matchesPlayed += 1;
                }

                var goalDifference = goals - goalsAgainst;

                result[0] = points;
                result[1] = goals;
                result[2] = goalsAgainst;
                result[3] = goalDifference;
                result[4] = matchesPlayed;
            }
        }

        return result;
    }
}
