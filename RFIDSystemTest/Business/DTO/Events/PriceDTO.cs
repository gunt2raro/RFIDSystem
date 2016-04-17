using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFIDSystemTest.Business.DTO.Events
{
    public class PriceDTO
    {
        public string name { get; set; }
        public string description { get; set; }
        public string image_url { get; set; }
        public int _event { get; set; }
        public string timestamp { get; set; }
        public string updated { get; set; }
    }
}
