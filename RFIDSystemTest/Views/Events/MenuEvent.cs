using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RFIDSystemTest.Helpers;
using RFIDSystemTest.Warriror;

namespace RFIDSystemTest.Views.Events
{
    /// <summary>
    /// Menu Event Control
    /// </summary>
    public partial class MenuEvent : UserControl
    {
        public EventControl event_control;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="event_control"></param>
        public MenuEvent( EventControl event_control )
        {
            InitializeComponent();
            this.event_control = event_control;

            this.AutoScaleMode = AutoScaleMode.Inherit;
        }// End of Constructor function 

        /// <summary>
        /// Button list click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bList_Click(object sender, EventArgs e)
        {
            ControlHelper.LoadControlOnControl( event_control, event_control.list_event_control );
        }// End of bList_Click function

        /// <summary>
        /// Menu Event Load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MenuEvent_Load(object sender, EventArgs e)
        {
            ThemeShit();
        }// End of MenuEvent_Load function

        /// <summary>
        /// Theme shit
        /// </summary>
        public void ThemeShit()
        {
            ThemeDark.ResponsiveDesign(this, Parent.Parent, 1, 1 );
            ThemeDark.SetButtonsTheme( this );
            ThemeDark.ButtonsResponsiveWidth(bList, this, .8);
            ThemeDark.ButtonsResponsiveWidth(bNew, this, .8);
            ThemeDark.ButtonsResponsiveWidth(bSearch, this, .8);
            ThemeDark.ButtonsResponsiveWidth(bMore, this, .8);
            this.BackColor = Color.FromArgb(248, 248, 248);
        }// End of Theme Shit function

        /// <summary>
        /// Button new click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bNew_Click(object sender, EventArgs e)
        {
            ControlHelper.LoadControlOnControl( event_control, event_control.new_event_control );
            event_control.new_event_control.cleanFields();
        }// End of bNew_Click function

        private void bMore_Click(object sender, EventArgs e)
        {
            ControlHelper.LoadControlOnControl(event_control, event_control.timing_control);
        }// End of bMore_click function

    }// End of Menu Event control class
}
