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
using RFIDSystemTest.Data.Competitors;
using RFIDSystemTest.Views.VO;
using Microsoft.Office.Interop.Excel;

namespace RFIDSystemTest.Views.Events
{
    /// <summary>
    /// Report control
    /// </summary>
    public partial class ReportControl : UserControl
    {
        public EventControl event_control;
        public Event eventou;
        public ReportVO [] report_array;
        public IList<Competition> competitions;
        public IList<string> competitions_strings;

        public IList<Category> categories;
        public IList<string> categories_strings;

        /// <summary>
        /// Report control constructor
        /// </summary>
        public ReportControl(EventControl event_control)
        {
            InitializeComponent();
            // Set the event control
            this.event_control = event_control;
            // Init the evetu
            eventou = new Event();
            // Init the competitions list
            competitions = new List<Competition>();
            // Init the competitions list of strings
            competitions_strings = new List<string>();
            // init the categories list
            categories = new List<Category>();
            // init the categories strings list
            categories_strings = new List<string>();
        }// End of Report Control constructor

        public IList<ReportVO> createReportsCategories( Competition competition, Category cat ) {
            // init the reports array
            IList<ReportVO> reports = new List<ReportVO>();
            // 5.- get the time registers for the respective register
            // Get the competitors 
            pbDataProgress.Value = 0;
            IList<Competitor> competitors = event_control.competitor_service.getAll(null);
            pbDataProgress.Value = 33;
            IList<Category> categories = event_control.category_service.getAll(null);
            pbDataProgress.Value = 66;
            // Init temporal shit
            IList<Register> registers = getRegisters(competition);
            pbDataProgress.Value = 100;
            IList<TimeReg> time_regs = new List<TimeReg>();
            // 4.- get the registes for the repective comeptition
            foreach (Register r in registers)
            {
                ReportVO report = new ReportVO();
                // 6.- get the competitor for the respective regiser
                Competitor comp = competitors.Where(competitor => competitor.id == r.competitor).ToList().First();
                // 7.- create the report object with all the data you have-
                // the competition, register, competitor, time registers
                time_regs = event_control.time_reg_service.getByRegister(r, null);

                TimeReg time_reg_temp = new TimeReg();
                time_reg_temp.register = r.id;
                time_reg_temp.time = txtStartTime.Text;
                time_regs.Insert(0, time_reg_temp);

                // 8.- fill the list of times on the report with the time registers
                report.competitors_name = string.Format("{0} {1}", comp.name, comp.second_name);
                report.competitor_num = r.competitor_num;
                report.category = categories.Where(category => category.id == r.category).ToList().First().name;
                // loop time registers
                foreach (TimeReg tr in time_regs)
                {
                    if (tr != time_regs.First())
                    {
                        TimeSpan dif = DateTime.Parse(tr.time).Subtract(DateTime.Parse(time_regs.First().time));
                        report.times.Add(dif.ToString());
                    }
                }
                // Validate it the time_registers has none, it means something went wrong with the competitor
                if (time_regs.Count > 0)
                {
                    report.disqualified = false;
                    report.total_time = DateTime.Parse(time_regs.Last().time).Subtract(DateTime.Parse(time_regs.First().time)).ToString();
                }
                // Else just put a 0; us tin case
                else
                {
                    report.disqualified = true;
                    report.total_time = "00:00:00";
                }
                // Add the report to the reports array
                reports.Add(report);
            }
            // Fill the array that will contain the number
            fill_array(reports);
            // order the reports  globally
            order_global_reports_by_category(reports, categories, cat);
            // Return the reports just in case duh!
            return reports;
        }// End of createReportsCategories function
        
