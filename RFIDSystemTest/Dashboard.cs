using Ninject;
using RFIDSystemTest.Resources.Menu;
using RFIDSystemTest.Views;
using RFIDSystemTest.Views.Events;
using RFIDSystemTest.Warriror;
using System;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace RFIDSystemTest
{
    public partial class Dashboard : Form
    {
        ///public ICompe
        /// <summary>
        /// Constructor
        /// </summary>
        public Dashboard( )
        {
            InitializeComponent( );// Init components
            setLabels_Buttons( );// Set the label
            WindowState = FormWindowState.Maximized;
            Cursor.Current = Cursors.WaitCursor;
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
            ThemeShit();
        }// End of dashboard_load function

        /// <summary>
        /// Button competitors click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bCompetitors_Click(object sender, EventArgs e)
        {

            CompetitorControl competitor_control = Injection.kernel.Get<CompetitorControl>();
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
            EventControl event_control = Injection.kernel.Get<EventControl>( );
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

        /// <summary>
        /// Button categories click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bCategories_Click(object sender, EventArgs e)
        {
            CategoryControl category_control = Injection.kernel.Get<CategoryControl>();

            pContent.Controls.Clear();
            pContent.Controls.Add( category_control );

        }// End of bCategories_Click function

        /// <summary>
        /// Button kits click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bKits_Click(object sender, EventArgs e)
        {

        }// End of bKits_Click function

        /// <summary>
        /// Theme shit
        /// </summary>
        public void ThemeShit() {
            WindowState = FormWindowState.Maximized;
            this.BackColor = Color.FromArgb(255, 255, 255);
            pContent.BackColor = Color.FromArgb(255, 255, 255);
            pMenu.BackColor = Color.FromArgb( 34, 34, 34 );
            ThemeDark.SetButtonsThemeDark( this );
            ThemeDark.ResponsiveDesign( pContent, this, .75, 1 );
            ThemeDark.SetLabelsTheme(this);
            ThemeDark.ResponsiveDesign( pMenu, this, .15, 1 );
            pInfo.BackColor = Color.FromArgb( 248, 248, 248 );
            pTitle.BackColor = Color.FromArgb( 80, 102, 127 );
            lTitle.ForeColor = Color.FromArgb(255, 255, 255);
            lSubtitle.ForeColor = Color.FromArgb( 162, 173, 186 );
            pTitle.Width = (int)(this.Width * .75);
            lTitle.Font = new Font("Segoe UI", 20, FontStyle.Bold, GraphicsUnit.World);
            lSubtitle.Font = new Font("Segoe UI", 12, FontStyle.Bold, GraphicsUnit.World);
        }// End of ThemeShit function

        /// <summary>
        /// Dashboard Resize End
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Dashboard_Resize_End(object sender, System.EventArgs e)
        {
            ThemeShit();
        }// End of Dashboard_Resize_End function

        private void pInfo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pTitle_Paint(object sender, PaintEventArgs e)
        {

        }
    }//End of Dashboard class

}//End of the name space
