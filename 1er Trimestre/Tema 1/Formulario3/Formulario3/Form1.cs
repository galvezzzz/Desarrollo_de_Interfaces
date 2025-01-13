using System.Collections;
using System.Collections.Generic;

namespace Formulario3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            List<String> extras1;
            List<String> extras2;
            List<String> extras3;
            List<String> extras4;
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            extras1 = new List<String>() { "Audio Base", "Bizoma", "Cámara trasera", "Sensores" };
            extras2 = new List<String>(extras1) { "Cuero", "Control velocidad", "Cambio carril" };
            extras3 = new List<String>(extras2) { "GPS", "Llantas 18", "Asistencia aparcamiento", "Automático" };
            extras4 = new List<String>(extras3) { "Bale", "CR7", "Benzema" };

            switch (comboBox1.SelectedItem)
            {
                case "Kuga":
                    pictureBox1.ImageLocation = "C:\\Users\\Alberto\\Desktop\\Interfaces\\Formulario3\\ImgCoches\\pngegg (2).png";
                    clearAll();
                    listBox1.Items.AddRange(extras1.ToArray());
                    break;

                case "Mustang":
                    pictureBox1.ImageLocation = "C:\\Users\\Alberto\\Desktop\\Interfaces\\Formulario3\\ImgCoches\\580b585b2edbce24c47b2c6b.png";
                    clearAll();
                    listBox1.Items.AddRange(extras2.ToArray());
                    break;

                case "Fiesta":
                    pictureBox1.ImageLocation = "C:\\Users\\Alberto\\Desktop\\Interfaces\\Formulario3\\ImgCoches\\pngegg (1).png";
                    clearAll();
                    listBox1.Items.AddRange(extras3.ToArray());
                    break;

                case "Puma":
                    pictureBox1.ImageLocation = "C:\\Users\\Alberto\\Desktop\\Interfaces\\Formulario3\\ImgCoches\\Daco_4768015.png";
                    clearAll();
                    listBox1.Items.AddRange(extras4.ToArray());
                    break;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int index = listBox1.SelectedIndex;
            listBox2.Items.Add(listBox1.SelectedItem);
            listBox1.Items.RemoveAt(index);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int index = listBox2.SelectedIndex;
            listBox1.Items.Add(listBox2.SelectedItem);
            listBox2.Items.RemoveAt(index);
        }

        private void clearAll()
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            listBox3.Items.Add(textBox1.Text);
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && listBox3.Items.Count < 3 && textBox1.Text.Length == 5)
            {
                listBox3.Items.Add(textBox1.Text);
                textBox1.Text = null;

            }
        }

        private void textBox1_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar))
            {
                MessageBox.Show("Solo se permiten letras", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
        }

        private void listBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Back)
            {
                listBox3.Items.RemoveAt(listBox3.SelectedIndex);
            }
        }

    }
}
