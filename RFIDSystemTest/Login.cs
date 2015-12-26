using RFIDSystemTest.Resources.Login;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RFIDSystemTest
{
    /// <summary>
    /// Login Class
    /// </summary>
    public partial class Login : Form
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public Login()
        {
            InitializeComponent();
            addText_Resources();
        }//End of constructor

        /// <summary>
        /// AddText_Resources
        /// </summary>
        private void addText_Resources()
        {
            this.lUsername.Text = LoginResource.lUsername;
            this.lPassword.Text = LoginResource.lPassword;
            this.bSignIn.Text = LoginResource.bSignIn;
            this.bSignUp.Text = LoginResource.bSingUp;
        }//End of addTextResources function

        /// <summary>
        /// bSign_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bSignIn_Click(object sender, EventArgs e)
        {

        }//End of bSignIn_click function

        /// <summary>
        /// bSignUp Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bSignUp_Click(object sender, EventArgs e)
        {

        }//End of bSignUp click function

    }//End of Login Class

}//End of namespace