        /// <summary>
        /// Create reports by competition
        /// </summary>
        public IList<ReportVO> createReportsByCompetition( Competition competition ) {
            // init the reports array
            IList<ReportVO> reports = new List<ReportVO>();
            // 5.- get the time registers for the respective register
            // Get the competitors 
            pbDataProgress.Value = 0;
            IList<Competitor> competitors = event_control.competitor_service.getAll(null);
            pbDataProgress.Value = 33;
            IList<Category> categories = event_control.category_service.getAll(null);
            pbDataProgress.Value = 66;
            // Init temporal shit
            IList<Register> registers = getRegisters(competition);
            pbDataProgress.Value = 100;
            IList<TimeReg> time_regs = new List<TimeReg>();
            // 4.- get the registes for the repective comeptition
            foreach (Register r in registers)
            {
                ReportVO report = new ReportVO();
                // 6.- get the competitor for the respective regiser
                Competitor comp = competitors.Where(competitor => competitor.id == r.competitor).ToList().First();
                // 7.- create the report object with all the data you have-
                // the competition, register, competitor, time registers
                time_regs = event_control.time_reg_service.getByRegister(r, null);
                
                TimeReg time_reg_temp = new TimeReg();
                time_reg_temp.register = r.id;
                time_reg_temp.time = txtStartTime.Text;
                time_regs.Insert(0, time_reg_temp);
          
                // 8.- fill the list of times on the report with the time registers
                report.competitors_name = string.Format("{0} {1}", comp.name, comp.second_name);
                report.competitor_num = r.competitor_num;
                report.category = categories.Where(category => category.id == r.category).ToList().First().name;
                // Loop time registers
                foreach (TimeReg tr in time_regs)
                {
                    if (tr != time_regs.First())
                    {
                        TimeSpan dif = DateTime.Parse(tr.time).Subtract(DateTime.Parse(time_regs.First().time));
                        report.times.Add(dif.ToString());
                    }
                }
                // Validate it the time_registers has none, it means something went wrong with the competitor
                if (time_regs.Count > 0)
                {
                    report.total_time = DateTime.Parse(time_regs.Last().time).Subtract(DateTime.Parse(time_regs.First().time)).ToString();
                    report.disqualified = false;
                }
                // Else just put a 0; us tin case
                else 
                {
                    report.disqualified = true;
                    report.total_time = "00:00:00";
                }
                // Add the report to the reports array
                reports.Add(report);
            }
            // Fill the array that will contain the number
            fill_array(reports);
            // order the reports  globally
            order_global_reports( reports, categories );
            // Return the reports just in case duh!
            return reports;
        }// End of createReportsByCompetititon function

        #region getters
        /// <summary>
        /// Get registers
        /// </summary>
        /// <param name="competition"></param>
        /// <returns></returns>
        public IList<Register> getRegisters( Competition competition ) {
            return event_control.register_service.getRegistersByCompetition(competition, null);
        }// End of getRegisters function

        /// <summary>
        ///  Get competitions 
        /// </summary>
        /// <returns></returns>
        public IList<Competition> getCompetitions( ) {
            
            return event_control.competition_service.getCompetitionsByEvent(eventou, null);
        }// End of getCompetititons function 

        /// <summary>
        /// Get time registers
        /// </summary>
        /// <param name="register"></param>
        /// <returns></returns>
        public IList<TimeReg> getTimeRegisters( Register register ) {
            return event_control.time_reg_service.getByRegister(register, null);
        }// End of getTime Registers function
        #endregion getters

        #region selected
        public bool cbGlobalIsSelected()
        {
            return cbGlobal.Checked;
        }// End of dbGlobalIsSelected function

        public bool cbCompetitionsIsSelected()
        {
            return false;// cbCompetitions.Checked;
        }// End of cbCompetitionsIsSelected function

        public bool cbCategoriesIsSelected()
        {
            return false;// cbCategories.Checked;
        }// End of cbCompetitionsIsSelected function
        #endregion selected

        /// <summary>
        /// Fill array 
        /// </summary>
        /// <param name="reports"></param>
        public void fill_array(IList<ReportVO> reports) {
            report_array = new ReportVO[reports.Count];
            for (int i = 0; i < reports.Count; i++) {
                report_array[i] = reports.ElementAt(i);
            }
        }// End of fill_array function

        /// <summary>
        /// Button 1 click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            if (cbGlobalIsSelected())
            {
                createReportsByCompetition( getCompetitionBySelectedList() );
                print_excel_global( getCompetitionBySelectedList() );
            }
            else
            {
                createReportsCategories( getCompetitionBySelectedList(), getCategoryBySelectedList() );
                print_excel_categories( getCategoryBySelectedList() );
            }
        }//  End of button1_Click function

