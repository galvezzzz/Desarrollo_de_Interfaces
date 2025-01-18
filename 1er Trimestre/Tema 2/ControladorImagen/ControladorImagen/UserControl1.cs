using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControladorImagen
{
    public partial class ImagenLeyenda: UserControl
    {
        bool Dragging;
        int xPos;
        int yPos;

        public ImagenLeyenda()
        {
            InitializeComponent();
        }

        private void selectIm_Click(object sender, EventArgs e)
        {
            OpenFileDialog opf = new OpenFileDialog();
            if (opf.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = Image.FromFile(opf.FileName);
                pictureBox1.Cursor = Cursors.Hand;
            }
        }

        [Category("Control personalizado")]
        [Description("Este control permite cambiar el texto de la leyenda")]
        public string CambiarLeyenda 
        {
            get { return leyenda.Text; }

            set { leyenda.Text = value; } 
        }

        [Category("Control personalizado")]
        [Description("Este control permite cambiar el tamaño del texto de la leyenda")]
        public float CambiarTamanyoLetra 
        {
            get { return leyenda.Font.Size; }

            set 
            { 
                leyenda.Font = new Font("Sans", value, FontStyle.Regular);
            }
        }

        
        [Category("Control personalizado")]
        [Description("Este control permite cambiar la imagen del control")]
        public Image Imagenes
        {
            get
            {
                return pictureBox1.Image;
            }
            set
            {
                pictureBox1.Image = value;
            }
        }

        private void pictureBox1_MouseUp_1(object sender, MouseEventArgs e)
        {
            Dragging = false;
        }

        private void pictureBox1_MouseDown_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Dragging = true;
                xPos = e.X;
                yPos = e.Y;
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            {
                Control c = sender as Control;
                if (Dragging && c != null)
                {
                    c.Top = e.Y + c.Top - yPos;
                    c.Left = e.X + c.Left - xPos;
                }
            }
        }
    }
}
