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

namespace RFIDSystemTest.Views
{
    public partial class CompetitorControl : UserControl
    {
        private ICompetitorService competitor_service;
        public List list_competitors_panel;
        public Competitors.Menu menu_competitors_panel;
        public NewCompetitor add_competitors_panel;
        public SearchCompetitor search_competitor_panel;

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

        }// End of CompetitorControl constructor

        /// <summary>
        /// CompetitorControl Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CompetitorControl_Load(object sender, EventArgs e)
        {
            this.Controls.Clear();
            Controls.Add(menu_competitors_panel);
        }// End of CompetitorControl_Load function

    }
}
