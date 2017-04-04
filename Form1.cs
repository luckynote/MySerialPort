using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;

namespace MutilSerialPort
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_start_Click(object sender, EventArgs e)
        {
            SerialPortAgent serialPort1 = new SerialPortAgent();
            serialPort1.m_from = this;
            serialPort1.startSerialPort("COM3");
        }
       
        private void button2_start_Click(object sender, EventArgs e)
        {
            SerialPortAgent serialPort2 = new SerialPortAgent();
            serialPort2.m_from = this;
            serialPort2.startSerialPort("COM5");
        }

      
        private void button3_start_Click(object sender, EventArgs e)
        {
            SerialPortAgent serialPort3 = new SerialPortAgent();
            serialPort3.m_from = this;
            serialPort3.startSerialPort("COM6");
        }
      
       

        private void Form1_Load(object sender, EventArgs e)
        {
            Control.CheckForIllegalCrossThreadCalls = false;
        }
    }
}
