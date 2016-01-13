using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RFIDSystemTest.Views.Competitors
{
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

        private void bList_Click(object sender, EventArgs e)
        {
            main_control.Controls.Clear();
            main_control.Controls.Add( main_control.list_competitors_panel );
        }// End of bList_Click function

        private void bNew_Click(object sender, EventArgs e)
        {
            main_control.Controls.Clear();
            main_control.Controls.Add(main_control.add_competitors_panel);
        }// End of bNew_Click function

        private void bSearch_Click(object sender, EventArgs e)
        {
            main_control.Controls.Clear();
            main_control.Controls.Add(main_control.list_competitors_panel);
        }// End of bSearch_Click function

        private void bRegister_Click(object sender, EventArgs e)
        {
            main_control.Controls.Clear();
            main_control.Controls.Add( main_control.add_competitors_panel );
        }// End of bRegister_Click function

        private void Menu_Load(object sender, EventArgs e)
        {

        }
    }
}
