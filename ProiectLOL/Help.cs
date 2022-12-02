using System;
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

namespace ProiectLOL
{
    public partial class Help : Form
    {
        
        public Help()
        {
            InitializeComponent();
            
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            labelTemperaturaCritica.Text = trackBar1.Value.ToString();
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            labelTimpIncalzire.Text = trackBar2.Value.ToString();
        }

        private void trackBar3_Scroll(object sender, EventArgs e)
        {
            labelTimpMentinere.Text = trackBar3.Value.ToString();
        }

        private void Help_Load(object sender, EventArgs e)
        {

        }
    }
}
