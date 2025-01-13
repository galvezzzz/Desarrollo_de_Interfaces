using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TerceraPrueba.Properties;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TerceraPrueba
{
    public partial class Form1 : Form
    {
        private List<string> extra1;
        private List<string> extra2;
        private List<string> extra3;
        private List<string> extra4;
        private List<string> extra5;

        public Form1()
        {
            InitializeComponent();
        }
        
        private void cargarDatos()
        {
            extra1 = new List<string>() { "Audio BOSE", "Aire bizona", "Camara trasera", "Sensores" };
            extra2 = new List<string>(extra1) { "Asientos de cuero", "Control de velocidad", "Sensor cambio carril" };
            extra3 = new List<string>(extra2) { "GPS", "Llantas 18", "Asistente aparcamiento", "Automatico" };
            extra4 = new List<string>(extra3) { "Andro0id auto", "CR7 de asistente", "Asistente calefactores" };
            extra5 = new List<string>(extra4) { "Descapotable" };
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.Image = null;
            cargarDatos();
        }

        private void addInBoxList1(List<string> extra)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox1.Items.AddRange(extra.ToArray());
        }

        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            listBox1.Items.Add(comboBox1.Text);
            switch (comboBox1.Text)
            {
                case "Ceed":
                    pictureBox1.Image = Resources.Ceed;
                    addInBoxList1(extra5);
                    break;
                case "Niro":
                    pictureBox1.Image = Resources.Niro;
                    addInBoxList1(extra3);
                    break;
                case "Picanto":
                    pictureBox1.Image = Resources.picanto;
                    addInBoxList1(extra2);
                    break;
                case "Sorento":
                    pictureBox1.Image = Resources.Sorento;
                    addInBoxList1(extra4);
                    break;
                case "Sportage":
                    pictureBox1.Image = Resources.Sportage;
                    addInBoxList1(extra1);
                    break;
                default:
                    break;
            }
        }

        private void moveToBoxList2()
        {
            List<string> extras = new List<string>();

            foreach (int i in listBox1.SelectedIndices)
            {
                extras.Add(listBox1.Items[i].ToString());
            }
            listBox2.Items.AddRange(extras.ToArray());
            foreach (string c in extras)
            {
                listBox1.Items.Remove(c);
            }
        }

        private void botonAnyadir_Click(object sender, EventArgs e)
        {
            moveToBoxList2();
        }

        private void moveToBoxList1()
        {
            List<string> extras = new List<string>();

            foreach (int i in listBox2.SelectedIndices)
            {
                extras.Add(listBox2.Items[i].ToString());
            }
            listBox1.Items.AddRange(extras.ToArray());
            foreach (string c in extras)
            {
                listBox2.Items.Remove(c);
            }
        }

        private void botonQuitar_Click(object sender, EventArgs e)
        {
            moveToBoxList1();
        }

        private void moveToBoxList3()
        {
            if (listBox3.Items.Count == 3)
            {
                label3.Text = "Ya hay 3 descuentos";
            }
            else
            {
                if (textBox1.Text.Length != 5)
                {
                    label3.Text = "Tiene que tener 5 letras";
                }
                else
                {
                    listBox3.Items.Add(textBox1.Text);
                    label3.Text = "";
                    
                }
            }
            textBox1.Clear();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Enter)
            {
                moveToBoxList3();
            } else if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back) {
                e.Handled = true;
            }
        }


        private void listBox3_KeyDown(object sender, KeyEventArgs e)
        {
                if (e.KeyCode == Keys.Delete)
                {
                    listBox3.Items.Remove(listBox3.SelectedItem);
                }
        }
    }
}

