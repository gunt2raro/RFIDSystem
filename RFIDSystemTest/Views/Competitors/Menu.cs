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

namespace RFIDSystemTest.Views.Competitors
{
    /// <summary>
    /// Menu control class
    /// </summary>
    public partial class Menu : UserControl
    {
        public CompetitorControl main_control;
    
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="main_control"></param>
        public Menu( CompetitorControl main_control )
        {
            InitializeComponent();
            this.main_control = main_control;
        }// End of Constructor function

        /// <summary>
        /// Button list click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bList_Click(object sender, EventArgs e)
        {
            ControlHelper.LoadControlOnControl(main_control, main_control.list_competitors_panel);
            main_control.list_competitors_panel.loadData();
        }// End of bList_Click function

        /// <summary>
        /// Button new click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bNew_Click(object sender, EventArgs e)
        {
            ControlHelper.LoadControlOnControl( main_control, main_control.add_competitors_panel );
            main_control.add_competitors_panel.cleanFields();
        }// End of bNew_Click function

        /// <summary>
        /// Button search click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bSearch_Click(object sender, EventArgs e)
        {
            ControlHelper.LoadControlOnControl( main_control, main_control.list_competitors_panel );
        }// End of bSearch_Click function

        /// <summary>
        /// Button register click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bRegister_Click(object sender, EventArgs e)
        {
            ControlHelper.LoadControlOnControl(main_control, main_control.add_competitors_panel);
        }// End of bRegister_Click function

        /// <summary>
        /// Menu load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Menu_Load(object sender, EventArgs e)
        {

        }// End of Menu_load function

    }// End of Menu control class
}
