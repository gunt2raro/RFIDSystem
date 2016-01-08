using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFIDSystemTest.Data.Competitors
{
    /// <summary>
    /// Authentication class
    /// Class Reference : /Cronometraje/Sistema/UML.doc > Competitors
    /// </summary>
    public class Authentication
    {
        public int id { get; set; }

        public Competitor competitor { get; set; }
        public string password { get; set; }

        public DateTime timestamp { get; set; }
        public DateTime updated { get; set; }

    }// ENd of Authentication class
}
