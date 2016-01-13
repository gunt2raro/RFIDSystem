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

namespace RFIDSystemTest.Views.Competitors
{
    public partial class NewCompetitor : UserControl
    {
        public CompetitorControl competitor_control;
        public ICompetitorService competitor_service;

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
            competitor_control.Controls.Clear();
            competitor_control.Controls.Add( competitor_control.menu_competitors_panel );
        }// End of bCancel_Click function

        /// <summary>
        /// Create Object
        /// </summary>
        /// <returns></returns>
        public Competitor createObject()
        {

            Competitor c = new Competitor();

            c.name = this.txtName.Text;
            c.second_name = this.txtSecondName.Text;
            c.city = this.txtCity.Text;
            c.state = this.txtState.Text;
            c.country = this.txtCountry.Text;
            c.birth_date = this.dtBirthDate.Value.Date;
            c.email = this.txtEmail.Text;
            
            return c;

        }// End of createObject function

        /// <summary>
        /// Button add click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bAdd_Click(object sender, EventArgs e)
        {

            this.competitor_service.addCompetitor( createObject(), null );

        }// End of bAdd_Click function

        /// <summary>
        /// New Competitor Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewCompetitor_Load(object sender, EventArgs e)
        {
            IKernel _Kernal = new StandardKernel();
            _Kernal.Load(Assembly.GetExecutingAssembly());

            IHttpService http_s = _Kernal.Get<HttpService>();

            this.competitor_service = new CompetitorService(http_s);

        }// End of NewCompetitor_Load function
    }
}
