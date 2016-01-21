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
using RFIDSystemTest.Resources;
using RFIDSystemTest.Data.Events;

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

        /// <summary>
        /// Load Data
        /// </summary>
        internal void loadData()
        {
            dataEvents.DataSource = event_control.event_service.getAll(null);
            dataEvents.Refresh();
        }// End of loadData function

        /// <summary>
        /// List Event Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListEvent_Load(object sender, EventArgs e)
        {
            loadData();
        }// End of ListEvent_Load function

        /// <summary>
        /// Button new click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bNew_Click(object sender, EventArgs e)
        {
            ControlHelper.LoadControlOnControl( event_control, event_control.new_event_control );
            event_control.new_event_control.cleanFields();
        }// End of bNew_Click function

        /// <summary>
        /// Button edit click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bEdit_Click(object sender, EventArgs e)
        {

            if (dataEvents.SelectedRows != null)
            {

                using (DataGridViewRow row = dataEvents.SelectedRows[0])
                {
                    event_control.detail_event_control.event_o = event_control.event_service.getById(int.Parse(row.Cells[0].Value.ToString()), null);
                    event_control.detail_event_control.loadData();
                    ControlHelper.LoadControlOnControl(event_control, event_control.detail_event_control);
                }

            }
            else
            {
                ControlHelper.WarningBox(String.Format(WarningResource.SelectRow, typeof(Event).ToString()));
            }

        }// End of bEdit_Click function

        /// <summary>
        /// Button return click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bReturn_Click(object sender, EventArgs e)
        {
            ControlHelper.LoadControlOnControl( event_control, event_control.list_event_control );
            event_control.list_event_control.loadData();
        }// End of bReturn Click function

    }// End of ListEvent control class
}
