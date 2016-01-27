using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RFIDSystemTest.Data.Events;

namespace RFIDSystemTest.Views.Events
{
    /// <summary>
    /// Detail competition control
    /// </summary>
    public partial class DetailCompetition : UserControl
    {
        public CompetitionControl competition_control;

        public Competition competition;


        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="competition_control"></param>
        public DetailCompetition( CompetitionControl competition_control )
        {
            InitializeComponent();

            this.competition_control = competition_control;

        }// End of Constructor function
        
        /// <summary>
        /// Load data
        /// </summary>
        public void loadData()
        {
        }// End of load Data function
        
    }// end of Detail Competition control class
}
