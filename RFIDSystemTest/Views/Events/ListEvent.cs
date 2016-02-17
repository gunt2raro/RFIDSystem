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
using RFIDSystemTest.Views.VO;
using RFIDSystemTest.Warriror;

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
            
            dataEvents.DataSource = event_control.event_service.getAll(null).Select(
                o => new EventVO() {
                    id = o.id,
                    name = o.name,
                    date_start = o.date_start,
                    date_finish = o.date_finish,
                    date_limit = o.date_limit,
                    competitors_limit = o.competitors_limit }).ToList();

        }// End of loadData function

        /// <summary>
        /// List Event Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListEvent_Load(object sender, EventArgs e)
        {
            // Load data
            loadData();
            // Theme shit
            ThemeShit();
            // Load resources
            bNew.Text = EventResource.bNew;
            bEdit.Text = EventResource.bEdit;
            bReturn.Text = EventResource.bReturn;
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
            ControlHelper.LoadControlOnControl( event_control, event_control.menu_event_control );
        }// End of bReturn Click function

        /// <summary>
        /// theme shit
        /// </summary>
        public void ThemeShit()
        {
            ThemeDark.ResponsiveDesign( this, Parent.Parent, 1, 1 );
            ThemeDark.SetButtonsTheme(this);
            this.BackColor = Color.FromArgb( 248, 248, 248 );
            ThemeDark.SetDataGridViewResponsiveWidth(dataEvents, this, 1);
            ThemeDark.SetDataGridViewResponsiveHeight(dataEvents, this, .50);
            pButtons.Width = Parent.Parent.Width;
            pButtons.BackColor = Color.FromArgb(80, 102, 127);
            pButtons.BorderStyle = BorderStyle.None;
        }// end of ThemeShit function

        /// <summary>
        /// TxtSearch text changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {

        }// End of txtSearch_TextChanged function

        /// <summary>
        /// Button search click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bSearch_Click(object sender, EventArgs e)
        {
            string query = txtSearch.Text;

            if (query != TWords.EMPTY && query != " ")
            {
                IEnumerable<Event> events_o = from event_o in event_control.event_service.getAll(null).ToList() where event_o.name.Contains(query) select event_o;
                dataEvents.DataSource = events_o.Select(
                    o => new EventVO()
                    {
                        id = o.id,
                        name = o.name,
                        date_start = o.date_start,
                        date_finish = o.date_finish,
                        date_limit = o.date_limit,
                        competitors_limit = o.competitors_limit
                    }).ToList();
            }
            else if (query == "")
            {
                loadData();
            }
            else
            {
                ControlHelper.WarningBox("Need to put something on the search box first!!");
            }
        }// End of bSearch_Click function

    }// End of ListEvent control class
}
