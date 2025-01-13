namespace Formulario2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                textBox1.ForeColor = Color.Red;
            }
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton2.Checked)
            {
                textBox1.ForeColor = Color.Black;
            }
        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton3.Checked)
            {
                textBox1.ForeColor = Color.Blue;
            }
        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton6.Checked)
            {
                textBox1.BackColor = Color.Red;
            }
        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton4.Checked)
            {
                textBox1.BackColor = Color.Blue;
            }
        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton5.Checked)
            {
                textBox1.BackColor = Color.Black;
            }
        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton9.Checked)
            {
                textBox1.Font = new System.Drawing.Font(FontFamily.GenericSansSerif, 30, FontStyle.Regular);
            }
        }

        private void radioButton8_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton8.Checked)
            {
                textBox1.Font = new System.Drawing.Font(FontFamily.GenericSansSerif, 20, FontStyle.Regular);
            }
        }

        private void radioButton7_CheckedChanged_1(object sender, EventArgs e)
        {
            if (radioButton7.Checked)
            {
                textBox1.Font = new System.Drawing.Font(FontFamily.GenericSansSerif, 10, FontStyle.Regular);
            }
        }
    }
}
