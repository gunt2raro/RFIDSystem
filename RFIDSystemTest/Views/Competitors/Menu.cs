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
using RFIDSystemTest.Warriror;

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
            ThemeShit();
        }// End of Menu_load function

        /// <summary>
        /// Theme shit
        /// </summary>
        public void ThemeShit() {
            ThemeDark.ResponsiveDesign( this, Parent.Parent, 1, 1 );
            ThemeDark.SetButtonsTheme( this );
            ThemeDark.ButtonsResponsiveWidth(bList, this, .8);
            ThemeDark.ButtonsResponsiveWidth(bNew, this, .8);
            ThemeDark.ButtonsResponsiveWidth(bRegister, this, .8);
            ThemeDark.ButtonsResponsiveWidth(bSearch, this, .8);
        }// End of themeShit function

    }// End of Menu control class
}
