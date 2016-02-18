using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFIDSystemTest.Data
{

    public class User
    {

        public string username { get; set; }
        public string first_name { get; set; }
        public string last_name { get; set; }
        public bool is_active { get; set; }
        public bool is_superuser { get; set; }
        public bool is_staff { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public int pk { get; set; }

    }// End of user model class
}
