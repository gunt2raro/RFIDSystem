using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RFIDSystemTest.Views.Competitors
{
    public partial class SearchCompetitor : UserControl
    {
        public CompetitorControl competitor_control;

        /// <summary>
        /// Constructor 
        /// </summary>
        /// <param name="competitor_control"></param>
        public SearchCompetitor( CompetitorControl competitor_control )
        {
            InitializeComponent();
            this.competitor_control = competitor_control;
        }// End of Constructor function 
    
    }
}
