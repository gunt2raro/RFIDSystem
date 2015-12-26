using RFIDSystemTest.Resources.Menu;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RFIDSystemTest
{
    public partial class Dashboard : Form
    {

        /// <summary>
        /// Constructor
        /// </summary>
        public Dashboard()
        {
            InitializeComponent( );// Init components
            setLabels_Buttons( );// Set the label
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
        /// bProfile Click button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bProfile_Click(object sender, EventArgs e)
        {

        }//End of bProfile_click button action

        /// <summary>
        /// setLabels_Buttons 
        /// </summary>
        private void setLabels_Buttons()
        {
            this.bProfile.Text = MenuResource_en.bProfile;
            this.bCategories.Text = MenuResource_en.bCategories;
            this.bCompetitions.Text = MenuResource_en.bCompetitions;
            this.bCompetitors.Text = MenuResource_en.bCompetitors;
            this.bSettings.Text = MenuResource_en.bSettings;
            this.bKits.Text = MenuResource_en.bKits;
        }//End of setLabels_Buttons

    }//End of Dashboard class

}//End of the name space
