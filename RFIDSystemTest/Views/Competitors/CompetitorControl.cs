using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RFIDSystemTest.Business.Interfaces.Competitors;
using RFIDSystemTest.Data.Competitors;
using RFIDSystemTest.Views.Competitors;
using RFIDSystemTest.Warriror;

namespace RFIDSystemTest.Views
{
    public partial class CompetitorControl : UserControl
    {
        public ICompetitorService competitor_service;
        public Competitors.Menu menu_competitors_panel;
        public List list_competitors_panel;
        public NewCompetitor add_competitors_panel;
        public SearchCompetitor search_competitor_panel;
        public DetailCompetitor detail_competitor_panel;

        /// <summary>
        /// Competitor Control constructor
        /// </summary>
        /// <param name="competitor_service"></param>
        public CompetitorControl( ICompetitorService competitor_service )
        {

            InitializeComponent();

            this.competitor_service = competitor_service;

            list_competitors_panel = new List(this);
            menu_competitors_panel = new Competitors.Menu( this );
            add_competitors_panel = new NewCompetitor( this );
            search_competitor_panel = new SearchCompetitor( this );
            detail_competitor_panel = new DetailCompetitor( this );

        }// End of CompetitorControl constructor

        /// <summary>
        /// CompetitorControl Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CompetitorControl_Load(object sender, EventArgs e)
        {

            Controls.Clear();
            Controls.Add(menu_competitors_panel);
            ThemeShit();
        }// End of CompetitorControl_Load function

        /// <summary>
        /// Theme shit init def and shit
        /// </summary>
        public void ThemeShit() {
            ThemeDark.ResponsiveDesign(this, Parent, 1, 1);
        }// Ene of ThemeShit function

    }// End of Competitor Control class

}
