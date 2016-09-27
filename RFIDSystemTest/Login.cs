using Ninject;
using RFIDSystemTest;
using RFIDSystemTest.Business.Implementations.Users;
using RFIDSystemTest.Business.Interfaces;
using RFIDSystemTest.Data;
using RFIDSystemTest.Helpers;
using RFIDSystemTest.Resources.Login;
using RFIDSystemTest.Warriror;
using System;
using System.Reflection;
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
        }//End of addTextResources function

        /// <summary>
        /// bSign_Click
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void bSignIn_Click(object sender, EventArgs e)
        {
            if (!txtUserName.Text.Equals(TWords.EMPTY) && !txtPassword.Text.Equals(TWords.EMPTY))
            {
                // Init a user
                User user = new User();
                // Set the user name and the password on the user
                user.username = txtUserName.Text;
                user.password = txtPassword.Text;
                // Get the user_service
                IUserService user_service = Injection.kernel.Get<UserService>();
                // Login the user
                if (user_service.loginUser(user) != null)
                {
                    Hide();
                    Dashboard dashboard = new Dashboard();
                    dashboard.Show();
                }
                else {
                    ControlHelper.ErrorBox( "User name and password not correct", 500 );
                }
            }
        }//End of bSignIn_click function

        /// <summary>
        /// Login load
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Login_Load(object sender, EventArgs e)
        {
            // Injection stuff
            Injection.kernel.Load(Assembly.GetExecutingAssembly());
            // Get the user service

        }// End of Login_Load function

    }//End of Login Class

}//End of namespace
