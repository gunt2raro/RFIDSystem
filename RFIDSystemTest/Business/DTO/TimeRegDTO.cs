using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFIDSystemTest.Business.DTO
{
    /// <summary>
    /// Time Reg data transfer object
    /// </summary>
    public class TimeRegDTO
    {

        public RegisterDTO register { get; set; }

        public string timestamp { get; set; }
        public string updated { get; set; }
    }// End of TimeRegDTO class
}
