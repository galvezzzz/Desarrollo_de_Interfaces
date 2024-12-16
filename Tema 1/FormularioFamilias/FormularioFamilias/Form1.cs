using System.Runtime.CompilerServices;
using static System.Net.Mime.MediaTypeNames;

namespace FormularioFamilias
{
    public partial class Form1 : Form
    {
        List<string> listaHijos;
        int aumentoProgress;

        public Form1()
        {
            InitializeComponent();
            listaHijos = new List<string>();
        }

        private void trackBar1_ValueChanged(object sender, EventArgs e)
        {
            label1.Text = trackBar1.Value.ToString();
            progressBar1.Maximum = trackBar1.Value;


        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                button1.Enabled = true;
                textBox5.Enabled = true;
                trackBar1.Enabled = true;
                label1.Enabled = true;
            }
            else
            {
                button1.Enabled = false;
                textBox5.Enabled = false;
                trackBar1.Enabled = false;
                label1.Enabled = false;
            }
        }

        // Modificar y añadir datagridview
        private void Aceptar_Click_1(object sender, EventArgs e)
        {
            int posicionFilas;

            if (dataGridView1.SelectedRows.Count == 0)
            {
                posicionFilas = dataGridView1.Rows.Add();
                dataGridView1.Rows[posicionFilas].Cells[0].Value = textBox1.Text;
                dataGridView1.Rows[posicionFilas].Cells[1].Value = textBox2.Text;
                dataGridView1.Rows[posicionFilas].Cells[2].Value = textBox3.Text;
                dataGridView1.Rows[posicionFilas].Cells[3].Value = textBox4.Text;

                //DataGridViewRow row = new DataGridViewRow();
                //dataGridView1.Rows.Add(row);

                if (checkBox1.Checked)
                {
                    dataGridView1.Rows[posicionFilas].Cells[4].Value = trackBar1.Value;
                }
                else
                {
                    dataGridView1.Rows[posicionFilas].Cells[4].Value = 0;
                }

                if (checkBox1.Checked)
                {
                    // Crea padre 
                    treeView1.Nodes.Add(textBox1.Text);

                    for (int i = 0; i < trackBar1.Value; i++)
                    {
                        treeView1.Nodes[0].Nodes.Add(listaHijos[i]);
                    }
                }

                resetValues();
            }
            else
            {
                posicionFilas = dataGridView1.CurrentCell.RowIndex;
                dataGridView1.Rows[posicionFilas].Cells[0].Value = textBox1.Text;
                dataGridView1.Rows[posicionFilas].Cells[1].Value = textBox2.Text;
                dataGridView1.Rows[posicionFilas].Cells[2].Value = textBox3.Text;
                dataGridView1.Rows[posicionFilas].Cells[3].Value = textBox4.Text;

                if (checkBox1.Checked)
                {
                    dataGridView1.Rows[posicionFilas].Cells[4].Value = trackBar1.Value;
                }
                else
                {
                    dataGridView1.Rows[posicionFilas].Cells[4].Value = 0;
                }

                resetValues();
            }
        }

        // Botón añadir hijos
        private void button1_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrWhiteSpace(textBox5.Text)) // Verifica que no esté vacío
            {
                listaHijos.Add(textBox5.Text); // Añade el nombre a la lista
                textBox5.Text = ""; // Reestablece el TextBox
                labelHijo.Visible = true;
            }

            progressBar1.Value += 1;
        }

        public void clearTextBoxes()
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
        }

        public void resetValues()
        {
            // Reinicia el progressBar
            progressBar1.Value = 0;

            // Reinicia el checkbox
            checkBox1.Checked = false;

            // Reinicia el progressBar
            labelHijo.Visible = false;

            // Reinicia los textBox
            clearTextBoxes();

            // Reinicia la selección de filas
            dataGridView1.ClearSelection();
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                textBox2.Focus();
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                textBox3.Focus();
            }
        }

        private void soloNumeros(KeyPressEventArgs e)
        {
            // Textbox numérico

            if (Char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
            else if (Char.IsSeparator(e.KeyChar))
            {
                e.Handled = true;
                MessageBox.Show("Solo se permiten números", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                e.Handled = true;
                return;
            }
            else
            {
                e.Handled = false;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                textBox4.Focus();
            }

            soloNumeros(e);
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int selectedData = dataGridView1.CurrentRow.Index;

            textBox1.Text = (string)dataGridView1.Rows[selectedData].Cells[0].Value;
            textBox2.Text = (string)dataGridView1.Rows[selectedData].Cells[1].Value;
            textBox3.Text = (string)dataGridView1.Rows[selectedData].Cells[2].Value;
            textBox4.Text = (string)dataGridView1.Rows[selectedData].Cells[3].Value;
        }
    }
}
