using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFIDSystemTest.Business.DTO.Events
{
    /// <summary>
    /// Event type data transfer object
    /// </summary>
    public class EventTypeDTO
    {
        public int id { get; set; }
        public string name { get; set; }
        public string description { get; set; }
    }// End of Event type dto class
}
