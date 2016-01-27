using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFIDSystemTest.Business.DTO
{
    /// <summary>
    /// Category data transfer object
    /// </summary>
    public class CategoryDTO
    {

        // pal rato public int user { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public int age_1 { get; set; }
        public int age_2 { get; set; }
        public string color { get; set; }

        public string timestamp { get; set; }
        public string updated { get; set; }

    }// End of Category Data Transfer Object class
}
