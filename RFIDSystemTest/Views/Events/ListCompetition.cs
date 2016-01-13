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
    public partial class ListCompetition : UserControl
    {
        public CompetitionControl competition_control;

        public ListCompetition( CompetitionControl competition_control )
        {
            InitializeComponent();

            this.competition_control = competition_control;

        }
    }
}
