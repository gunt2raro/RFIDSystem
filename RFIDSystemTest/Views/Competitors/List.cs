using System;
using System.Collections.Generic;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using RFIDSystemTest.Warriror;
using RFIDSystemTest.Data.Competitors;
using RFIDSystemTest.Helpers;
using RFIDSystemTest.Resources;

namespace RFIDSystemTest.Views.Competitors
{
    /// <summary>
    /// List competitor control
    /// </summary>
    public partial class List : UserControl
    {
        public CompetitorControl competitor_control;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="competitor_control"></param>
        public List(CompetitorControl competitor_control)
        {

            InitializeComponent();

            this.competitor_control = competitor_control;
        }// End of Constructor function

        /// <summary>
        /// Button Return Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bReturn_Click(object sender, EventArgs e)
        {
            ControlHelper.LoadControlOnControl( competitor_control, competitor_control.menu_competitors_panel );
        }// End of bReturn_Click function

        /// <summary>
        /// List Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void List_Load(object sender, EventArgs e)
        {
            ThemeShit();
            loadData();
        }// End of List_Load function

        public void loadData() {
            dataCompetitors.DataSource = competitor_control.competitor_service.getAll(null);
        }// End of load Data function

        /// <summary>
        /// Data competitors cell content click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataCompetitors_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }// End of dataCompetitors_CellContentClick function

        /// <summary>
        /// Button new click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bNew_Click(object sender, EventArgs e)
        {
            ControlHelper.LoadControlOnControl( competitor_control, competitor_control.add_competitors_panel );
            competitor_control.add_competitors_panel.cleanFields();
        }// End of bNew_Click function

        /// <summary>
        /// Button edit click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bEdit_Click(object sender, EventArgs e)
        {

            if (dataCompetitors.SelectedRows != null)
            {

                using (DataGridViewRow row = dataCompetitors.SelectedRows[0])
                {
                    competitor_control.detail_competitor_panel.competitor = competitor_control.competitor_service.getById(int.Parse(row.Cells[0].Value.ToString()), null);
                    competitor_control.detail_competitor_panel.loadData();
                    ControlHelper.LoadControlOnControl( competitor_control, competitor_control.detail_competitor_panel );
                }

            }
            else
            {
                ControlHelper.WarningBox( String.Format( WarningResource.SelectRow, typeof(Competitor).ToString() ) );
            }
            
        }// End of bEdit_Click function

        /// <summary>
        /// Button search click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bSearch_Click(object sender, EventArgs e)
        {
            string query = txtSearch.Text;

            if (query != TWords.EMPTY && query != " ")
            {
                IEnumerable<Competitor> competitors = from competitor in competitor_control.competitor_service.getAll(null).ToList() where string.Format("{0} {1}", competitor.name, competitor.second_name).Contains(query) select competitor;
                dataCompetitors.DataSource = competitors.ToList();
            }
            else if (query == "")
            {
                loadData();
            }
            else
            {
                ControlHelper.WarningBox("Need to put something on the search box first!!");
            }
        }// End of bSearch_Click function

        /// <summary>
        /// theme shit
        /// </summary>
        public void ThemeShit()
        {
            ThemeDark.ResponsiveDesign(this, Parent.Parent, 1, 1);
            ThemeDark.SetButtonsTheme(this);
            ThemeDark.SetDataGridViewResponsiveWidth(dataCompetitors, this, .8);
            ThemeDark.SetDataGridViewResponsiveHeight(dataCompetitors, this, .5);
            this.BackColor = Color.FromArgb(248, 248, 248);
            ThemeDark.SetDataGridViewResponsiveWidth(dataCompetitors, this, 1);
            ThemeDark.SetDataGridViewResponsiveHeight(dataCompetitors, this, .50);
            /***
            ThemeDark.ResponsiveDesign( this, Parent.Parent, 1, 1 );
            ThemeDark.SetButtonsTheme(this);
            this.BackColor = Color.FromArgb( 248, 248, 248 );
            ThemeDark.SetDataGridViewResponsiveWidth(dataEvents, this, 1);
            ThemeDark.SetDataGridViewResponsiveHeight(dataEvents, this, .50);
            pButtons.Width = Parent.Parent.Width;
            pButtons.BackColor = Color.FromArgb(80, 102, 127);
            pButtons.BorderStyle = BorderStyle.None;
            ***/
        }// end of ThemeShit function

    }// End of List control class
}
