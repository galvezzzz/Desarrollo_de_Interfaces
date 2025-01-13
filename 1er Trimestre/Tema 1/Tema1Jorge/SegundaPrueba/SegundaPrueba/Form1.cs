using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SegundaPrueba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            radioButton1.Checked = true;
            radioButton6.Checked = true;
            radioButton9.Checked = true;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Black;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Green;
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.ForeColor = Color.Red;
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.White;
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.Green;
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.Red;
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            Font fuente1 = new Font(FontFamily.GenericSansSerif, 10);
            textBox1.Font = fuente1;
        }

        private void radioButton8_CheckedChanged(object sender, EventArgs e)
        {
            Font fuente2 = new Font(FontFamily.GenericSansSerif, 12);
            textBox1.Font = fuente2;
        }
        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {
            Font fuente3 = new Font(FontFamily.GenericSansSerif, 14);
            textBox1.Font = fuente3;
        }
    }
}
