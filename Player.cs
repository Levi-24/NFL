using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFL
{
    class Player
    {
        public string Name { get; set; }
        public string TeamName { get; set; }

        public Player(string dataRow)
        {
            var data = dataRow.Split(';');
            Name = data[0];
            TeamName = data[1];
        }
    }
}
