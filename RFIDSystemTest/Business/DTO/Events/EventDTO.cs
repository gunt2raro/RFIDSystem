using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFIDSystemTest.Business.DTO
{
    /// <summary>
    /// Event data transfer object
    /// </summary>
    public class EventDTO
    {
        public int user { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string date_start { get; set; }
        public string date_finish { get; set; }
        public string image_url { get; set; }
        public string date_limit { get; set; }
        public int competitors_limit { get; set; }

    }// End of Event DTO class
}
