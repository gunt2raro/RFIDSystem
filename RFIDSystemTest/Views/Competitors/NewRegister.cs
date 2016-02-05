using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RFIDSystemTest.Views.Events;
using RFIDSystemTest.Resources;
using RFIDSystemTest.Warriror;
using RFIDSystemTest.Data.Events;
using RFIDSystemTest.Data.States;
using RFIDSystemTest.Helpers;
using RFIDSystemTest.Data.Competitors;
using RFIDSystemTest.Views.VO;

namespace RFIDSystemTest.Views.Competitors
{
    /// <summary>
    /// New comeptitor register
    /// </summary>
    public partial class NewRegister : UserControl
    {
        // Event Control
        private EventControl event_control;
        private Competitor competitor_o;
        // Important ids
        public int competition_id { get; set; }
        public int event_id { get; set; }
        public bool competitor_selected { get; set; }
        // Competition type shit
        private IList<Category> categories;
        private IList<string> categories_strings;
        private IList<KitState> kit_states;
        private IList<string> kit_states_strings;
        private IList<RegisterState> register_states;
        private IList<string> register_states_strings;
        private IEnumerable<Competitor> competitors;

        /// <summary>
        /// New competitor register
        /// </summary>
        /// <param name="event_control"></param>
        public NewRegister( EventControl event_control )
        {
            // Default stuff
            InitializeComponent();
            // event control injection
            this.event_control = event_control;
            // init other variables
            competitor_selected = false;
        }// End of new competitor register function

        /// <summary>
        /// Clear fileds
        /// </summary>
        public void clearFields()
        {

            txtName.Text = TWords.EMPTY;
            txtSecondName.Text = TWords.EMPTY;
            txtState.Text = TWords.EMPTY;
            txtEmail.Text = TWords.EMPTY;
            txtZipCode.Text = TWords.EMPTY;
            txtCountry.Text = TWords.EMPTY;
            txtAddress.Text = TWords.EMPTY;
            txtCity.Text = TWords.EMPTY;
            txtAddress2.Text = TWords.EMPTY;
            txtPhoneNumber.Text = TWords.EMPTY;

        }// End of clearFields function

        /// <summary>
        /// New register load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NewRegister_Load(object sender, EventArgs e)
        {
            // Theme Shit
            ThemeShit();
            // Resources stuff
            loadResources();
        }// End of NewRegister_Load function

        /// <summary>
        /// Load data
        /// </summary>
        public void loadData()
        {
            // Load categoires
            loadCategories();
            // Load the register states
            loadRegisterStates();
            // Load all the kit states
            loadKitStates();
            // load competitor number
            loadCompetitorNum();
        }// End of loadData function

        /// <summary>
        /// Load Competitor Number Bitch!!!
        /// </summary>
        private void loadCompetitorNum()
        {
            lCompetitorNumberDes.Text = event_control.register_service.getCompetitorNum( competition_id, null ).ToString();
        }// End of loadCompetitorNum function

        /// <summary>
        /// theme shit
        /// </summary>
        public void ThemeShit()
        {
            ThemeDark.ResponsiveDesign(this, Parent.Parent, 1, 1);
            ThemeDark.SetButtonsTheme(this);
            ThemeDark.SetLabelsTheme(this);
        }// end of ThemeShit function

        /// <summary>
        /// Load resources
        /// </summary>
        private void loadResources()
        {
            lName.Text = CompetitorResource.name;
            lSecondName.Text = CompetitorResource.second_name;
            lEmail.Text = CompetitorResource.email;
            lAddress.Text = CompetitorResource.address;
            lCity.Text = CompetitorResource.city;
            lCountry.Text = CompetitorResource.country;
            lState.Text = CompetitorResource.country;
            lCompetitorNumber.Text = RegisterResource.competitor_num;
            lCategory.Text = RegisterResource.category;
            lKitState.Text = RegisterResource.kit_state;
            lTitCompetitor.Text = RegisterResource.lTitCompetitor;
            lTitRegister.Text = RegisterResource.lTitRegister;
        }// End of loadResources function

        /// <summary>
        /// Load categories
        /// </summary>
        private void loadCategories()
        {
            // Init lists
            categories = event_control.competition_service.getCategoriesById(competition_id, null).ToList();
            categories_strings = new List<string>();
            // Add the string names of the categories
            foreach (Category c in categories)
            {
                // Add the name
                categories_strings.Add(c.name);
            }// End of categories interation
            // Set the data source to the combo box
            cbCategory.DataSource = categories_strings.ToList();
        }// End of loadCategories function

