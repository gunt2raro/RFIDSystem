using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFIDSystemTest.Business.DTO
{
    /// <summary>
    /// Register state data transfer object
    /// </summary>
    public class RegisterStateDTO
    {

        public string description { get; set; }
        public int value { get; set; }

        public string timestamp { get; set; }
        public string updated { get; set; }
    }// End of RegisterSTateDTO class
}
