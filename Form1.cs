using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;


namespace SONAR
{
    public partial class Form1 : Form
    {
        SerialPort _serialPort;
        delegate void SetTextDelegate(string value); 
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
             _serialPort = new SerialPort();
             _serialPort.BaudRate = 9600;
             _serialPort.Parity = Parity.None;
             _serialPort.DataBits = 8;
             _serialPort.ReadTimeout = 500;
             _serialPort.WriteTimeout = 500;
             _serialPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                _serialPort.PortName = txtCOM.Text;
                if (!_serialPort.IsOpen)
                    _serialPort.Open();
            }
            catch
            {
                MessageBox.Show("Error opening the serial port!");
            }


        }

        public void SetText(string value)
        {
            if (InvokeRequired)
                try
                {
                    Invoke(new SetTextDelegate(SetText), value);
                }
                catch { }
            else
				label1.Text = value;
        } 

        private  void DataReceivedHandler(object sender,SerialDataReceivedEventArgs e)
        {
            string indata = _serialPort.ReadLine();
            SetText(indata);
        }

        private void label1_TextChanged(object sender, EventArgs e)
        {
            if (int.Parse(label1.Text) <= 100 && int.Parse(label1.Text) >= 0)
            prgsCM.Value = (int) (int.Parse(label1.Text) /* * 0.25 */ );
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (_serialPort.IsOpen)
                _serialPort.Close();
            
           
        }

		private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			AboutBox1 box = new AboutBox1();
			box.ShowDialog();
		}

		private void instuctablesToolStripMenuItem_Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start("https://www.instructables.com/member/vandenbrande/instructables/");
		}

		private void youtubeToolStripMenuItem_Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start("https://www.youtube.com/channel/UCzk_SWD_SASF8UE2FPk9LOA");
		}

		private void fBToolStripMenuItem_Click(object sender, EventArgs e)
		{
			System.Diagnostics.Process.Start("https://www.facebook.com/ArduinoProjects101/");
		}
	}
}
