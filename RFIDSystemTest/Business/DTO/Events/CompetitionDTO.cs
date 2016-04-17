using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFIDSystemTest.Business.DTO
{
    /// <summary>
    /// Competition data transfer object
    /// </summary>
    public class CompetitionDTO
    {
        public int user { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string date_start { get; set; }
        public string date_finish { get; set; }
        public string image_url { get; set; }
        public int[] categories { get; set; }
        public int competition_type { get; set; }
        public int competitors_limit { get; set; }
        public int competition_event { get; set; }
        public float cost { get; set; }


        public string timestamp { get; set; }
        public string updated { get; set; }

    }// End of CompetitorDTO class
}
