using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RFIDSystemTest.Data.Competitors;
using RFIDSystemTest.Helpers;
using RFIDSystemTest.Resources;
using RFIDSystemTest.Warriror;

namespace RFIDSystemTest.Views.Competitors
{
    /// <summary>
    /// Detail competitor control class
    /// </summary>
    public partial class DetailCompetitor : UserControl
    {
        public CompetitorControl competitor_control;
        public Competitor competitor;
        
        /// <summary>
        /// Constructor
        /// </summary>
        public DetailCompetitor( CompetitorControl competitor_control )
        {
            // Default sftuff
            InitializeComponent();
            // Load the competitor control from injection by const
            this.competitor_control = competitor_control;
        }// End of Constructor

        /// <summary>
        /// Detail competitor load 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DetailCompetitor_Load(object sender, EventArgs e)
        {
            // Theme Stuff
            ThemeShit();
            // Load data to fields
            loadData();
            // Resources stuff
            bCancel.Text = CompetitorResource.bCancel;
            bUpdate.Text = CompetitorResource.bUpdate;
            bEnable.Text = CompetitorResource.bEnable;

            lName.Text = CompetitorResource.name;
            lSecondName.Text = CompetitorResource.second_name;
            lEmail.Text = CompetitorResource.email;
            lAddress.Text = CompetitorResource.address;
            lCity.Text = CompetitorResource.city;
            lCountry.Text = CompetitorResource.country;
            lState.Text = CompetitorResource.state;
            lBirthDate.Text = CompetitorResource.birth_date;
            lZipCode.Text = CompetitorResource.zip_code;

        }// End of Detail Competitor Load function

        /// <summary>
        /// Load data
        /// </summary>
        public void loadData() {

            lIdDescription.Text = competitor.id.ToString();
            txtName.Text = competitor.name;
            txtSecondName.Text = competitor.second_name;
            txtEmail.Text = competitor.email;
            txtAddress.Text = competitor.address;
            txtCity.Text = competitor.city;
            txtState.Text = competitor.state;
            txtCountry.Text = competitor.country;
            txtZipCode.Text = competitor.zip_code.ToString();

        }// End of loadData function

        /// <summary>
        /// Button update click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bUpdate_Click(object sender, EventArgs e)
        {
            Competitor comp = competitor_control.competitor_service.updateCompetitor( createObject(), null );
            if (comp != null)
            {
                ControlHelper.SuccessBox( String.Format( SuccessResource.UpdateSuccessful, typeof(Competitor).ToString(), String.Format( "{0} {1}", comp.name, comp.second_name ) ) );
                ControlHelper.LoadControlOnControl(competitor_control, competitor_control.list_competitors_panel);
                competitor_control.list_competitors_panel.loadData();
            }
            else
            {
                ControlHelper.ErrorBox( String.Format( ErrorResource.UpgradingError, typeof(Competitor).ToString() ), 0 );
            }

        }// End of bUpdate_click function

        /// <summary>
        /// Create object
        /// </summary>
        /// <returns></returns>
        private Competitor createObject()
        {
            competitor.id = int.Parse( lIdDescription.Text );
            competitor.name = txtName.Text;
            competitor.second_name = txtSecondName.Text;
            competitor.city = txtCity.Text;
            competitor.state = txtState.Text;
            competitor.country = txtCountry.Text;
            competitor.birth_date = dtBirthDate.Value.Date;
            competitor.email = txtEmail.Text;
            competitor.zip_code = int.Parse(txtZipCode.Text);
            competitor.address = txtAddress.Text;

            return competitor;

        }// End of createObject function

        /// <summary>
        /// Button cancel click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bCancel_Click(object sender, EventArgs e)
        {
            ControlHelper.LoadControlOnControl( competitor_control, competitor_control.list_competitors_panel );
        }// End of bCancel_click function

        /// <summary>
        /// Button enable click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bEnable_Click(object sender, EventArgs e)
        {

            foreach ( Control c in Controls ) {
                if (c.GetType() == typeof(TextBox)) {
                    c.Enabled = true;
                } else if (c.GetType() == typeof(DateTimePicker)) {
                    c.Enabled = true;
                }
            }

        }// End of bEnable_click function

        /// <summary>
        /// Theme shit
        /// </summary>
        public void ThemeShit()
        {
            ThemeDark.ResponsiveDesign(this, Parent.Parent, 1, 1);
            ThemeDark.SetButtonsTheme(this);
            ThemeDark.SetLabelsTheme(this);
        }// End of ThemeShit function

    }// End of Detail Competitor class
}
