using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFIDSystemTest.Data.Users
{
    /// <summary>
    /// UserSystem
    /// Class Reference : /Cronometraje/Sistema/UML.doc > Users
    /// </summary>
    public class UserSystem
    {
        public int user_id { get; set; }

        public int user { get; set; }
        public int rol { get; set; }
        public string user_name { get; set; }
        public DateTime birth_date { get; set; }
        public string password { get; set; }

    }//End of UserSystem class
}
