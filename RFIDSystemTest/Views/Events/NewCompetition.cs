using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RFIDSystemTest.Data.Events;
using RFIDSystemTest.Warriror;
using RFIDSystemTest.Helpers;
using RFIDSystemTest.Resources;

namespace RFIDSystemTest.Views.Events
{
    /// <summary>
    /// New competition control
    /// </summary>
    public partial class NewCompetition : UserControl
    {
        private EventControl event_control;
        public Image image;
        public int event_id { get; set; }
        // Categories shit
        private IList<Category> cats;
        private IList<Category> sel_cats;
        private IList<string> cats_strings;
        private IList<string> sel_cats_strings;
        // Competition type shit
        private IList<CompetitionType> competition_types;
        private IList<string> competition_types_strings;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="competition_control"></param>
        public NewCompetition( EventControl event_control )
        {
            InitializeComponent();

            this.event_control = event_control;
            openFileDialog1.Title = "Open Image";
            openFileDialog1.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";

        }// End of Constructor function

        /// <summary>
        /// Clean fields
        /// </summary>
        public void cleanFields() {

        }// End of clean Fields function

        /// <summary>
        /// Theme shit
        /// </summary>
        public void ThemeShit()
        {
            ThemeDark.ResponsiveDesign( this, Parent.Parent, 1, 1 );
            ThemeDark.SetButtonsTheme(this);
            ThemeDark.SetLabelsTheme(this);
        }// End of ThemeShit function

        /// <summary>
        /// New competition load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewCompetition_Load(object sender, EventArgs e)
        {
            //Theme shit
            ThemeShit();
            //load data stuff
            loadData();
        }// End of NewCompetition_Load function

        /// <summary>
        /// Load data
        /// </summary>
        private void loadData()
        {

            cats = event_control.category_service.getAll(null).ToList();
            sel_cats = new List<Category>();
            cats_strings = new List<string>();
            sel_cats_strings = new List<string>();

            foreach ( Category c in cats ) {
                cats_strings.Add( c.name );
            }
            lbCategories.DataSource = cats_strings.ToList();
            fillcbCompetitionType();
        }// End of load Data function

        /// <summary>
        /// Button cancel click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bCancel_Click(object sender, EventArgs e)
        {

        }// End of bCancel_Click function

        /// <summary>
        /// Button add click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bAdd_Click(object sender, EventArgs e)
        {
            Competition comp = event_control.competition_service.addCompetition( createObject(), null );

            if (event_control != null)
            {
                if (image != null)
                {
                    comp = event_control.competition_service.ImageToCompetition(comp, image, null);

                    if (comp != null)
                    {
                        ControlHelper.SuccessBox(SuccessResource.AddSuccessful);
                    }
                    else
                    {
                        ControlHelper.ErrorBox("There was an error sending the image", 500);
                    }
                }
                else
                {
                    ControlHelper.SuccessBox( SuccessResource.AddSuccessful );
                }
            }
            else
            {
                ControlHelper.ErrorBox( ErrorResource.AddingError, 404 );
            }
        }// End of bAdd_Click function

        /// <summary>
        /// 
        /// </summary>
        /// <returns> competition object </returns>
        public Competition createObject() {

            Competition c = new Competition();

            c.name = txtName.Text;
            c.description = txtDescription.Text;
            c.date_finish = dtDateFinish.Value;
            c.date_start = dtDateStart.Value;
            c.competitors_limit = (int)(nudCompetitorsLimit.Value);
            c.categories = getChoosedCategories();
            c.competition_type = getChoosedCompetitionType();
            c.competition_event = event_id;
            c.user = 1;
            c.image_url = "";
            c.cost = (int)nudCompetitorsLimit.Value;
            return c;

        }// End of createObject function

        /// <summary>
        /// Get choosed categories
        /// </summary>
        /// <returns></returns>
        private int[] getChoosedCategories()
        {
            IList<int> cats_id = new List<int>();

            foreach ( string s in sel_cats_strings ) {
                foreach (Category c in cats) {
                    if ( c.name.Equals( s ) ) {
                        cats_id.Add(c.id);
                    }
                }
            }

            return cats_id.ToArray();
        }// End of getchoosedCategories function

        /// <summary>
        /// Get choosed competition type
        /// </summary>
        /// <returns></returns>
        public int getChoosedCompetitionType()
        {
            return competition_types.Where( 
                competition_type => 
                    competition_type.name == cbCompetitiontype.SelectedItem.ToString() ).First().id;
        }// End of getChoosedCompetitiontype function

        /// <summary>
        /// Button add category to selected cats click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bAC_Click(object sender, EventArgs e)
        {

            cats_strings.Remove(lbCategories.SelectedItem.ToString());
            sel_cats_strings.Add( lbCategories.SelectedItem.ToString() );

            lbCategories.DataSource = cats_strings.ToList();
            lbCategories2.DataSource = sel_cats_strings.ToList();

        }// End of bAC_Click function

        /// <summary>
        /// Button return category to original cats click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bRC_Click(object sender, EventArgs e)
        {
            sel_cats_strings.Remove(lbCategories2.SelectedItem.ToString());
            cats_strings.Add(lbCategories2.SelectedItem.ToString());

            lbCategories2.DataSource = sel_cats_strings.ToList();
            lbCategories.DataSource = cats_strings.ToList();
        }// End of bRC_Click function

        /// <summary>
        /// Button all click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bAll_Click(object sender, EventArgs e)
        {
            
        }// End of bAll_Click function

        /// <summary>
        /// Button clear click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bClear_Click(object sender, EventArgs e)
        {

        }// End of bClear_Click function
        
        /// <summary>
        /// Fill combo box of competition types
        /// </summary>
        public void fillcbCompetitionType()
        {
            competition_types = event_control.competition_type_service.getAll(null);
            competition_types_strings = new List<string>();
            foreach (CompetitionType ct in competition_types)
            {
                competition_types_strings.Add(ct.name);
            }
            cbCompetitiontype.DataSource = competition_types_strings.ToList();
        }// End of fillcbCompetitionType function

        private void bImage_Click(object sender, EventArgs e)
        {
            // Show the dialog and get result.
            DialogResult result = openFileDialog1.ShowDialog();
            if (result == DialogResult.OK) // Test result.
            {
                image = new Bitmap(openFileDialog1.FileName);
                pictureBox1.Image = image;
            }
            Console.WriteLine(result); // <-- For debugging use.
        }
    }// End of NewCompetitionControl class
}
