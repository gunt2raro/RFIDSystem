using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFIDSystemTest.Data.Users
{
    public class Rol
    {
        public int id { get; set; }

        public string name { get; set; }
        public string description { get; set; }
        public int value { get; set; }

        public DateTime timestamp { get; set; }
        public DateTime updated { get; set; }

    }// End of Rol class
}
