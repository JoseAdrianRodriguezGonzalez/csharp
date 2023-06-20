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

namespace Interfaz_mejorada
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Encendido_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            comboBox2.Text = "9600";
            progressBar1.Value = 0;
            Encendido.Image = Properties.Resources.kisspng_button_clip_art_red_power_button_5a84cb2cd16a64_9641772815186522048578;
            string[] lista= SerialPort.GetPortNames();
            comboBox1.Items.AddRange(lista);
        }
    }
}
