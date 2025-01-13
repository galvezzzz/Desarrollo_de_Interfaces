namespace FormularioWindows
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El formulario ha sido enviado con éxito");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Has cancelado el formulario");
        }
    }
}
