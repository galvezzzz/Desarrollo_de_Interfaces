using System;
using System.Windows.Forms;

namespace PrimeraPrueba
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void boton1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                listaTexto1.Items.Add(cajaTexto1.Text);
                cajaTexto1.Text = "";
            }
            else if (radioButton2.Checked) {
                listaTexto2.Items.Add(cajaTexto1.Text);
                cajaTexto1.Text = "";
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