        /// <summary>
        /// Load register state
        /// </summary>
        private void loadRegisterStates()
        {
            // Init lists
            register_states = event_control.register_state_service.getAll(null).ToList();
            register_states_strings = new List<string>();
            // Add the string names of the register states
            foreach (RegisterState r in register_states)
            {
                // Add the description
                register_states_strings.Add(r.description);
            }// End of register states interation
            // Set the data source to the combo box
            cbRegisterState.DataSource = register_states_strings.ToList();
        }// End of loadRegisterState function

        /// <summary>
        /// Load kit states
        /// </summary>
        private void loadKitStates()
        {
            // Init lists
            kit_states = event_control.kit_state_service.getAll(null).ToList();
            kit_states_strings = new List<string>();
            // Add the string names of the kit states
            foreach (KitState k in kit_states)
            {
                // Add the description
                kit_states_strings.Add(k.description);
            }// End of kit states interation
            // Set the data source to the combo box
            cbKitState.DataSource = kit_states_strings.ToList();
        }// End of loadKitStates function

        /// <summary>
        /// Button search click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bSearch_Click(object sender, EventArgs e)
        {
            // get the query from the text field
            string query = txtSearch.Text;
            if (query != TWords.EMPTY && query != " ")// If the query is diferent of empty and space
            {
                // set the competitors with a list query
                competitors = 
                    from competitor in event_control.competitor_service.getAll(
                        null).ToList()
                              where string.Format( 
                                  "{0} {1}", 
                                  competitor.name, 
                                  competitor.second_name).Contains(
                                    query)
                              select competitor;
                // set the data competitors data source
                dataCompetitors.DataSource = competitors.Select(
                    o => new CompetitorRegisterVO()
                    {
                        id = o.id,
                        full_name = string.Format("{0} {1}", o.name, o.second_name)
                    }).ToList();
                // set the auto size mode on the columns
                dataCompetitors.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                dataCompetitors.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            }// End of query validation
            else if (query == TWords.EMPTY)// if the query is empty
            {
                dataCompetitors.DataSource = null;
            }// End of if the query is empty
            else// Else put a warning
            {
                ControlHelper.WarningBox("Need to put something on the search box first!!");
            }// End of else warning
        }// End of bSearch_Click function

        /// <summary>
        /// Button register click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bRegister_Click(object sender, EventArgs e)
        {
            // Validate if competitor is selected
            // Just for the register model to be register
            if (isCompeitorSelected())
            {
                // Get the competitor id
                // Crete the register model
                Register register = createRegisterObject();
                // Add the register model with the register service
                register = event_control.register_service.addRegister( register, null );
                // Validate if the register is null
                if (register!=null)
                {
                    // Return success box with adding successful
                    ControlHelper.SuccessBox(SuccessResource.AddSuccessful);
                }
                else// if the register is null return error message
                {
                    // Return error box with adding error
                    ControlHelper.ErrorBox(ErrorResource.AddingError, 500);

                }// End of register validation
                // Return to the detail event view
                event_control.detail_event_control.event_o = event_control.event_service.getById(event_id, null);
                // load detail event data again
                event_control.detail_event_control.loadData();
                // Load detail event control on the event control
                ControlHelper.LoadControlOnControl(event_control, event_control.detail_event_control);
            }// End of competitor validation
            else // Register the competitor, then the register model
            {
                // Create the competitor model
                competitor_o = createCompetitorObject();
                // Add the competitor model to the database
                competitor_o = event_control.competitor_service.addCompetitor( competitor_o, null );
                // If the competitor was succesfuly added create the register model
                if (competitor_o!=null)
                {
                    // Crete the register model
                    Register register = createRegisterObject();
                    // Add the register withs the register service
                    register = event_control.register_service.addRegister( register, null );
                    // Validate if the register is null
                    if (register!=null)
                    {
                        // Return success box with adding successful
                        ControlHelper.SuccessBox(SuccessResource.AddSuccessful);
                    }
                    else// if the register is null return error message
                    {
                        // Return error box with adding error
                        ControlHelper.ErrorBox( ErrorResource.AddingError, 500 );
                    }// EReturnnd of register validation
                    //  to the detail event view
                    event_control.detail_event_control.event_o = event_control.event_service.getById(event_id, null);
                    // load detail event data again
                    event_control.detail_event_control.loadData();
                    // Load detail event control on the event control
                    ControlHelper.LoadControlOnControl(event_control, event_control.detail_event_control);
                }// End of competitor object validation
                else
                {
                    ControlHelper.ErrorBox( ErrorResource.AddingError, 98 );
                }// End of competitor validation
            }// End of else
        }// End of bRegister_Click function

