using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFIDSystemTest.Business.DTO
{
    public class RolDTO
    {
        public string name { get; set; }
        public string description { get; set; }
        public int value { get; set; }

        public string timestamp { get; set; }
        public string updated { get; set; }
    }
}
