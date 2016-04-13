using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RFIDSystemTest.Resources;
using RFIDSystemTest.Helpers;
using RFIDSystemTest.Data.Events;
using RFIDSystemTest.Views.VO;
using RFIDSystemTest.Warriror;

namespace RFIDSystemTest.Views.Categories
{
    /// <summary>
    /// List Category control class
    /// </summary>
    public partial class ListCategory : UserControl
    {
        public CategoryControl category_control;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="category_control"></param>
        public ListCategory( CategoryControl category_control )
        {
            InitializeComponent();

            this.category_control = category_control;

        }// End of constructor function

        /// <summary>
        /// Load data
        /// </summary>
        public void loadData()
        {
            dataCategories.DataSource = category_control.category_service.getAll( null ).Select( 
                c => new CategoryVO() {
                    id = c.id,
                    name = c.name,
                    ages = string.Format(
                        "{0}-{1}", 
                        c.age_1, 
                        c.age_2),
                    color = Color.FromName( 
                        c.color ) } ).ToList();

        }// End of load Data function

        /// <summary>
        /// Button return click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bReturn_Click(object sender, EventArgs e)
        {
            ControlHelper.LoadControlOnControl( category_control, category_control.menu_category_control );
        }// End of bReturn_Click function

        /// <summary>
        /// Button edit click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bEdit_Click(object sender, EventArgs e)
        {

        }// End of bEdit_Click funciton

        /// <summary>
        /// Button new click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bNew_Click(object sender, EventArgs e)
        {
            ControlHelper.LoadControlOnControl( category_control, category_control.new_category_control );
            category_control.new_category_control.cleanFields();
        }// End of bNEw_Click function

        /// <summary>
        /// List Category Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ListCategory_Load(object sender, EventArgs e)
        {
            //Theme stuff
            ThemeShit();
            //Load Data
            loadData();
            //Resources stuff
            bReturn.Text = CategoryResource.bReturn;
            bNew.Text = CategoryResource.bNew;
            bEdit.Text = CategoryResource.bEdit;
            
        }// End of ListCategory_Load function

        /// <summary>
        /// Theme shit
        /// </summary>
        public void ThemeShit() {
            ThemeDark.ResponsiveDesign( this, Parent.Parent, 1, 1 );
            ThemeDark.SetButtonsTheme( this );
            ThemeDark.SetDataGridViewTheme( dataCategories );
        }// End of ThemeShit function

    }// End of ListCategory control class
}