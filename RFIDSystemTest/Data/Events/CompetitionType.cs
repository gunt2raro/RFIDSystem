using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFIDSystemTest.Data.Events
{
    /// <summary>
    /// CompetitionType class
    /// Class Reference : /Cronometraje/Sistema/UML.doc > Events
    /// </summary>
    public class CompetitionType
    {
        public int id { get; set; }

        public string name { get; set; }
        public string description { get; set; }

        public DateTime timestamp { get; set; }
        public DateTime updated { get; set; }

    }// End of Competition Type class
}
