using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFIDSystemTest.Business.DTO
{
    public class UserSystemDTO
    {
        internal object updated;

        public int user { get; set; }
        public int rol { get; set; }
        public string user_name { get; set; }
        public string birth_date { get; set; }
        public string password { get; set; }

    }
}
