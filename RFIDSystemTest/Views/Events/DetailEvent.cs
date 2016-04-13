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
using RFIDSystemTest.Helpers;
using RFIDSystemTest.Resources;
using RFIDSystemTest.Warriror;
using RFIDSystemTest.Views.VO;
using System.Net;
using System.IO;

namespace RFIDSystemTest.Views.Events
{
    /// <summary>
    /// Detail event control
    /// </summary>
    public partial class DetailEvent : UserControl
    {
        public EventControl event_control;
        public Event event_o;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="event_control"></param>
        public DetailEvent( EventControl event_control )
        {
            // Default stuff
            InitializeComponent();
            /// Load the event control injected
            this.event_control = event_control;
        }// End of Constructor function

        /// <summary>
        /// Load data
        /// </summary>
        public void loadData()
        {
            // Load the data to the fields
            lIdDescription.Text = event_o.id.ToString();
            txtName.Text = event_o.name;
            txtDescription.Text = event_o.description;
            dtDateStart.Value = event_o.date_start;
            dtDateFinish.Value = event_o.date_finish;
            dtDateLimit.Value = event_o.date_limit;
            nudCompetitorsLimit.Value = event_o.competitors_limit;
            // Load Competitions data
            dataCompetitions.DataSource = this.event_control.competition_service.getCompetitionsByEvent(event_o, null).Select(
                c => new CompetitionVO() {
                    id = c.id,
                    name = c.name,
                    competitors_limit = c.competitors_limit}).ToList();
            // Verify if the image is null or not, bitch!!!
            if (event_o.image_url != "")
            {
                // Load the request with the event image url
                HttpWebRequest httpWebRequest = (HttpWebRequest)HttpWebRequest.Create(event_o.image_url);
                // Get the response
                HttpWebResponse httpWebResponse = (HttpWebResponse)httpWebRequest.GetResponse();
                // Get the streaming data from the response
                Stream stream = httpWebResponse.GetResponseStream();
                // Set the streamed image on the picture box
                pictureBox1.Image = Image.FromStream(stream);
            }// End of image validation

        }// End of loadData function

        /// <summary>
        /// Detail event load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DetailEvent_Load(object sender, EventArgs e)
        {
            // Load theme
            ThemeShit();
            // Load data
            loadData();
            // All the resources stuff
            lId.Text = EventResource.id;
            lName.Text = EventResource.name;
            lDescription.Text = EventResource.description;
            lDateStart.Text = EventResource.date_start;
            lDateFinish.Text = EventResource.date_finish;
            lDateLimit.Text = EventResource.date_limit;
            lCompetitorsLimit.Text = EventResource.competitors_limit;
            bCancel.Text = EventResource.bCancel;
            bUpdate.Text = EventResource.bUpdate;
        }// End of DetailEvent_Load function

        /// <summary>
        /// Create object
        /// </summary>
        /// <returns></returns>
        public Event createObject()
        {
            Event eve = new Event();

            eve.id = int.Parse(lIdDescription.Text);
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
        /// Button enable click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bEnable_Click(object sender, EventArgs e)
        {
            foreach (Control c in Controls)
            {
                if (c.GetType() == typeof(TextBox))
                {
                    c.Enabled = true;
                }
                else if (c.GetType() == typeof(DateTimePicker))
                {
                    c.Enabled = true;
                }
            }
        }// End of bEnable click button

        /// <summary>
        /// Button update click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bUpdate_Click(object sender, EventArgs e)
        {
            Event eve = event_control.event_service.updateEvent(createObject(), null);
            // Event validation
            if (eve != null)
            {
                // Send success box
                ControlHelper.SuccessBox(String.Format(SuccessResource.UpdateSuccessful, typeof(Event).ToString(), String.Format("{0}", eve.name)));
                // load all data to the list event_control
                event_control.list_event_control.loadData();
                // Load list event control
                ControlHelper.LoadControlOnControl(event_control, event_control.list_event_control);
            }// End of event validation
            else// else if null
            {
                // REturn error bo on upgrading error
                ControlHelper.ErrorBox(String.Format(ErrorResource.UpgradingError, typeof(Event).ToString()), 0);
            }// End of else validation

        }// End of bUpdate_Click function

        /// <summary>
        /// Button clancel click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bCancel_Click(object sender, EventArgs e)
        {
            ControlHelper.LoadControlOnControl(event_control, event_control.list_event_control);
            event_control.list_event_control.loadData();
        }// End of bCancel_Click function

        /// <summary>
        /// theme shit
        /// </summary>
        public void ThemeShit()
        {
            ThemeDark.ResponsiveDesign(this, Parent.Parent, 1, 1);
            ThemeDark.SetButtonsTheme(this);
            ThemeDark.SetLabelsTheme(this);
        }// end of ThemeShit function

        /// <summary>
        /// Button edit click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bEdit_Click(object sender, EventArgs e)
        {

        }// End of bEdit_Click function

        /// <summary>
        /// Button add click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bAdd_Click(object sender, EventArgs e)
        {
            ControlHelper.LoadControlOnControl(event_control, event_control.new_competition_control);
            event_control.new_competition_control.cleanFields();
            event_control.new_competition_control.event_id = event_o.id;
        }// End of bAdd_Click function

        /// <summary>
        /// Button register click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bRegiter_Click(object sender, EventArgs e)
        {
            // Get the competition id
            int compt_id = getCompetitionID();
            // Validate if the competition id is not 0, just in case
            if ( compt_id != 0 )
            {
                // Clear new register control fileds
                event_control.new_register_control.clearFields();
                // Set on new register control teh competition id
                event_control.new_register_control.competition_id = compt_id;
                // Set on the new register contorl event id
                event_control.new_register_control.event_id = event_o.id;
                // load the necesary data on the new register control
                event_control.new_register_control.loadData();
                // load new register control
                ControlHelper.LoadControlOnControl(event_control, event_control.new_register_control);
            }// End of validation

        }// End of bRegister_Click function

        /// <summary>
        /// Get competition id
        /// </summary>
        /// <returns></returns>
        public int getCompetitionID()
        {
            // Validate if there is a selected row
            if (dataCompetitions.SelectedRows != null)
            {
                // Use temp the row from the first selected row
                using (DataGridViewRow row = dataCompetitions.SelectedRows[0])
                {
                    // return the first cell of the row, the ID
                    return int.Parse(row.Cells[0].Value.ToString());
                }// End of using
            }// End of validation 
            else // Else show a warning
            {
                // Control helper warning box
                ControlHelper.WarningBox(String.Format(WarningResource.SelectRow, typeof(Competition).ToString()));
            }// End of else
            return 0;// Return 0 if there is nothing selected
        }// End of getCoimpetitionID function

    }// End of Detail Event control class
}
