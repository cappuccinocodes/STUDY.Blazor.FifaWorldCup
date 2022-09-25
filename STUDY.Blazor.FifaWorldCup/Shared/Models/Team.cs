﻿namespace STUDY.Blazor.FifaWorldCup.Shared.Models
{
    public class Team
    {
        public string Name { get; set; }
        public int Points { get; set; }
        public int Ranking { get; set; }
        public int Goals { get; set; }
        public int GoalsAgainst { get; set; }
        public int GoalsDifference { get; set; }
    }
}