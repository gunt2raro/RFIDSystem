using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFIDSystemTest.Views.VO
{
    /// <summary>
    /// Competition Value Object
    /// </summary>
    public class CompetitionVO
    {
        [DisplayName( "ID" )]
        public int id { get; set; }
        [DisplayName("Name")]
        public string name { get; set; }
        [DisplayName("Competitors")]
        public int competitors_limit { get; set; }

    }// End of Competition VO class
}
