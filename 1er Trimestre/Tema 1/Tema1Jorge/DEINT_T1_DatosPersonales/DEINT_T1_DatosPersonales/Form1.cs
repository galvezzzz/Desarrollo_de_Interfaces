using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace DEINT_T1_DatosPersonales
{
    public partial class Form1 : Form
    {

        List<Persona> personas = new List<Persona>();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        { 
        }

        //Se activa al seleccionar el datagridview y comprobamos si se selecciono una fila
        private void dataGridView_datos_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView_datos.SelectedRows.Count == 1)
            {
                cargardatos();
            } else
            {
                resetearTodo();
            }
        }

        //Cuando se selecciona una fila del datagridview muestra los datos en los textbox
        private void cargardatos()
        {
            resetearTodo();

            textBox_nombre.Text = dataGridView_datos.Rows[dataGridView_datos.SelectedRows[0].Index].Cells[0].Value.ToString();
            textBox_apellido.Text = dataGridView_datos.Rows[dataGridView_datos.SelectedRows[0].Index].Cells[1].Value.ToString();
            textBox_direccion.Text = dataGridView_datos.Rows[dataGridView_datos.SelectedRows[0].Index].Cells[2].Value.ToString();
            textBox_telefono.Text = dataGridView_datos.Rows[dataGridView_datos.SelectedRows[0].Index].Cells[3].Value.ToString();

            if (Int32.Parse(dataGridView_datos.Rows[dataGridView_datos.SelectedRows[0].Index].Cells[4].Value.ToString()) > 0)
            {
                checkBox_hijos.Checked = true;
                trackBar_hijos.Value = Int32.Parse(dataGridView_datos.Rows[dataGridView_datos.SelectedRows[0].Index].Cells[4].Value.ToString());

                string[] hijos = dataGridView_datos.Rows[dataGridView_datos.SelectedRows[0].Index].Cells[5].Value.ToString().Split(';');


                for (int i = 1; i < hijos.Length; i++)
                {
                    treeView_hijos.Nodes[0].Nodes.Add(hijos[i]);
                }
                treeView_hijos.ExpandAll();
                calcularProgressBar();
            }



        }

        //Comprueba que solo se pueda meter letras en el nombre
        private void textBox_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        //Comprueba que solo se pueda meter letras en el nombre
        private void textBox_apellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        //Resetea todo al añadir los datos de una persona o actua
        private void resetearTodo()
        {
            textBox_nombre.Clear();
            textBox_apellido.Clear();
            textBox_direccion.Clear();
            textBox_telefono.Clear();
            label_errores.Text = "";
            labelrelleno.Text = "";
            checkBox_hijos.Checked = false;
            modoInsertarHijos();
        }

        //Controlar que en el teléfono solo se puedan meter números y solo 9
        private void textBox_telefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
            else if (textBox_telefono.Text.Length == 9 && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        //Se presiona el checkBox que activa hijos
        private void checkBox_hijos_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_hijos.Checked)
            {

                if (textBox_nombre.Text.Equals(""))
                {
                    labelrelleno.Text = "El campo nombre no puede estar vacio";
                    checkBox_hijos.Checked = false;
                } else
                {
                    groupBox_hijos.Enabled = true;
                    treeView_hijos.Nodes.Add(new TreeNode(textBox_nombre.Text));
                }
            }
            else if (!checkBox_hijos.Checked)
            {
                groupBox_hijos.Enabled = false;
                trackBar_hijos.Value = 1;
                label_errores.Text = "";
                textBox_hijo.Clear();
                treeView_hijos.Nodes.Clear();
                progressBar_hijos.Value = 0;
            }
        }

        //Comprueba que el formulario este correcto
        private Boolean formularioCorrecto()
        {
            Boolean correcto = true;

            if (textBox_nombre.Text.Equals(""))
            {
                labelrelleno.Text = "El campo nombre no puede estar vacio";
                correcto = false;
            }
            else if (textBox_apellido.Text.Equals(""))
            {
                labelrelleno.Text = "El campo apellido no puede estar vacio";
                correcto = false;
            }
            else if (textBox_direccion.Text.Equals(""))
            {
                labelrelleno.Text = "El campo dirección no puede estar vacio";
                correcto = false;
            }
            else if (textBox_telefono.Text.Length != 9)
            {
                labelrelleno.Text = "El número de telefono tiene que ser de 9 dígitos";
                correcto = false;
            }

            return correcto;
        }

        //Boton aceptar, este diferencia entre modificar y añadir
        private void button_aceptar_Click(object sender, EventArgs e)
        {

            if (formularioCorrecto())
            {
                labelrelleno.Text = "";

                Persona persona = new Persona(textBox_nombre.Text, textBox_apellido.Text, textBox_direccion.Text, Int32.Parse(textBox_telefono.Text), (checkBox_hijos.Checked) ? trackBar_hijos.Value : 0);

                String csvHijos = getCSVHijos();


                if (checkBox_hijos.Checked && trackBar_hijos.Value != csvHijos.Split(';').Length - 1)
                {
                    label_errores.Text = "Añadiste menos hijos de los que tienes";
                } else
                {

                    if (dataGridView_datos.SelectedRows.Count == 1)
                    {
                        dataGridView_datos.Rows[dataGridView_datos.SelectedRows[0].Index].SetValues(persona.nombre, persona.apellidos, persona.direccion, persona.telefono, persona.numeroHijos, csvHijos);
                        resetearTodo();
                        dataGridView_datos.ClearSelection();
                    } else
                    {
                        dataGridView_datos.Rows.Add(persona.nombre, persona.apellidos, persona.direccion, persona.telefono, persona.numeroHijos, csvHijos);
                        resetearTodo();
                        dataGridView_datos.ClearSelection();
                    }

                }

            }
        }

        //Recorre el treeview de los hijos y los añade en un string
        private String getCSVHijos()
        {
            String csvHijos = "";

            if (checkBox_hijos.Checked)
            {
                foreach (TreeNode oSubNode in treeView_hijos.Nodes[0].Nodes)
                {
                    csvHijos += ";" + oSubNode.Text;
                }

            }

            return csvHijos;
        }

        //Añade un hijo 
        private void addTreeView()
        {

            if (treeView_hijos.SelectedNode != null) 
            {
                if (treeView_hijos.SelectedNode != treeView_hijos.Nodes[0])
                {
                    treeView_hijos.Nodes[0].Nodes[treeView_hijos.SelectedNode.Index].Text = textBox_hijo.Text;
                    modoInsertarHijos();
                }
                
            }
            else
            {
                treeView_hijos.Nodes[0].Nodes.Add(textBox_hijo.Text);
                treeView_hijos.ExpandAll();
            }

        }

        //Se ejecuta cuandio se selecciona un hijo activa un boton parar de modificar y cambia el texto de introducir hijo a modificar hijo
        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (treeView_hijos.SelectedNode != treeView_hijos.Nodes[0])
            {
                modoModificarHijos();
            } else
            {
                treeView_hijos.SelectedNode = null;
            }
        }

        //Comprueba que no se pueda meter nada más que letras, que no pueda tener mas hijos de los que tiene y al darle enter añada un hijo
        private void textBox_hijo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                if(treeView_hijos.SelectedNode != null && treeView_hijos.SelectedNode != treeView_hijos.Nodes[0])
                {
                    addTreeView();
                }
                else if (treeView_hijos.Nodes[0].Nodes.Count == trackBar_hijos.Value)
                {
                    label_errores.Text = "No puedes añadir más hijos de los que tienes.";
                    textBox_hijo.Text = "";
                }
                else
                {
                    labelrelleno.Text = "";
                    addTreeView();
                    textBox_hijo.Text = "";
                    calcularProgressBar();
                }
            } else if (!char.IsLetter(e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }

        }

        private void calcularProgressBar()
        {
            progressBar_hijos.Maximum = trackBar_hijos.Value;

            progressBar_hijos.Value = treeView_hijos.Nodes[0].Nodes.Count;
        }

        //Si se cambia el nombre se reinicia el tree de los hijos y se crea uno con el nuevo padre
        private void textBox_nombre_TextChanged(object sender, EventArgs e)
        {
            if(checkBox_hijos.Checked)
            {
                treeView_hijos.Nodes.Clear();
                treeView_hijos.Nodes.Add(new TreeNode(textBox_nombre.Text));
            }
        }

        //Comprueba si se le dio a la tecla suprimir para borrar un hijo
        private void treeView_hijos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Delete)
            {
                if (treeView_hijos.SelectedNode != treeView_hijos.Nodes[0] && treeView_hijos.SelectedNode != null)
                treeView_hijos.SelectedNode.Remove();
                label_errores.Text = "";
                modoInsertarHijos();
                calcularProgressBar();

            }
        }

        //Controla el boton suprimir
        private void dataGridView_datos_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Delete)
            {
                dataGridView_datos.Rows.RemoveAt(dataGridView_datos.SelectedRows[0].Index);
                resetearTodo();
            }
        }

        //Dejar de seleccionar hijo
        private void button_modificar_Click(object sender, EventArgs e)
        {
            modoInsertarHijos();
        }

        //Se activa al mover el scroll del hijos para que no podamos ponerle menos valor que el número de hijos añadidos
        private void trackBar_hijos_Scroll(object sender, EventArgs e)
        {
            String csvHijos = "";

            foreach (TreeNode oSubNode in treeView_hijos.Nodes[0].Nodes)
            {
                    csvHijos += ";" + oSubNode.Text;
            }
            if (trackBar_hijos.Value < csvHijos.Split(';').Length - 1)
            {
                trackBar_hijos.Value = (csvHijos.Split(';').Length - 1);
            }

            calcularProgressBar();

        }

        //Desactiva el boton_modificar y cambia el labelInstroduce
        private void modoInsertarHijos()
        {
            treeView_hijos.SelectedNode = null;
            textBox_hijo.Text = "";
            button_modificar.Visible = false;
            label_introduce.Text = "Introduce el nombre del hijo:";
        }

        //Desactiva el boton_modificar y cambia el labelInstroduce
        private void modoModificarHijos()
        {
            label_introduce.Text = "Modifica el nombre del hijo:";
            textBox_hijo.Text = treeView_hijos.SelectedNode.Text.ToString();
            button_modificar.Visible = true;
        }

        private void button_buscar_Click(object sender, EventArgs e)
        {
            dataGridView_buscar.Rows.Clear();
            if (textBox_buscar.Text == "")
            {
                label_errorBuscar.Text = "No especificaste que buscar";
            } else
            {
                label_errorBuscar.Text = "";
                foreach (DataGridViewRow item in dataGridView_datos.Rows)
                {

                    foreach(DataGridViewCell celda in item.Cells)
                    {
                        if(celda.Value.Equals(textBox_buscar.Text))
                        {
                            dataGridView_buscar.Rows.Add(item.Cells[0].Value, item.Cells[1].Value, item.Cells[2].Value, item.Cells[3].Value, item.Cells[4].Value, item.Cells[5].Value);
                        }
                    }
                }
            }
        }

    }
}