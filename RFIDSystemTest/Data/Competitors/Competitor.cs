using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFIDSystemTest.Data.Competitors
{
    /// <summary>
    /// Competitor class
    /// Class Reference : /Cronometraje/Sistema/UML.doc > Competitors
    /// </summary>
    public class Competitor
    {
        public int id { get; set; }

        public string name { get; set; }
        public string second_name { get; set; }
        public DateTime birth_date { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string country { get; set; } 
        public int zip_code { get; set; }
        public string address { get; set; }
        public string address2 { get; set; }
        public string email { get; set; }
        public int user { get; set; }

        public int sex { get; set; }
        public string phone_number { get; set;  }

        public DateTime timestamp { get; set; }
        public DateTime updated { get; set; }

    }// End of Competitor class
}
