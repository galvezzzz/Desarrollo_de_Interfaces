using CuartaPrueba.Properties;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace CuartaPrueba
{
    public partial class Form1 : Form
    {

        private List<extra> extra1;
        private List<extra> extra2;
        private List<extra> extra3;
        private List<extra> extra4;
        private List<extra> extra5;
        int precioCoche;
        int precioExtras;
        double precioFinanciacion;
        double precioSinIva;
        double precioIva;
        double precioTotal;

        public Form1()
        {
            InitializeComponent();
        }

        //Cargamos los datos iniciales del programa
        private void cargarDatos()
        {
            extra1 = new List<extra>() { new extra("Audio BOSE", 500), new extra("Aire bizona", 1200), new extra("Camara trasera", 1000), new extra("Sensores", 500)};
            extra2 = new List<extra>(extra1) { new extra("Asientos de cuero", 600), new extra("Control de velocidad", 200), new extra("Sensor cambio carril", 800) };
            extra3 = new List<extra>(extra2) { new extra("GPS", 300), new extra("Llantas 18", 200), new extra("Asistente aparcamiento", 600), new extra("Automatico", 1000) };
            extra4 = new List<extra>(extra3) { new extra("Android auto", 200), new extra("CR7 de asistente", 10000), new extra("Asistente calefactores", 250) };
            extra5 = new List<extra>(extra4) { new extra("Descapotable", 5000) };

            dateTimePicker1.MinDate = DateTime.Now;

            desactivarTodo();
        }

        //Metodo que pone en oculto todo menos la foto de kia y el elegir el modelo. Es llamado en cargarDatos
        private void desactivarTodo()
        {
            pictureBox2.Visible = false;
            
            listBox1.Visible = false;
            button1.Visible = false;
            button2.Visible = false;
            dataGridView1.Visible = false;

            label2.Visible = false;
            numericUpDown1.Visible = false;
            
            label3.Visible = false;
            dateTimePicker1.Visible = false;
            
            numericUpDown2.Visible = false;
            numericUpDown3.Visible = false;

            label4.Visible = false;
            textBox1.Visible = false;
            listBox3.Visible = false;

            groupBox1.Visible = false;

            label6.Visible = false;
            label7.Visible = false;
            label14.Visible = false;
            label12.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
        }

        //Metodo que activa todo lo oculto es llamado al cambiar el coche
        private void activarTodo()
        {
            pictureBox2.Visible = true;

            listBox1.Visible = true;
            button1.Visible = true;
            button2.Visible = true;
            dataGridView1.Visible = true;

            label2.Visible = true;
            numericUpDown1.Visible = true;

            label3.Visible = true;
            dateTimePicker1.Visible = true;

            numericUpDown2.Visible = true;
            numericUpDown3.Visible = true;

            label4.Visible = true;
            textBox1.Visible = true;
            listBox3.Visible = true;

            groupBox1.Visible = true;

            label6.Visible = true;
            label7.Visible = true;
            label14.Visible = true;
            label12.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
        }

        //Cosas que se ejecuta al abrir el programa
        private void Form1_Load(object sender, EventArgs e)
        {
            cargarDatos();
        }

        //Resetear cosas cuando cambiamos de coche
        private void resetearCosas()
        {
            listBox3.Items.Clear();

            numericUpDown1.Value = 3;
            dateTimePicker1.ResetText();

            checkBox1.Checked = false;
            numericUpDown2.Minimum = 0;
            numericUpDown2.Value = 0;

            numericUpDown3.Value = 0;
            label13.Text = "";

            label5.Text = "";
            textBox1.Text = "";
        }

        //Al cambiar de coche se cargan los extras de ese coche exacto
        private void addInBoxList1(List<extra> extras)
        {
            listBox1.Items.Clear();
            dataGridView1.Rows.Clear();

            foreach (extra item in extras)
            {
                listBox1.Items.Add(item.ToString());
            }
        }

        //Evitamos que escriban en la lista donde se elige el coche
        private void comboBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        //Al seleccionar el coche resetea todos los precios a 0 y sus label también
        private void ponerPrecioCoche(int precio)
        {
            precioCoche = precio;
            label6.Text = "Precio coche: " + precioCoche + "€";
            precioExtras = 0;
            label7.Text = "Precio extras: " + precioExtras + "€";
            precioSinIva = 0;
            label12.Text = "Precio sin IVA: " + precioSinIva;
            precioIva = (precioCoche + precioExtras) * 0.21;
            label8.Text = "IVA: " + precioIva + "€";
            precioFinanciacion = 0;
            label14.Text = "Financiación: " + precioFinanciacion + "€";
            precioTotal = precioCoche + precioExtras + precioIva;
            label9.Text = "Precio total: " + (precioTotal);
        }

        //Actualizar el precio del IVA llamando a actualizarPrecioTotal
        private void actualizarPrecioIva()
        {
            precioSinIva = (precioCoche + precioExtras + precioFinanciacion);
            label12.Text = "Precio sin IVA: " + precioSinIva + "€";
            precioIva = precioSinIva * 0.21;
            label8.Text = "IVA: " + precioIva + "€";
            actualizarPrecioTotal();
        }

        //Actualizamos el Precio Total 
        private void actualizarPrecioTotal()
        {
            precioTotal = precioCoche + precioExtras + precioFinanciacion + precioIva;
            label9.Text = "Precio total: " + precioTotal + "€";
        }

        //Lo uso para cuando queremos buscar el precio de un elemento del enum de KIA
        private int EnumPrecio(String cadena)
        {
            int precio = 0;

            switch (cadena)
            {
                case nameof(Kia.Ceed):
                    precio = 10000;
                    break;
                case nameof(Kia.Niro):
                    precio = 20000;
                    break;
                case nameof(Kia.Picanto):
                    precio = 30000;
                    break;
                case nameof(Kia.Sorento):
                    precio = 40000;
                    break;
                case nameof(Kia.Sportage):
                    precio = 50000;
                    break;
                default:
                    break;
            }


            return precio;
        }

        //Detecta cuando se cambia el coche seleccionado y ejecuta funciones
        private void comboBox1_TextChanged(object sender, EventArgs e)
        {
            listBox1.Items.Add(comboBox1.Text);

            activarTodo();

            switch (comboBox1.Text)
            {
                case nameof(Kia.Ceed):
                    pictureBox2.Image = Resources.Ceed;
                    addInBoxList1(extra5);
                    resetearCosas();
                    ponerPrecioCoche(EnumPrecio(nameof(Kia.Ceed)));
                    break;
                case nameof(Kia.Niro):
                    pictureBox2.Image = Resources.Niro;
                    addInBoxList1(extra3);
                    resetearCosas();
                    ponerPrecioCoche(EnumPrecio(nameof(Kia.Niro)));
                    break;
                case nameof(Kia.Picanto):
                    pictureBox2.Image = Resources.Picanto;
                    addInBoxList1(extra2);
                    resetearCosas();
                    ponerPrecioCoche(EnumPrecio(nameof(Kia.Picanto)));
                    break;
                case nameof(Kia.Sorento):
                    pictureBox2.Image = Resources.Sorento;
                    addInBoxList1(extra4);
                    resetearCosas();
                    ponerPrecioCoche(EnumPrecio(nameof(Kia.Sorento)));
                    break;
                case nameof(Kia.Sportage):
                    pictureBox2.Image = Resources.Sportage;
                    addInBoxList1(extra1);
                    resetearCosas();
                    ponerPrecioCoche(EnumPrecio(nameof(Kia.Sportage)));
                    break;
                default:
                    break;
            }
        }

        //Añade dinero a extras y actualiza los otros precios llamando a sus funciones
        private void anyadirDineroExtras(int precio)
        {

            precioExtras += precio;
            label7.Text = "Precio extras: " + precioExtras + "€";
            calcularFinanciacion();
        }

        //Mueve los elementos del ListBox a el DataGrid
        private void moverListboxDataGrid()
        {
            List<string> extras = new List<string>();

            foreach (int i in listBox1.SelectedIndices)
            {
                string item = listBox1.Items[i].ToString();
                extras.Add(item);

                string[] partes = item.Split(new[] { ' ' });
                string precio = partes[partes.Length - 1];
                string nombre = string.Join(" ", partes, 0, partes.Length - 1);

                dataGridView1.Rows.Add(nombre, precio);

                anyadirDineroExtras(Int32.Parse(precio.Substring(0, (precio.Length - 1))));
            }
            foreach(string  item in extras) listBox1.Items.Remove(item);
        }

        //Se ejecuta cuando se clicka en el boten de añadir y ejecuta moverListboxDataGrid
        private void botonAnyadir_Click(object sender, EventArgs e)
        {
            moverListboxDataGrid();
        }

        //Quita dinero a extras y actualiza los otros precios llamando a sus funciones
        private void quitarDineroExtras(int precio)
        {
            precioExtras -= precio;
            label7.Text = "Precio extras: " + precioExtras + "€";
            calcularFinanciacion();
        }

        //Mueve los elementos del DataGrid a el ListBox
        private void moverDataGridListBox()
        {

            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                string extra = row.Cells["Extra"].Value.ToString();
                string precio = row.Cells["Precio"].Value.ToString();
                listBox1.Items.Add(extra + ": " + precio);
                dataGridView1.Rows.Remove(row);
                quitarDineroExtras(Int32.Parse(precio.Substring(0, (precio.Length - 1))));
            }
        }

        //Se ejecuta cuando se clicka en el boron de eliminar extra y ejecuta moverDataGridListBox
        private void botonQuitar_Click(object sender, EventArgs e)
        {
            moverDataGridListBox();
        }

        //Mueve el descuento desde el TextBox a la ListBox donde se almacenan controlando que sea correcto el formato
        private void moveToBoxList3()
        {
            if (listBox3.Items.Count == 3)
            {
                label5.Text = "Ya hay 3 descuentos";
            }
            else
            {
                if (textBox1.Text.Length != 5)
                {
                    label5.Text = "Tiene que tener 5 letras";
                }
                else
                {
                    listBox3.Items.Add(textBox1.Text);
                    label5.Text = "";

                }
            }
            textBox1.Clear();
        }

        //Se ejecuta cada vez que le damos a una letra en el textBox donde añadimos el descuento, controla que solo se puedan añadir letras, borrar o darle a el enter
        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

            if (e.KeyChar == (char)Keys.Enter)
            {
                moveToBoxList3();
            }
            else if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        //Se ejecuta cada vez que le damos a una letra en el ListBox de los descuentos, controla que le demos al supr para borrarlos
        private void listBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                listBox3.Items.Remove(listBox3.SelectedItem);
            }
        }

        //Activa el groupBox y pone minimos y maximos a las cosas de dentro
        private void activarGroupBox1()
        {
            groupBox1.Enabled = true;
            numericUpDown2.Minimum = 12;
            numericUpDown2.Value = 12;
            numericUpDown3.Minimum = 0;
            numericUpDown3.Maximum = precioCoche;
        }

        //Desactiva el groupBox y restablece todo a 0
        private void desactivarGroupBox1()
        {
            groupBox1.Enabled = false;
            numericUpDown2.Minimum = 0;
            numericUpDown2.Value = 0;
            numericUpDown3.Value = 0;
        }

        //Detecta el checkBox del apartado financiar y dependiendo si se activa o desactiva llama a activarGroupBox1 o desactivarGroupBox1
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                activarGroupBox1();
            } else if (!checkBox1.Checked) { 
                desactivarGroupBox1();
            }
        }

        //Calcula el porcentaje extra por financiar el vehiculo y actualiza los precios llamando a sus funciones
        private void calcularFinanciacion()
        {
            double porcentajeExtra = (int) numericUpDown2.Value * 1;
            precioFinanciacion = (precioCoche + precioExtras - (double) numericUpDown3.Value) * (porcentajeExtra/100);
            label14.Text = "Financiación: " + precioFinanciacion + "€";
            actualizarPrecioIva();
        }

        //Detecta el cambio en los meses que se pagará el coche y llama a calcularFinanciacion
        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {
            calcularFinanciacion();
        }

        //Detecta el cambio de la cueta inicial y llama a calcularFinanciacion
        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {
            calcularFinanciacion();
        }

        //Actualiza el precio base del coche dependiendo del numero de puertas
        private void actualizarPrecioCoche(int puertas)
        {
            if(puertas == 3)
            {
                precioCoche -= 5000;
            } else
            {
                precioCoche += 5000;
            }
            label6.Text = "Precio coche: " + precioCoche + "€";
            actualizarPrecioIva();
        }

        //Detecta el cambio del número de puertas y llama a actualizarPrecio coche
        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            actualizarPrecioCoche((int)numericUpDown1.Value);
        }
    }
}