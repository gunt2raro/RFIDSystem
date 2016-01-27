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
using RFIDSystemTest.Data.Events;
using RFIDSystemTest.Resources;
using RFIDSystemTest.Warriror;

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
                else if (c.GetType() == typeof(NumericUpDown))
                {
                    c.ResetText();
                }
            }
        }// End of Clean Field function

        /// <summary>
        /// Button cancel click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bCancel_Click(object sender, EventArgs e)
        {
            ControlHelper.LoadControlOnControl( event_control, event_control.menu_event_control );
        }// End of bCancel_Click function

        /// <summary>
        /// Button add click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bAdd_Click(object sender, EventArgs e)
        {
            event_control.event_service.addEvent( createObject(), null );
        }// End of bAdd_Click function

        /// <summary>
        /// Create object
        /// </summary>
        /// <returns></returns>
        public Event createObject()
        {

            Event eve = new Event();

            eve.name = txtName.Text;
            eve.description = txtName.Text;
            eve.date_start = dtDateStart.Value;
            eve.date_finish = dtDateFinish.Value;
            eve.date_limit = dtDateLimit.Value;
            eve.competitors_limit = (int)nudCompetitorsLimit.Value;
            eve.image_url = "";

            return eve;

        }// End of createObject function

        /// <summary>
        /// New Event load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewEvent_Load(object sender, EventArgs e)
        {
            ThemeShit();
            lName.Text = EventResource.name;
            lDescription.Text = EventResource.description;
            lDateStart.Text = EventResource.date_start;
            lDateFinish.Text = EventResource.date_finish;
            lDateLimit.Text = EventResource.date_limit;
            lCompetitorsLimit.Text = EventResource.competitors_limit;
            bCancel.Text = EventResource.bCancel;
        }// End of NewEvent_Load function

        /// <summary>
        /// Theme shit
        /// </summary>
        public void ThemeShit() {
            ThemeDark.ResponsiveDesign( this, Parent.Parent, 1, 1 );
            ThemeDark.SetButtonsTheme(this);
            ThemeDark.SetLabelsTheme(this);
        }// End of ThemeShit function

    }// End of New Event control class
} 
