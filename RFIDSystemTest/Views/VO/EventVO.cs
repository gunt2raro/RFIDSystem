using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFIDSystemTest.Views.VO
{
    /// <summary>
    /// Event value object
    /// </summary>
    public class EventVO
    {
        [DisplayName("ID")]
        public int id { get; set; }
        [DisplayName("Name")]
        public string name { get; set; }
        [DisplayName("Limit Date")]
        public DateTime date_limit { get; set; }
        [DisplayName("Competitors")]
        public int competitors_limit { get; set; }

    }// End of EventvO class
}
