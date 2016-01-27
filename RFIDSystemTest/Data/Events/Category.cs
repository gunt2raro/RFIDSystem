using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFIDSystemTest.Data.Events
{
    /// <summary>
    /// Category class
    /// Class Reference : /Cronometraje/Sistema/UML.doc > Events
    /// </summary>
    public class Category
    {
        public int id { get; set; }

        public int user { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public int age_1 { get; set; }
        public int age_2 { get; set; }
        public string color { get; set; }

        public DateTime timestamp { get; set; }
        public DateTime updated { get; set; }

    }// End of Category class
}
