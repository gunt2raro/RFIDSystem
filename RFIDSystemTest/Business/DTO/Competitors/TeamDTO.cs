using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFIDSystemTest.Business.DTO
{
    public class TeamDTO
    {
        public string name { get; set; }
        public string description { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string country { get; set; }

        public string timestamp { get; set; }
        public string updated { get; set; }
    }
}
