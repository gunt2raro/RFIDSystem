using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RFIDSystemTest.Views.Events
{
    public partial class MenuCompetition : UserControl
    {
        public CompetitionControl competition_control;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="competition_control"></param>
        public MenuCompetition( CompetitionControl competition_control )
        {
            InitializeComponent();

            this.competition_control = competition_control;

        }// End of Constructor function
    }
}