        /// <summary>
        /// Don't know if this is working hehe
        /// </summary>
        /// <param name="report_list"></param>
        public void order_global_reports(IList<ReportVO> report_list, IList<Category> categories) {

            IList<ReportVO> results = new List<ReportVO>();

            for (int i = 0; i < report_array.Length; i++)
            {
                for (int j = i; j < report_array.Length; j++)
                {
                    int date_compare = DateTime.Compare(DateTime.Parse(report_array[i].total_time), DateTime.Parse(report_array[j].total_time));

                    if (report_array[j].total_time != "00:00:00")
                    {
                        if (date_compare > 0 || report_array[i].total_time == "00:00:00")
                        {
                            ReportVO temp = report_array[i];
                            report_array[i] = report_array[j];
                            report_array[j] = temp;
                            report_array[i].global_score = i + 1;
                            report_array[j].global_score = j + 1;
                        }// End of compare validation
                        else
                        {
                            report_array[i].global_score = i + 1;
                            report_array[j].global_score = j + 1;
                        }
                    }
                    else
                    {
                        report_array[i].global_score = i + 1;
                        report_array[j].global_score = j + 1;
                    }

                }// End of second loop
                pbGenerating.Value = (100 *( i+1 )) / report_array.Length;
            }// End of first loop

            foreach (Category cat in categories)
            {
                int h = 1;
                for (int k = 0; k < report_array.Length; k++)
                {
                    if( report_array[k].category == cat.name)
                    {
                        report_array[k].category_score = h;
                        h++;
                    }  
                }// End of reports loop 
            }// End of categories loop
        }// End of order_global_reports function

        /// <summary>
        /// Order global reports by category function
        /// </summary>
        public void order_global_reports_by_category( IList<ReportVO> report_list, IList<Category> categories, Category cat ) {

            order_global_reports( report_list, categories);

            report_array = report_array.Where(category => category.category == cat.name).ToArray();
            
        }// End of order_global_reports_by_category function

        /// <summary>
        /// Print 
        /// </summary>
        public void print_excel_global( Competition competition )
        {
            Microsoft.Office.Interop.Excel.Application xla = new Microsoft.Office.Interop.Excel.Application();
            Workbook wb = xla.Workbooks.Add(XlSheetType.xlWorksheet);
            Worksheet ws = (Worksheet)xla.ActiveSheet;

            xla.Visible = true;

            ws.Cells[1, 1] = competition.name;

            ws.Cells[2, 1] = "Posición Global";
            ws.Cells[2, 2] = "Posición Categoría";
            ws.Cells[2, 3] = "Número de competidor";
            ws.Cells[2, 4] = "Nombre Competidor";
            ws.Cells[2, 5] = "Categoría";
            ws.Cells[2, 6] = "Tiempo Total";
            ws.Cells[2, 7] = "Estatus";
            ws.Cells[2, 8] = "CHPS";

            for( int i = 0; i < report_array.Length; i++ )
            {
                ws.Cells[3 + i, 1] = report_array[i].global_score;
                ws.Cells[3 + i, 2] = report_array[i].category_score;
                ws.Cells[3 + i, 3] = report_array[i].competitor_num;
                ws.Cells[3 + i, 4] = report_array[i].competitors_name;
                ws.Cells[3 + i, 5] = report_array[i].category;
                ws.Cells[3 + i, 6] = report_array[i].total_time;
                ws.Cells[3 + i, 7] = report_array[i].disqualified == true ? "DESCALIFICADO" : "APROBADO";
                StringBuilder str = new StringBuilder();
                int j = 1;
                foreach ( string s in report_array[i].times )
                {
                    if (j == report_array[i].times.Count)
                    {
                        str.Append("FINISH");
                    }
                    else
                    {
                        str.Append("CHP")
                            .Append(j++);
                    }
                    str.Append( ": " )
                        .Append( s )
                        .Append( " " );
                }
                ws.Cells[3 + i, 8] = str.ToString();
            }
        }// End of print_excel_global function

