using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFL
{
    class Team
    {
        public string Name { get; set; }
        public DateTime FoundingYear { get; set; }
        public string City { get; set; }
        public string[] Jerseys { get; set; }
        public List<Player> Players { get; set; }
        public List<Coach> Coaches { get; set; }

        public Team(string dataRow, List<Player> players, List<Coach> coaches)
        {
            var data = dataRow.Split(';');
            Name = data[0];
            FoundingYear = DateTime.Parse(data[1]);
            City = data[2];
            Jerseys = data[3].Split(',');
            Players = players.Where(player => player.TeamName == this.Name).ToList();
            Coaches = coaches.Where(coach => coach.TeamName == this.Name).ToList();
        }
    }
}
