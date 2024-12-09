using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFL
{
    public partial class Player
    {
        public string Name { get; set; }
        public string TeamName { get; set; }
        public int Number { get; set; }
        public string Position { get; set; }
        public float Height { get; set; } //feet & inches
        public int Weight { get; set; } //pounds
        public int Age { get; set; }
        public string Experience { get; set; } //in years / R = rookie
        public string College { get; set; }

        //PlayerName        Num	Pos	HT	WT	Age	Exp	College
        //Nelson Agholor    15	WR	6-0	200	31	10	USC

        public Player(string dataRow)
        {
            var data = dataRow.Split(';');
            Name = data[0];
            TeamName = data[1];
            Number = int.Parse(data[2]);
            Position = data[3];
            Height = float.Parse(data[4].Replace('-',','));
            Weight = int.Parse(data[5]);
            Age = int.Parse(data[6]);
            Experience = data[7];
            College = data[8];
        }
    }
}
