using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Informulario
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            form.Check1 = checkBox1.Checked;
            form.Check2 = checkBox2.Checked;
            form.Check3 = checkBox3.Checked;
            form.Check4 = checkBox4.Checked;
            form.Check5 = checkBox5.Checked;
            form.Check6 = checkBox6.Checked;
            form.ValueTrack = trackBar1.Value;
            if (!textBox1.Text.Equals(""))
            {
                form.ValueTextBox = Convert.ToInt32(textBox1.Text);
            } else
            {
                form.ValueTextBox = -1;
            }
            if (!comboBox1.Text.Equals(""))
            {
                form.ValueComboBox = comboBox1.Text;
            }
            else
            {
                form.ValueComboBox = "";
            }

            form.ShowDialog();
        }

        private void checkBox3_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox3.Checked) { 
                trackBar1.Enabled = true;
                label2.Enabled = true;
                label3.Enabled = true;
                label4.Enabled = true;
            }
            else { 
                trackBar1.Enabled = false;
                label2.Enabled = false;
                label3.Enabled = false;
                label4.Text = "0";
                label4.Enabled = false;
                trackBar1.Value = 0;
            }
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            label4.Text = trackBar1.Value.ToString();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                textBox1.Enabled = true;
                label5.Enabled = true;
            }
            else
            {
                textBox1.Enabled = false;
                label5.Enabled = false;
                textBox1.Text = "";
            }
        }

        private void checkBox5_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox5.Checked)
            {
                comboBox1.Enabled = true;
                label6.Enabled = true;
            }
            else
            {
                comboBox1.Enabled = false;
                label6.Enabled = false;
                comboBox1.Text="";
            }
        }
    }
}
