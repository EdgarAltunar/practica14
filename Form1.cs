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
using System.Data.Common;

namespace practica12
{
    public partial class Form1 : Form
    {
        delegate void SetTextDelegate(string value);

        public SerialPort ArduinoPort { get; }

        public Form1()
        {
            InitializeComponent();
            btndesconectar.Enabled = false;
            ArduinoPort = new System.IO.Ports.SerialPort();
            ArduinoPort.PortName = "COM5";
            ArduinoPort.BaudRate = 9600;
            ArduinoPort.DataBits = 8;
            ArduinoPort.ReadTimeout = 1000;
            ArduinoPort.WriteTimeout = 1000;
            ArduinoPort.DataReceived += new SerialDataReceivedEventHandler(DataReceivedHandler);

            this.btnConectar.Click += btnConectar_Click;
        }

        private void DataReceivedHandler(object sender, SerialDataReceivedEventArgs e)
        {
            string dato = ArduinoPort.ReadLine();
            EscribirTxt(dato);
        }

        private void EscribirTxt(string dato)
        {
            if (InvokeRequired)
            {
                try
                {
                    Invoke(new SetTextDelegate(EscribirTxt), dato);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al actualizar la temperatura: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                lbTemp.Text = dato;
            }
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {

        }

        private void btndesconectar_Click(object sender, EventArgs e)
        {

        }
    }
}