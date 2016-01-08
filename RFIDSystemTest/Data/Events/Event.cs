using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFIDSystemTest.Data.Events
{
    /// <summary>
    /// Event class
    /// Class Reference : /Cronometraje/Sistema/UML.doc > Events
    /// </summary>
    public class Event
    {
        public int id { get; set; }

        public User user { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public DateTime date_start { get; set; }
        public DateTime date_finish { get; set; }
        public string image_url { get; set; }
        public DateTime date_limit { get; set; }
        public int competitors_limit  { get; set; }

        public DateTime timestamp { get; set; }
        public DateTime updated { get; set; }

    }// End of Event class
}
