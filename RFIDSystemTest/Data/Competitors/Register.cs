using RFIDSystemTest.Data.Events;
using RFIDSystemTest.Data.States;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFIDSystemTest.Data.Competitors
{
    /// <summary>
    /// Register class
    /// Class Reference : /Cronometraje/Sistema/UML.doc > Competitors
    /// </summary>
    public class Register
    {
        public int id { get; set; }

        public int competitor { get; set; }
        public int competition { get; set; }
        public int category { get; set; }
        public int competitor_num { get; set; }
        public int user { get; set; }
        public int register_state { get; set; }
        public int kit_state { get; set; }

        public DateTime timestamp { get; set; }
        public DateTime updated { get; set; }

    }//End fo Register class
}
