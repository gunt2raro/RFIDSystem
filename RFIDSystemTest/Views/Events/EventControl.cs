using System;
using System.Windows.Forms;
using RFIDSystemTest.Business.Interfaces.Events;

namespace RFIDSystemTest.Views.Events
{
    /// <summary>
    /// Event control class
    /// </summary>
    public partial class EventControl : UserControl
    {
        // Controls
        public ListEvent list_event_control;
        public MenuEvent menu_event_control;
        public NewEvent new_event_control;
        public DetailEvent detail_event_control;
        public NewCompetition new_competition_control;
        // Services
        public ICompetitionService competition_service;
        public IEventService event_service;
        public ICompetitionTypeService competition_type_service;
        public ICategoryService category_service;

        /// <summary>
        /// Constructor
        /// </summary>
        public EventControl( IEventService event_service, ICompetitionService competition_service, ICompetitionTypeService competition_type_service, ICategoryService category_service )
        {
            // Default stuff
            InitializeComponent();
            // Assign services
            this.event_service = event_service;
            this.competition_service = competition_service;
            this.competition_type_service = competition_type_service;
            this.category_service = category_service;
            /// Init controls
            list_event_control = new ListEvent( this );
            menu_event_control = new MenuEvent( this );
            new_event_control = new NewEvent( this );
            detail_event_control = new DetailEvent( this );
            new_competition_control = new NewCompetition( this );
            //  Auto scale mode shit
            this.AutoScaleMode = AutoScaleMode.Inherit;

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

        }// End of EventControl_Load function

    }// End of Event Control class
}
