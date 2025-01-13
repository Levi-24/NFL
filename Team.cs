namespace NFL
{
    public partial class Team
    {
        public string Name { get; set; }
        public int FoundingYear { get; set; }
        public string City { get; set; }
        public List<string> Jerseys { get; set; }
        public List<Player> Players { get; set; }
        public List<Coach> Coaches { get; set; }

        public Team(string dataRow, List<Player> players, List<Coach> coaches)
        {
            var data = dataRow.Split(';');
            Name = data[0];
            FoundingYear = Convert.ToInt32(data[1]);
            City = data[2];
            Jerseys = data[3].Split(',').ToList();
            Players = players.Where(player => player.TeamName == this.Name).ToList();
            Coaches = coaches.Where(coach => coach.TeamName == this.Name).ToList();
        }
    }
}
