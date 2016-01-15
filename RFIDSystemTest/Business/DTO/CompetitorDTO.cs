using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFIDSystemTest.Business.DTO
{
    /// <summary>
    /// Competitor Data Transfer Object
    /// </summary>
    public class CompetitorDTO
    {

        public string name { get; set; }
        public string second_name { get; set; }
        public string birth_date { get; set; }
        public string city { get; set; }
        public string state { get; set; }
        public string country { get; set; }
        public int zip_code { get; set; }
        public string address { get; set; }
        public string email { get; set; }
        /// pal rato public int user { get; set; }
        public string timestamp { get; set; }
        public string updated { get; set; }

    }// End of Competitor data transfer object class
}
