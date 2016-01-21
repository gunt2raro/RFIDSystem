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

namespace RFIDSystemTest.Views.Events
{
    public partial class EventControl : UserControl
    {
        public ListEvent list_event_control;
        public MenuEvent menu_event_control;
        public NewEvent new_event_control;
        public DetailEvent detail_event_control;

        public IEventService event_service;
        
        /// <summary>
        /// Constructor
        /// </summary>
        public EventControl( IEventService event_service )
        {

            InitializeComponent();

            this.event_service = event_service;

            list_event_control = new ListEvent( this );
            menu_event_control = new MenuEvent( this );
            new_event_control = new NewEvent( this );
            detail_event_control = new DetailEvent( this );

            this.AutoScaleMode = AutoScaleMode.Inherit;

        }// End of Constructor function

        /// <summary>
        /// Event Control Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EventControl_Load(object sender, EventArgs e)
        {

            Controls.Clear();
            Controls.Add( menu_event_control );

        }// End of EventControl_Load function

    }// End of Event Control class
}
