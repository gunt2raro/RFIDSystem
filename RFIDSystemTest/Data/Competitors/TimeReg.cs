using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace RFIDSystemTest.Data.Competitors
{
    /// <summary>
    /// TimeReg class
    /// Class Reference : /Cronometraje/Sistema/UML.doc > Competitors
    /// </summary>
    public class TimeReg
    {
        public int id { get; set; }

        public int register { get; set; }
        public string time { get; set; }

        public DateTime timestamp { get; set; }
        public DateTime updated { get; set; }

    }// End of Time Reg Class
}
