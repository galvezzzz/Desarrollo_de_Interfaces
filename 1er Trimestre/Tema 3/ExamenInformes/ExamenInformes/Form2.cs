using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Reflection.Emit;

namespace ExamenInformes
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Form1 form = new Form1();
            
            form.CiudadesGrandes = cbCiudadesGrandes.Checked;
            form.ActivarZonaHoraria = checkBox1.Checked;
            form.ZonaHoraria = comboBox1.Text;

            if (!textBox1.Text.Equals(""))
            {
                form.BuscaCiudad = textBox1.Text;
            }
            else
            {
                form.BuscaCiudad = "";
            }

            form.ShowDialog();
        }


        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked) { 
                comboBox1.Enabled = true;
            }
            else
            {
                comboBox1.Enabled=false;
            }
        }
    }
}
