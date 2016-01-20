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
using RFIDSystemTest.Business.Interfaces.Competitors;
using Ninject;
using RFIDSystemTest.Warriror;
using RFIDSystemTest.Business.Implementations.Competitors;
using System.Reflection;
using RFIDSystemTest.Helpers;
using RFIDSystemTest.Resources;

namespace RFIDSystemTest.Views.Competitors
{
    /// <summary>
    /// New competitor control
    /// </summary>
    public partial class NewCompetitor : UserControl
    {

        public CompetitorControl competitor_control;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="competitor_control"></param>
        public NewCompetitor( CompetitorControl competitor_control )
        {
            InitializeComponent();

            this.competitor_control = competitor_control;
            
        }// End of Constructor function

        /// <summary>
        /// Button cancel click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bCancel_Click(object sender, EventArgs e)
        {
            ControlHelper.LoadControlOnControl( competitor_control, competitor_control.menu_competitors_panel );
        }// End of bCancel_Click function

        /// <summary>
        /// Create Object
        /// </summary>
        /// <returns></returns>
        public Competitor createObject()
        {

            Competitor c = new Competitor();

            c.name = txtName.Text;
            c.second_name = txtSecondName.Text;
            c.city = txtCity.Text;
            c.state = txtState.Text;
            c.country = txtCountry.Text;
            c.birth_date = dtBirthDate.Value.Date;
            c.email = txtEmail.Text;
            c.zip_code = int.Parse( txtZipCode.Text );
            c.address = txtAddress.Text;

            return c;

        }// End of createObject function

        /// <summary>
        /// Button add click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bAdd_Click(object sender, EventArgs e)
        {

            competitor_control.competitor_service.addCompetitor( createObject(), null );

        }// End of bAdd_Click function

        /// <summary>
        /// New Competitor Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewCompetitor_Load(object sender, EventArgs e)
        {

            lName.Text = CompetitorResource.name;
            lSecondName.Text = CompetitorResource.second_name;
            lEmail.Text = CompetitorResource.email;
            lAddress.Text = CompetitorResource.address;
            lCity.Text = CompetitorResource.city;
            lCountry.Text = CompetitorResource.country;
            lState.Text = CompetitorResource.state;
            lBirthDate.Text = CompetitorResource.birth_date;
            lZipCode.Text = CompetitorResource.zip_code;

            bAdd.Text = CompetitorResource.bAdd;
            bCancel.Text = CompetitorResource.bCancel;

        }// End of NewCompetitor_Load function

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
    }
}
