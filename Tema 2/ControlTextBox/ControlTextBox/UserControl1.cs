using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Drawing.Design;
using ComboBox = System.Windows.Forms.ComboBox;

namespace ControlTextBox
{
    public partial class TextBoxPersonalizado : UserControl
    {
        public enum Position
        {
            Izquierda,
            Arriba
        }

        
        public TextBoxPersonalizado()
        {
            InitializeComponent();
        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {
            lblCantidad.Text = Convert.ToString(textBox.Text.Length) + "/50";
        }


        [Category("Control personalizado")]
        [Description("Este control permite cambiar el texto del label")]
        public string textoLabel
        {
            get { return lblText.Text; }
            set { lblText.Text = value; }
        }

        // Propiedad cambiar label de lugar
        [Browsable(true), DefaultValue("All"), Description("Direction panel collapses. 0-none, 1-up, 2-right, 3-down, 4-left, 5-all")]
        [ListBindable(true), Editor(typeof(ComboBox), typeof(UITypeEditor))]

        // Posición por defecto del label
        Position pos = Position.Izquierda;

        [Category("Control personalizado")]
        [Description("Este control permite cambiar la posición del label")]
        public Position cambiarPosicion
        {
            get { return pos; }  

            set 
            {
                pos = value;
                ChangePosition();      
            }
        }

        public void ChangePosition()
        {
            TextBoxPersonalizado tb = new TextBoxPersonalizado();

            switch (pos)
            {
                case Position.Izquierda:
                    lblText.Location = new Point(8, 28);
                    textBox.Location = new Point(43, 25);
                    lblCantidad.Location = new Point(87, 9);
                    this.Width = 127;
                    break;

                case Position.Arriba:
                    lblText.Location = new Point(8, 9);
                    textBox.Location = new Point(11, 25);
                    lblCantidad.Location = new Point(55, 9);
                    this.Width = 94;
                    break;
            }
        }
    }
}
