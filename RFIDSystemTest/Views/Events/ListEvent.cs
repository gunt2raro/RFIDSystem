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
    public partial class ListEvent : UserControl
    {
        public EventControl event_control;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="event_control"></param>
        public ListEvent( EventControl event_control )
        {
            InitializeComponent();

            this.event_control = event_control;

        }// End of Constructor function
    }
}
