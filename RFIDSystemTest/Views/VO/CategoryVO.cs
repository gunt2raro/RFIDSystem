using RFIDSystemTest.Resources;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RFIDSystemTest.Views.VO
{
    /// <summary>
    /// Category value object
    /// </summary>
    public class CategoryVO
    {
        [DisplayName("ID")]
        public int id { get; set; }
        [DisplayName("Name")]
        public string name { get; set; }
        [DisplayName("Description")]
        public string description { get; set; }
        [DisplayName("Ages")]
        public string ages { get; set; }
        [DisplayName("Color")]
        public Color color { get; set; }

    }// End of CategoryVO class
}
