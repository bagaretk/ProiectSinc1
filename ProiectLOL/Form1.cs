﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ProiectLOL
{
    public partial class Proiect : Form
    {
        Series series;
        int[] pointsArray = {1,2 };
        SerialPort _serialPort = new SerialPort("COM11", 9600, Parity.None, 8, StopBits.One);
        public Proiect()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private delegate void SetTextDeleg(string text);
        private void Proiect_Load(object sender, EventArgs e)
        {
            // all of the options for a serial device  
            // ---- can be sent through the constructor of the SerialPort class  
            // ---- PortName = "COM8", Baud Rate = 19200, Parity = None,  
            // ---- Data Bits = 8, Stop Bits = One, Handshake = None  
            _serialPort.Handshake = Handshake.None;
            _serialPort.DataReceived += new SerialDataReceivedEventHandler(sp_DataReceived);
            _serialPort.Open();
            this.chart1.Titles.Add("Pets");
            this.chart1.Series.Clear();
            series = this.chart1.Series.Add("Temperatura");

        }

        private void sp_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            Thread.Sleep(2000);
            string data = _serialPort.ReadLine();
            // Invokes the delegate on the UI thread, and sends the data that was received to the invoked method.  
            // ---- The "si_DataReceived" method will be executed on the UI thread which allows populating of the textbox.  
            if(data != "0.00")
                this.BeginInvoke(new SetTextDeleg(si_DataReceived), new object[] { data });
           
        }

        private void si_DataReceived(string data)
        {
            if (data != "0.00") ;
                textBox1.Text = data.Trim();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (!(_serialPort.IsOpen))
                    _serialPort.Open();
                _serialPort.Write( Int32.Parse(textBox2.Text) + "\r\n");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error opening/writing to serial port :: " + ex.Message, "Error!");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(textBox1.Text != "")
                series.Points.Add(double.Parse(textBox1.Text)); 
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
