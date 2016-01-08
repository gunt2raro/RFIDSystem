using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFIDSystemTest.Data.States
{
    /// <summary>
    /// RegisterState
    /// Class Reference : /Cronometraje/Sistema/UML.doc > States
    /// </summary>
    public class RegisterState
    {
        public int id { get; set; }

        public string description { get; set; }
        public int value { get; set; }

        public DateTime timestamp { get; set; }
        public DateTime updated { get; set; }

    }// End of Register State class
}
