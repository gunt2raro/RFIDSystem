using Ninject;
using RFIDSystemTest.Business.Implementations.Competitors;
using RFIDSystemTest.Business.Implementations.Events;
using RFIDSystemTest.Business.Implementations.States;
using RFIDSystemTest.Business.Interfaces.Competitors;
using RFIDSystemTest.Business.Interfaces.Events;
using RFIDSystemTest.Business.Interfaces.States;
using RFIDSystemTest.Data.States;
using RFIDSystemTest.Resources.Menu;
using RFIDSystemTest.Views;
using RFIDSystemTest.Views.Events;
using RFIDSystemTest.Warriror;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RFIDSystemTest
{
    public partial class Dashboard : Form
    {

        public IKitStateService kit_state_service;
        public ICompetitorService competitor_service;
        public IEventService event_service;

        /// <summary>
        /// Constructor
        /// </summary>
        public Dashboard( )
        {
            InitializeComponent( );// Init components
            setLabels_Buttons( );// Set the label
            WindowState = FormWindowState.Maximized;
        }//End of dashboard constructor

        /// <summary>
        /// lTitle Click action 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lTitle_Click(object sender, EventArgs e)
        {

        }//End of lTitle_click functon
        
        /// <summary>
        /// setLabels_Buttons 
        /// </summary>
        private void setLabels_Buttons()
        {
            this.bProfile.Text = MenuResource_en.bProfile;
            this.bCategories.Text = MenuResource_en.bCategories;
            this.bEvents.Text = MenuResource_en.bEvents;
            this.bCompetitors.Text = MenuResource_en.bCompetitors;
            this.bSettings.Text = MenuResource_en.bSettings;
            this.bKits.Text = MenuResource_en.bKits;
        }//End of setLabels_Buttons

        /// <summary>
        /// Dashboard load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Dashboard_Load(object sender, EventArgs e)
        {
            // Apparience stuff
            WindowState = FormWindowState.Maximized;
            // Injection stuff
            IKernel _Kernal = new StandardKernel();
            _Kernal.Load(Assembly.GetExecutingAssembly());

            IHttpService http_s = _Kernal.Get<HttpService>();

            this.kit_state_service = new KitStateService(http_s);
            this.competitor_service = new CompetitorService(http_s);
            this.event_service = new EventService(http_s);

        }// End of dashboard_load function

        /// <summary>
        /// Button competitors click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bCompetitors_Click(object sender, EventArgs e)
        {

            CompetitorControl competitor_control = new CompetitorControl( competitor_service );
            pContent.Controls.Clear();
            pContent.Controls.Add( competitor_control );

        }// End of bCompetitors_Click function

        /// <summary>
        /// Button profile click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bProfile_Click(object sender, EventArgs e)
        {
            pContent.Controls.Clear();
        }//End of bProfile_click button action

        /// <summary>
        /// Button events click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bEvents_Click(object sender, EventArgs e)
        {
            EventControl event_control = new EventControl( event_service );

            pContent.Controls.Clear();
            pContent.Controls.Add( event_control );

        }// End of bEvents_Click function

        /// <summary>
        /// Button settings click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bSettings_Click(object sender, EventArgs e)
        {

        }// End of bSettings_Click function

    }//End of Dashboard class

}//End of the name space
