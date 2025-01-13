
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace FormPizzas
{
    public partial class Form1 : Form
    {
        List<int> listaPrecios = new List<int>();

        public Form1()
        {
            InitializeComponent();
        }

        public void clearAll()
        {
            tbDireccion.Clear();
            tbNombre.Clear();
            tbTelefono.Clear();
            tbHora.Clear();
            tbFecha.Clear();
            cbDomicilio.Checked = false;
            dataGridView1.ClearSelection();
            listBox1.Items.Clear();
            comboBebida.Text = string.Empty;
            comboPostre.Text = string.Empty;
            comboTamanyo.Text = string.Empty;
            labelError.Visible = false;

        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count == 0)
            {
                int posicionFilas = dataGridView1.Rows.Add();
                dataGridView1.Rows[posicionFilas].Cells[0].Value = tbNombre.Text;
                dataGridView1.Rows[posicionFilas].Cells[1].Value = tbDireccion.Text;
                dataGridView1.Rows[posicionFilas].Cells[2].Value = tbTelefono.Text;
                dataGridView1.Rows[posicionFilas].Cells[3].Value = tbFecha.Text;
                dataGridView1.Rows[posicionFilas].Cells[4].Value = tbHora.Text;
                dataGridView1.Rows[posicionFilas].Cells[5].Value = cbDomicilio.Checked ? "Sí" : "No";

                clearAll();
            }
            else
            {
                int posicionFilas = dataGridView1.CurrentCell.RowIndex;
                dataGridView1.Rows[posicionFilas].Cells[0].Value = tbNombre.Text;
                dataGridView1.Rows[posicionFilas].Cells[1].Value = tbDireccion.Text;
                dataGridView1.Rows[posicionFilas].Cells[2].Value = tbTelefono.Text;
                dataGridView1.Rows[posicionFilas].Cells[3].Value = tbFecha.Text;
                dataGridView1.Rows[posicionFilas].Cells[4].Value = tbHora.Text;
                dataGridView1.Rows[posicionFilas].Cells[5].Value = cbDomicilio.Checked ? "Sí" : "No";

                clearAll();
            }

        }

        private void btnAnyadir_Click(object sender, EventArgs e)
        {
            if (listBox1.Items.Count > 9)
            {
                labelError.Visible = true;
            }
            else
            {
                listBox1.Items.Add(tbIngrediente.Text);
            }

            tbIngrediente.Clear();
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

        private void tbFecha_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumeros(e);
        }

        private void tbTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumeros(e);
        }

        private void tbHora_KeyPress(object sender, KeyPressEventArgs e)
        {
            soloNumeros(e);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedData = dataGridView1.CurrentRow.Index;

            tbNombre.Text = (string)dataGridView1.Rows[selectedData].Cells[0].Value;
            tbDireccion.Text = (string)dataGridView1.Rows[selectedData].Cells[1].Value;
            tbTelefono.Text = (string)dataGridView1.Rows[selectedData].Cells[2].Value;
            tbFecha.Text = (string)dataGridView1.Rows[selectedData].Cells[3].Value;
            tbHora.Text = (string)dataGridView1.Rows[selectedData].Cells[4].Value;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            clearAll();

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].Cells[0].Value = "";
                dataGridView1.Rows[i].Cells[1].Value = "";
                dataGridView1.Rows[i].Cells[2].Value = "";
                dataGridView1.Rows[i].Cells[3].Value = "";
                dataGridView1.Rows[i].Cells[4].Value = "";
                dataGridView1.Rows[i].Cells[5].Value = "";
            }
            
        }
    }
}

