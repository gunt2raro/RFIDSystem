using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace RFIDSystemTest.Views.Timing
{
    /// <summary>
    /// Timing control
    /// </summary>
    public partial class TimingControl : UserControl
    {
        
        /// <summary>
        /// Constructor
        /// </summary>
        public TimingControl()
        {
            InitializeComponent();
            this.serialPort1 = new SerialPort("COM5");

            serialPort1.BaudRate = 57600;
            serialPort1.Parity = Parity.None;
            serialPort1.StopBits = StopBits.One;
            serialPort1.DataBits = 8;
            serialPort1.Handshake = Handshake.None;
            serialPort1.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
            
        }// End of constructor function

        private void TimingControl_Load(object sender, EventArgs e)
        {

        }
        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            SerialPort sp = (SerialPort)sender;
            string indata = sp.ReadExisting();
            textBox1.AppendText( indata );
            //("Data Received:");
            //Debug.Print(indata);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }// End of Timing Control class
}
