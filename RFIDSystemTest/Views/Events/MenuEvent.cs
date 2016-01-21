using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RFIDSystemTest.Helpers;

namespace RFIDSystemTest.Views.Events
{
    /// <summary>
    /// Menu Event Control
    /// </summary>
    public partial class MenuEvent : UserControl
    {
        public EventControl event_control;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="event_control"></param>
        public MenuEvent( EventControl event_control )
        {
            InitializeComponent();
            this.event_control = event_control;

            this.AutoScaleMode = AutoScaleMode.Inherit;
        }// End of Constructor function 

        /// <summary>
        /// Button list click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bList_Click(object sender, EventArgs e)
        {
            ControlHelper.LoadControlOnControl( event_control, event_control.list_event_control );
            event_control.list_event_control.loadData();
        }// End of bList_Click function

    }// End of Menu Event control class
}
