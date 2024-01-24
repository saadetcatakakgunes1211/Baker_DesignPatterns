﻿namespace Baker_DesignPatterns.CQRSPattern.Results.TeamResults
{
    public class GetTeamByIdQueryResult
    {
        public int TeamID { get; set; }
        public string NameSurname { get; set; }
        public string Title { get; set; }
        public string ImageUrl { get; set; }
    }
}
