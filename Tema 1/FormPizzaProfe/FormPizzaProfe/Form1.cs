using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormPizzaProfe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                listBox1.Items.Add(textBox1.Text);
            }
        }

        private void listBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                listBox1.SelectedItems.Remove(listBox1.SelectedItem);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string pizza = "", ingredientes = "";
            double precio = 0;

            switch (comboBox1.SelectedIndex) { 
                case 0:
                    pizza = "Pequeña";
                    precio = 8.00;
                    break;
                case 1:
                    pizza = "Mediana";
                    precio = 10.00;
                    break;
                case 2:
                    pizza = "Grande";
                    precio = 12.00;
                    break;
            }

            foreach (string ingrediente in listBox1.Items)
            {
                ingredientes += " " + ingrediente;
                precio++;
            }
            dataGridView1.Rows.Add(pizza, ingredientes, precio);
            recalcular();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            String bebida = "";
            double precio = 0;

            switch(comboBox2.SelectedIndex) {
                case 0:
                    bebida = "CocaCola";
                    precio = 2.00;
                    break;
                case 1:
                    bebida = "Fanta";
                    precio = 2.00;
                    break;
                case 2:
                    bebida = "Agua";
                    precio = 2.00;
                    break;
            }
            dataGridView1.Rows.Add(bebida, "", precio);
            recalcular();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            String postre = "";
            double precio = 0;

            switch (comboBox2.SelectedIndex)
            {
                case 0:
                    postre = "Tarta de queso";
                    precio = 2.30;
                    break;
                case 1:
                    postre = "Tarta de manzana";
                    precio = 2.50;
                    break;
                case 2:
                    postre = "Arroz con leche";
                    precio = 3.00;
                    break;
            }
            dataGridView1.Rows.Add(postre, "", precio);
            recalcular();
        }

        private void recalcular()
        {
            double precio = 0;
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                precio += Convert.ToDouble(row.Cells[2].Value);
            }

            label6.Text = precio.ToString() + "€";
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete) {
                dataGridView1.Rows.RemoveAt(dataGridView1.CurrentRow.Index);
            }
        }
    }
}
