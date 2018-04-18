using System;
using System.IO.Ports;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PumpUpdater
{
    public partial class Form1 : Form
    {
        public Form1()
        {
         
            InitializeComponent();

            //populate ports in combo box
            string[] ports = SerialPort.GetPortNames();
            ComboBox.Items.Clear();
            foreach (string comport in ports)
            {
                ComboBox.Items.Add(comport);
            }
        }

        private void ComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            ConnectSend();

        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            ConnectSend();
        }

        private void ConnectSend()
        {
            //setup com port
            SerialPort mySerialPort = new SerialPort(ComboBox.Text);
            mySerialPort.BaudRate = 9600;
            mySerialPort.Parity = Parity.None;
            mySerialPort.StopBits = StopBits.One;
            mySerialPort.DataBits = 8;
            mySerialPort.Handshake = Handshake.None;
            //open port, send test, close port.
            mySerialPort.Open();
            mySerialPort.Write("hello world" + " value set to " + trackBar1.Value + Environment.NewLine);
            mySerialPort.Close();
            //did your device recieve data?
        }
    }
}
