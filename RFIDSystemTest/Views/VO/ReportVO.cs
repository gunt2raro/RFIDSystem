using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFIDSystemTest.Views.VO
{
    /// <summary>
    /// Report value object
    /// </summary>
    public class ReportVO
    {
        public int global_score { get; set; }
        public int category_score { get; set; }
        public int competitor_num { get; set; }
        public string competitors_name { get; set; }
        public string category { get; set; }
        public IList<string> times { get; set; }
        public string total_time { get; set; }
        public bool disqualified { get; set; }

        /// <summary>
        /// Report VO constructor
        /// </summary>
        public ReportVO() {
            times = new List<string>();
        }// End of ReportVO constructor

    }// End of Report VO class
}
