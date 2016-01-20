using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RFIDSystemTest.Helpers
{
    /// <summary>
    /// Control helper
    /// </summary>
    public static class ControlHelper
    {
        /// <summary>
        /// Load control on control
        /// </summary>
        /// <param name="main_cointrol"></param>
        /// <param name="control_to_load"></param>
        public static void LoadControlOnControl(UserControl main_cointrol, UserControl control_to_load) {
            main_cointrol.Controls.Clear();
            main_cointrol.Controls.Add( control_to_load );
        }// End of Load Control On Control function

        /// <summary>
        /// Warning box
        /// </summary>
        /// <param name="message"></param>
        public static void WarningBox( string message )
        {
            MessageBox.Show(message,
                    "Warning",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning,
                    MessageBoxDefaultButton.Button1);
        }// End of WarningBox function

        /// <summary>
        /// Success Box
        /// </summary>
        /// <param name="message"></param>
        public static void SuccessBox( string message )
        {
            MessageBox.Show(message,
                    "Success",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk,
                    MessageBoxDefaultButton.Button1);

        }// End of Success box function

        /// <summary>
        /// Error box
        /// </summary>
        public static void ErrorBox(string message, int error_code )
        {
            MessageBox.Show(message,
                    String.Format( "Error [{0}]", error_code), 
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Stop,
                    MessageBoxDefaultButton.Button1);
        }// end of Error box function

    }// End of Control Helper class
}
