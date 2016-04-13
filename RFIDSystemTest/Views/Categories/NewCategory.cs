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
using RFIDSystemTest.Warriror;

namespace RFIDSystemTest.Views.Categories
{
    /// <summary>
    /// New Category control class
    /// </summary>
    public partial class NewCategory : UserControl
    {
        public CategoryControl category_control;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="category_control"> main category control </param>
        public NewCategory( CategoryControl category_control )
        {
            // Default stuff
            InitializeComponent(); 
            // Category control load by injection by const
            this.category_control = category_control;
        }// End of Constructor
        
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

        /// <summary>
        /// Button color click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bColor_Click(object sender, EventArgs e)
        {
            cdColorChooser.ShowDialog();
        }// End of bColor_click function

        /// <summary>
        /// Button add click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bAdd_Click(object sender, EventArgs e)
        {
            category_control.category_service.addCategory( createObject(), null );
        }// End of bAdd_Click function

        /// <summary>
        /// Button cancel click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bCancel_Click(object sender, EventArgs e)
        {
            ControlHelper.LoadControlOnControl( category_control, category_control.menu_category_control );
        }// End of bCancel_Click function 

        /// <summary>
        /// New category load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewCategory_Load(object sender, EventArgs e)
        {
            // Theme shit
            ThemeShit();
            // Resources stuff
            bAdd.Text = CategoryResource.bAdd;
            bCancel.Text = CategoryResource.bCancel;
            lName.Text = CategoryResource.id;
            lDescription.Text = CategoryResource.description;
            lTo.Text = CategoryResource.lTo;
            lAges.Text = CategoryResource.lAges;

        }// End of newcategory_load function

        /// <summary>
        /// Create object 
        /// </summary>
        public Category createObject()
        {
             Category cat = new Category();

            cat.name = txtName.Text;
            cat.description = txtDescription.Text;
            cat.age_1 = (int)nudAge1.Value;
            cat.age_2 = (int)nudAge2.Value;
            cat.color = cdColorChooser.Color.ToString();

            return cat;
        }// End of createObject function

        /// <summary>
        /// Theme shit
        /// </summary>
        public void ThemeShit()
        {
            ThemeDark.ResponsiveDesign(this, Parent.Parent, 1, 1);
            ThemeDark.SetButtonsTheme(this);
            ThemeDark.SetLabelsTheme( this );
        }// End of ThemeShit function

    }// End of New Category control class
}