        /// <summary>
        /// Print excel global by category
        /// </summary>
        public void print_excel_categories( Category category )
        {
            Microsoft.Office.Interop.Excel.Application xla = new Microsoft.Office.Interop.Excel.Application();
            Workbook wb = xla.Workbooks.Add(XlSheetType.xlWorksheet);
            Worksheet ws = (Worksheet)xla.ActiveSheet;

            xla.Visible = true;
            
            ws.Cells[1, 1] = category.name;

            ws.Cells[2, 1] = "Posición Categoría";
            ws.Cells[2, 2] = "Posición Global";
            ws.Cells[2, 3] = "Número de competidor";
            ws.Cells[2, 4] = "Nombre Competidor";
            ws.Cells[2, 5] = "Categoría";
            ws.Cells[2, 6] = "Tiempo Total";
            ws.Cells[2, 7] = "Estatus";
            ws.Cells[2, 8] = "CHPS";

            for (int i = 0; i < report_array.Length; i++)
            {
                ws.Cells[3 + i, 1] = report_array[i].category_score;
                ws.Cells[3 + i, 2] = report_array[i].global_score;
                ws.Cells[3 + i, 3] = report_array[i].competitor_num;
                ws.Cells[3 + i, 4] = report_array[i].competitors_name;
                ws.Cells[3 + i, 5] = report_array[i].category;
                ws.Cells[3 + i, 6] = report_array[i].total_time;
                ws.Cells[3 + i, 7] = report_array[i].disqualified == true ? "DESCALIFICADO" : "APROBADO";
                StringBuilder str = new StringBuilder();
                int j = 1;
                foreach (string s in report_array[i].times)
                {
                    if (j == report_array[i].times.Count)
                    {
                        str.Append("FINISH");
                    }
                    else
                    {
                        str.Append("CHP")
                            .Append(j++);
                    }
                    str.Append(": ")
                        .Append(s)
                        .Append(" ");
                }
                ws.Cells[3 + i, 8] = str.ToString();
            }
        }// End of print_excel_global function

        /// <summary>
        /// Report control load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ReportControl_Load(object sender, EventArgs e)
        {
            // load the competitions on the list
            loadCompetitionsList();
        }// End of report control load function

        /// <summary>
        /// Load competitions list
        /// </summary>
        private void loadCompetitionsList()
        {
            competitions = getCompetitions();
            foreach (Competition c in competitions)
            {
                competitions_strings.Add(c.name);
            }
            lbCompetitions.DataSource = competitions_strings.ToList();
        }// End of load competitions list function

        /// <summary>
        /// Get competition by selected list
        /// </summary>
        /// <returns></returns>
        public Competition getCompetitionBySelectedList()
        {
            return competitions.Where(
                competition =>
                    competition.name == lbCompetitions.SelectedItem.ToString()).First();
        }// End of getCompetitionBySelectedList function

        /// <summary>
        /// Load competitions categories
        /// </summary>
        private void loadCompetitionsCategories()
        {
            categories = event_control.competition_service.getCategoriesById(getCompetitionBySelectedList().id, null );
            categories_strings = new List<string>();
            foreach ( Category c in categories )
            {
                categories_strings.Add( c.name );
            }
            lbCategories.DataSource = categories_strings.ToList();
        }// End of load competitions categories function

        /// <summary>
        /// Get category by selected list 
        /// </summary>
        /// <returns></returns>
        public Category getCategoryBySelectedList()
        {
            return categories.Where(
                category =>
                    category.name == lbCategories.SelectedItem.ToString()).First();
        }// End of getCategoryBySelectedList function

        /// <summary>
        /// LBCompetitions selected index changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lbCompetitions_SelectedIndexChanged(object sender, EventArgs e)
        {
            loadCompetitionsCategories();
        }// end of lbCompetitions_SelectedIndexChanged function

        /// <summary>
        /// Check box global cheched changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbGlobal_CheckedChanged(object sender, EventArgs e)
        {
            if (cbGlobal.Checked)
            {
                lbCategories.Enabled = false;
            }
            else
            {
                lbCategories.Enabled = true;
            }
        }// End of cbGlobal_CheckedChanged function

    }// End of Report Control class
}
