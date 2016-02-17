using System;
using System.Windows.Forms;
using RFIDSystemTest.Business.Interfaces.Events;
using RFIDSystemTest.Business.Interfaces.Competitors;
using RFIDSystemTest.Views.Competitors;
using RFIDSystemTest.Business.Interfaces.States;
using RFIDSystemTest.Warriror;

namespace RFIDSystemTest.Views.Events
{
    /// <summary>
    /// Event control class
    /// </summary>
    public partial class EventControl : UserControl
    {
        #region Controls
        public ListEvent list_event_control;
        public MenuEvent menu_event_control;
        public NewEvent new_event_control;
        public DetailEvent detail_event_control;
        public NewCompetition new_competition_control;
        public NewRegister new_register_control;
        #endregion Controls

        #region Services
        public ICompetitionService competition_service;
        public IEventService event_service;
        public ICompetitionTypeService competition_type_service;
        public ICategoryService category_service;
        public ICompetitorService competitor_service;
        public IRegisterService register_service;
        public IKitStateService kit_state_service;
        public IRegisterStateService register_state_service;
        #endregion Services

        /// <summary>
        /// Constructor
        /// </summary>
        public EventControl
        ( 
            IEventService event_service, 
            ICompetitionService competition_service, 
            ICompetitionTypeService competition_type_service, 
            ICategoryService category_service,
            ICompetitorService competitor_service,
            IRegisterService register_service,
            IKitStateService kit_state_service,
            IRegisterStateService register_state_service
        )
        {
            // Default stuff
            InitializeComponent();
            // Assign services
            this.event_service = event_service;
            this.competition_service = competition_service;
            this.competition_type_service = competition_type_service;
            this.category_service = category_service;
            this.competitor_service = competitor_service;
            this.register_service = register_service;
            this.kit_state_service = kit_state_service;
            this.register_state_service = register_state_service;
            /// Init controls
            list_event_control = new ListEvent( this );
            menu_event_control = new MenuEvent( this );
            new_event_control = new NewEvent( this );
            detail_event_control = new DetailEvent( this );
            new_competition_control = new NewCompetition( this );
            new_register_control = new NewRegister( this );
        }// End of Constructor function

        /// <summary>
        /// Event Control Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EventControl_Load(object sender, EventArgs e)
        {
            // Clear controls
            Controls.Clear();
            // Add the event menu control
            Controls.Add( menu_event_control );
            // Theme shit
            ThemeShit();
        }// End of EventControl_Load function
        /// <summary>
        /// Theme shit of the fuckin control
        /// </summary>
        private void ThemeShit()
        {
            ThemeDark.ResponsiveDesign(this, Parent, 1, 1);
        }// End of Theme Shit function

    }// End of Event Control class
}
