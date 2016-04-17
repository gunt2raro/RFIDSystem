using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFIDSystemTest.Business.DTO.Users
{
    public class UserDTO
    {
        public string username { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public int pk { get; set; }
    }
}
