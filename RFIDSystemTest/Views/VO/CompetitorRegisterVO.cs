using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFIDSystemTest.Views.VO
{
    /// <summary>
    /// competitor register value object class
    /// </summary>
    public class CompetitorRegisterVO
    {

        [DisplayName("ID")]
        public int id { get; set; }
        [DisplayName("Full Name")]
        public string full_name { get; set; }

    }// End of CompetitorRegisterVO class
}
