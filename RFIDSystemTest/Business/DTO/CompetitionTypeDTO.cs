using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFIDSystemTest.Business.DTO
{
    /// <summary>
    /// Competition Type data transfer object
    /// </summary>
    public class CompetitionTypeDTO
    {
        public string name { get; set; }
        public string description { get; set; }

        public string timestamp { get; set; }
        public string updated { get; set; }
    }// End of CompetitionTypeDTO class
}
