using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFIDSystemTest.Business.DTO
{
    /// <summary>
    /// Register data transfer object
    /// </summary>
    public class RegisterDTO
    {
        public int competitor { get; set; }
        public int competition { get; set; }
        public int category { get; set; }
        public int competitor_num { get; set; }
        //public int user { get; set; }
        public int register_state { get; set; }
        public int kit_state { get; set; }

    }// End of RegisterDTO class
}
