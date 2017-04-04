using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.Ports;

namespace MutilSerialPort
{
    class SerialPortAgent
    {
        public Form1 m_from;
        SerialPort serialPort;
        int count;
        string COMNo;

        public SerialPortAgent()
        {
            count = 0;
            serialPort = new SerialPort();
        }
        ~SerialPortAgent()
        {
            serialPort.Close();
        }
        private void configSerialPort(string COMNo)
        {
            serialPort.PortName = COMNo;
            serialPort.BaudRate = 9600;
            serialPort.DataBits = 8;
            serialPort.StopBits = StopBits.One;
            serialPort.Parity = Parity.None;
        }
        public void startSerialPort(string COMNo)
        {
            this.COMNo = COMNo;
            configSerialPort(COMNo);
            try
            {
                serialPort.Open();
            }
            catch (Exception msg)
            {
                //异常信息
            }
            serialPort.ReceivedBytesThreshold = 9;
            serialPort.DataReceived += new SerialDataReceivedEventHandler(serialPort_DataReceived);//委托事件
        }

        void serialPort_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            count++;
            flushFromTextBox(COMNo);
        }

        private void flushFromTextBox(string COMNo)
        {
            switch (COMNo)
            {
                case "COM3":
                    m_from.textBox1_inf.Text = "" + count;
                    break;
                case "COM5":
                    m_from.textBox2_inf.Text = "" + count;
                    break;
                case "COM6":
                    m_from.textBox3_inf.Text = "" + count;
                    break;
                default:
                    break;
            }
        }

        
    }
}
