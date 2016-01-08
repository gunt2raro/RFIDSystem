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
        public int id { get; set; }

        public User user { get; set; }
        public Rol rol { get; set; }
        public String user_name { get; set; }
        public DateTime birth_date { get; set; }

    }//End of UserSystem class
}
