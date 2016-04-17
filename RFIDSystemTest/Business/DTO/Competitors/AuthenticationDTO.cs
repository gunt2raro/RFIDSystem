using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFIDSystemTest.Business.DTO
{
    /// <summary>
    /// Authentication data transfer object
    /// </summary>
    public class AuthenticationDTO
    {
        public CompetitorDTO competitor { get; set; }
        public string password { get; set; }

        public string timestamp { get; set; }
        public string updated { get; set; }

    }// End of AuthenticationDTO class
}
