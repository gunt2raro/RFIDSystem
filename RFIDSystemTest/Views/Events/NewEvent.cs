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
    /// <summary>
    /// New Event control
    /// </summary>
    public partial class NewEvent : UserControl
    {
        public EventControl event_control;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="event_control"></param>
        public NewEvent( EventControl event_control )
        {
            InitializeComponent();

            this.event_control = event_control;

        }// End of New Event Constructor

        /// <summary>
        /// Clean Fields
        /// </summary>
        public void cleanFields()
        {
            foreach (Control c in Controls)
            {
                if (c.GetType() == typeof(TextBox))
                {
                    c.ResetText();
                }
                else if (c.GetType() == typeof(DateTimePicker))
                {
                    c.ResetText();
                }
            }
        }// End of Clean Field function

    }// End of New Event control class
}