        /// <summary>
        /// Create competitor object
        /// </summary>
        /// <returns></returns>
        private Competitor createCompetitorObject()
        {
            // Init competitor object
            Competitor comp = new Competitor();
            // Fill the competitor attributes
            comp.birth_date = dtBirthDate.Value;
            comp.city = txtCity.Text;
            comp.country = txtCountry.Text;
            comp.email = txtEmail.Text;
            comp.name = txtName.Text;
            comp.second_name = txtSecondName.Text;
            comp.state = txtState.Text;
            comp.address = txtAddress.Text;
            comp.address2 = txtAddress2.Text;
            comp.zip_code = int.Parse(txtZipCode.Text);
            comp.phone_number = txtPhoneNumber.Text;
            comp.sex = cbSex.SelectedItem.Equals("M") ? 0 : 1;
            // REturn competitor object
            return comp;
        }// End of CreateCompetitorObject function

        /// <summary>
        /// Create register object
        /// </summary>
        /// <returns></returns>
        private Register createRegisterObject( )
        {
            // Init register object
            Register reg = new Register();
            // Fill the register attributes
            reg.category = getCategoryId();
            reg.competition = competition_id;
            reg.competitor = competitor_o.id;
            reg.competitor_num = int.Parse(lCompetitorNumberDes.Text);
            reg.kit_state = getKitStateId();
            reg.register_state = getRegisterStateId();
            // Return register object
            return reg;
        }// End of createRegisterObject function

        /// <summary>
        /// Get register state id
        /// </summary>
        /// <returns></returns>
        private int getRegisterStateId()
        {
            return register_states.Where(
                register_state =>
                    register_state.description == cbRegisterState.SelectedItem.ToString()).First().id;
        }// Ed of getRegisterStateId function

        /// <summary>
        /// Get kit state id
        /// </summary>
        /// <returns></returns>
        private int getKitStateId()
        {
            return kit_states.Where(
                kit_state =>
                    kit_state.description == cbKitState.SelectedItem.ToString()).First().id;
        }// End of getKitStateId function

        /// <summary>
        /// Get category id
        /// </summary>
        /// <returns></returns>
        private int getCategoryId()
        {
            return categories.Where(
                category =>
                    category.name == cbCategory.SelectedItem.ToString()).First().id;
        }// End of getCategoryId function

        /// <summary>
        /// Button register another click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bRegisterAnother_Click(object sender, EventArgs e)
        {

        }// End of bRegisterAnother_Click function

        /// <summary>
        /// Button cancel click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bCancel_Click(object sender, EventArgs e)
        {
            event_control.detail_event_control.event_o = event_control.event_service.getById(event_id, null);
            event_control.detail_event_control.loadData();
            ControlHelper.LoadControlOnControl(event_control, event_control.detail_event_control);
        }// End of bCancel_Click function
        
        /// <summary>
        /// Data competitors cell content double click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dataCompetitors_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            using ( DataGridViewRow row = dataCompetitors.SelectedRows[0] )
            {
                // get competitor from selected list
                // this will not make the system go to the service again
                competitor_o = competitors.Where(c => c.id == int.Parse(row.Cells[0].Value.ToString())).First();
                // Fill the competitors fields with the competitor slected
                fillCompetitorFields(competitor_o);
                // Set the competitor selected as true
                competitor_selected = true;
            }
        }// End of dataCompetitors_CellContentDoubleClick function

        /// <summary>
        /// Fill competitor fields
        /// </summary>
        /// <param name="competitor"></param>
        private void fillCompetitorFields(Competitor competitor)
        {
            if (competitor != null)
            {
                txtName.Text = competitor.name;
                txtSecondName.Text = competitor.second_name;
                txtState.Text = competitor.state;
                txtEmail.Text = competitor.email;
                txtZipCode.Text = competitor.zip_code.ToString();
                txtCountry.Text = competitor.country;
                txtAddress.Text = competitor.address;
                txtCity.Text = competitor.city;
                dtBirthDate.Value = competitor.birth_date;
                cbSex.SelectedItem = competitor.sex==0 ? "M" : "F";
                txtAddress2.Text = competitor.address2;
                txtPhoneNumber.Text = competitor.phone_number; 
            }// End of competitor validation

        }// End of fillCompetitorFields function

        /// <summary>
        /// Is competitor selected
        /// </summary>
        /// <returns></returns>
        public bool isCompeitorSelected() {
            return competitor_selected;
        }// End of isCompetitorSelected function

    }// End of NewCompetitorRegister class
}
