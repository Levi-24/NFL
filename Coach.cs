using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NFL
{
    class Coach
    {
        public string Name { get; set; }
        public string TeamName { get; set; }

        public Coach(string dataRow)
        {
            var data = dataRow.Split(';');
            Name = data[0];
            TeamName = data[1];
        }
    }
}
