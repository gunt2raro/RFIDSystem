using Ninject;
using RFIDSystemTest.Business.Implementations.States;
using RFIDSystemTest.Business.Interfaces.States;
using RFIDSystemTest.Warriror;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RFIDSystemTest
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {

            Application.EnableVisualStyles();

            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());

        }//End of main method

    }//End of Program class

}//End of namespace 
