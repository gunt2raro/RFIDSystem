using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RFIDSystemTest.Business.Interfaces.Events;
using RFIDSystemTest.Views.Categories;
using RFIDSystemTest.Helpers;

namespace RFIDSystemTest.Views
{
    /// <summary>
    /// Cateogory service 
    /// </summary>
    public partial class CategoryControl : UserControl
    {
        public MenuCategory menu_category_control;
        public ListCategory list_category_control;
        public NewCategory new_category_control;

        public ICategoryService category_service;
         
        /// <summary>
        /// Category control
        /// </summary>
        public CategoryControl( ICategoryService category_service )
        {

            InitializeComponent();

            menu_category_control = new MenuCategory( this );
            list_category_control = new ListCategory( this );
            new_category_control = new NewCategory( this );

            this.category_service = category_service;

        }// End of Constructor function

        /// <summary>
        /// Category control load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CategoryControl_Load(object sender, EventArgs e)
        {
            ControlHelper.LoadControlOnControl( this, menu_category_control );

            Width = Parent.Width;
            Height = Parent.Height;

        }// End of CategoryControl_Load function

    }// End of Category control class
}
