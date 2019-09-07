using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CalcularRadio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lblradio.Visible = false;
        }

        private void btnir_Click(object sender, EventArgs e)
        {
            string radio = txtradio.Text;
            
            double area = Convert.ToDouble(radio);
            area = Math.Pow(area, 2) * Math.PI;

            lblradio.Text = Convert.ToString(area);
            lblradio.Visible = true;
        }
    }
}
