using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFIDSystemTest.Business.Adapters.Events
{
    public class Price
    {
        public int id;

        public string name {get; set; }
        public string description { get; set; }
        public string image_url { get; set; }
        public int _event { get; set; }
        public DateTime timestamp { get; set; }
        public DateTime updated { get; set; }

    }
}
