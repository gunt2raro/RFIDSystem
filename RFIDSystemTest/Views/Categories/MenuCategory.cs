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

namespace RFIDSystemTest.Views.Categories
{
    public partial class MenuCategory : UserControl
    {
        public CategoryControl category_control;

        /// <summary>
        /// constructor
        /// </summary>
        public MenuCategory( CategoryControl category_control )
        {
            InitializeComponent();
            this.category_control = category_control;
        }// End of Constructor function

        /// <summary>
        /// Button list click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bList_Click(object sender, EventArgs e)
        {
            ControlHelper.LoadControlOnControl( category_control, category_control.list_category_control );
            category_control.list_category_control.loadData();
        }// End of bList_Click function

        /// <summary>
        /// Button new click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bNew_Click(object sender, EventArgs e)
        {
            ControlHelper.LoadControlOnControl( category_control, category_control.new_category_control );
            category_control.new_category_control.cleanFields();
        }// End of bNew_Click function

        /// <summary>
        /// Menu category load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuCategory_Load(object sender, EventArgs e)
        {
            ThemeShit();
        }// End of MenuCategory_Load function

        /// <summary>
        /// Theme shit
        /// </summary>
        public void ThemeShit() {

            ThemeDark.ResponsiveDesign(this, Parent.Parent, 1, 1);
            ThemeDark.SetBackgroundColor( this );
            ThemeDark.SetButtonsTheme( this );
            ThemeDark.ButtonsResponsiveWidth(bList, this, .8);
            ThemeDark.ButtonsResponsiveWidth(bNew, this, .8);
            ThemeDark.ButtonsResponsiveWidth(bSearch, this, .8);

        }// End of Theme Shit function

    }// End of Menu Category class
}
