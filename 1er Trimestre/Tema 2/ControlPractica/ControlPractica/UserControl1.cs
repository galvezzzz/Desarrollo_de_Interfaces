using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlPractica
{
    public partial class UserControl1: UserControl
    {

        List<string> list;

        public UserControl1()
        {
            InitializeComponent();
            list = new List<string>();
        }

        private void textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            list.Add(textBox.Text);

            if (listaPalabras.Items.Count >= 5)
            {
                
                if (e.KeyChar == Convert.ToChar(Keys.Enter))
                {
                    listaPalabras.BackColor = Color.Red;
                    MessageBox.Show("No puedes introducir más de 5 valores", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    e.Handled = true;
                    return;
                }
                
            }
            else
            {
                if (e.KeyChar == Convert.ToChar(Keys.Enter))
                {
                    listaPalabras.Items.Add(textBox.Text);
                    comprobarPalabraMasLarga();
                    e.Handled = true; //elimina el sonido
                    textBox.Text = "";
                    
                }
            }

            
        }

        public string comprobarPalabraMasLarga()
        {
            string palabra = textBox.Text;
            bool esMasLarga = false;

            if(palabra.Length > label1.Text.Length)
            {
                label1.Text = palabra;
                esMasLarga = true;
            }
            
            return label1.Text;
        }
    }
}
