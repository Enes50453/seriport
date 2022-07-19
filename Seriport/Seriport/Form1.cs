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

namespace Seriport
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            foreach (var seriport in SerialPort.GetPortNames())
            {
                comboBox1.Items.Add(seriport);
            }
            comboBox1.SelectedIndex = 0;
            buton_disconnect.Enabled = false;
            buttonsend.Enabled = false;
        }

        private void buttonconnect_Click(object sender, EventArgs e)
        {
            serialPort1.PortName = comboBox1.Text;
            serialPort1.BaudRate = 9600;
            serialPort1.Parity = Parity.Even;
            serialPort1.StopBits = StopBits.One;
            serialPort1.DataBits = 8;
            try
            {
                serialPort1.Open(); 
            }
            catch (Exception Hata)
            {
                MessageBox.Show("Seri port bağlantısı yapılamadı \n Hata:" + Hata.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (serialPort1.IsOpen);
            {
                buttonconnect.Enabled = false;
                buton_disconnect.Enabled = true;
                buttonsend.Enabled = true;
            }
        }

        private void buton_disconnect_Click(object sender, EventArgs e)
        {
            if (serialPort1.IsOpen) ;
            {
                serialPort1.Close();
                buttonconnect.Enabled = true;
                buton_disconnect.Enabled = false;
                buttonsend.Enabled = false;
            }
        }

        private void buttonsend_Click(object sender, EventArgs e)
        {
            if(serialPort1.IsOpen)
            {
                serialPort1.Write(textBoxsend.Text);
                textBoxsend.Clear();
            }
        }
        public delegate void verigoster(String s);
        public void textboxyaz(String s)
        {
            textBoxalıcı.Text += s;
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            string gelenveri = serialPort1.ReadExisting();
            textBoxalıcı.Invoke(new verigoster(textboxyaz), gelenveri);
        }
    }
}
