using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFIDSystemTest.Data.Competitors
{
    public class Team
    {
        public int id { get; set; }

        public string name { get; set; }
        public string description { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string country { get; set; }

        public DateTime timestamp { get; set; }
        public DateTime updated { get; set; }

    }
}
