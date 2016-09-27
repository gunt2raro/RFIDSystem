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
        public Image image;
        public IList<EventType> event_types;
        public IList<string> event_types_strings;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="event_control"></param>
        public NewEvent( EventControl event_control )
        {
            InitializeComponent();

            this.event_control = event_control;
            openFileDialog1.Title = "Open Image";
            openFileDialog1.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
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
            // Save the event to the service
            Event eve = event_control.event_service.addEvent( createObject(), null );
            // If the image is not null and the saved event was successfuly saved
            // Then send the image
            if ( eve != null )
            {
                // Validate if the image is null
                if (image != null)
                {
                    // Send the image to the service
                    eve = event_control.event_service.ImageToEvent(eve, image, null);
                    // Validte if the event has been sended
                    if (eve!=null)
                    {
                        // Send the successfuly added box
                        ControlHelper.SuccessBox(SuccessResource.AddSuccessful);
                    }// End of event validation
                    else // If there was an error with the image adding
                    {
                        // Send an adding error box
                        ControlHelper.ErrorBox("There was an error sending the image", 500);
                    }// End of error
                }// End of image validation
                else
                {
                    // Send a successfuly added box
                    ControlHelper.SuccessBox( SuccessResource.AddSuccessful );
                }// End of success box
            }// End of the validations
            else// Return a dialog box with the error
            {
                // Send an adding error box
                ControlHelper.ErrorBox( ErrorResource.AddingError, 404 );
            }// End of all the validations
        }// End of bAdd_Click function

        /// <summary>
        /// Create object
        /// </summary>
        /// <returns></returns>
        public Event createObject()
        {
            // Initialize the event
            Event eve = new Event();
            // Set all the event attributes
            eve.name = txtName.Text;
            eve.description = txtName.Text;
            eve.date_start = dtDateStart.Value;
            eve.date_finish = dtDateFinish.Value;
            eve.date_limit = dtDateLimit.Value;
            eve.competitors_limit = (int)nudCompetitorsLimit.Value;
            eve.image_url = "";
            eve.user = 1;
            eve.event_type = getEventTypeId();
            eve.orginizer = txtOrginizer.Text;
            eve.ubication = txtUbication.Text;
            eve.address = txtAddress.Text;
            // Return the event
            return eve;
        }// End of createObject function

        /// <summary>
        /// Get event id from the selected combo box
        /// </summary>
        /// <returns></returns>
        private int getEventTypeId()
        {
            return event_types.Where(
                event_type =>
                    event_type.name == cbEventType.SelectedItem.ToString()).First().id;
        }// End of getEventTypeId function

        /// <summary>
        /// New Event load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewEvent_Load(object sender, EventArgs e)
        {
            ThemeShit();
            fillcbEventType();
            lName.Text = EventResource.name;
            lDescription.Text = EventResource.description;
            lDateStart.Text = EventResource.date_start;
            lDateFinish.Text = EventResource.date_finish;
            lDateLimit.Text = EventResource.date_limit;
            lCompetitorsLimit.Text = EventResource.competitors_limit;
            bCancel.Text = EventResource.bCancel;
            lUbication.Text = EventResource.lUbication;
            lAddress.Text = EventResource.lAddress;
            lOrginizer.Text = EventResource.lOrginizer;
            lEventType.Text = EventResource.lEventType;
            
        }// End of NewEvent_Load function

        /// <summary>
        /// Theme shit
        /// </summary>
        public void ThemeShit() {
            ThemeDark.ResponsiveDesign( this, Parent.Parent, 1, 1 );
            ThemeDark.SetButtonsTheme(this);
            ThemeDark.SetLabelsTheme(this);
        }// End of ThemeShit function

        /// <summary>
        /// Button image click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bImage_Click(object sender, EventArgs e)
        {
            // Show the dialog and get result.
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                image = new Bitmap( openFileDialog1.FileName );
                pictureBox1.Image = image;
            }
            Console.WriteLine(result); // <-- For debugging use.
        }// End of bImage_Click function

        /// <summary>
        /// Fill combo box of competition types
        /// </summary>
        public void fillcbEventType()
        {
            event_types = event_control.event_service.getAllEventTypes(null, null);
            event_types_strings = new List<string>();
            foreach (EventType et in event_types)
            {
                event_types_strings.Add(et.name);
            }
            cbEventType.DataSource = event_types_strings.ToList();
        }// End of fillcbCompetitionType function

    }// End of New Event control class
} 
