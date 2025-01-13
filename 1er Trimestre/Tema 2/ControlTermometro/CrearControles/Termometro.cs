using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlTermometro
{
    public partial class Termometro: UserControl
    {
        public Termometro()
        {
            InitializeComponent();
        }

        private void trackBar2_Scroll(object sender, EventArgs e)
        {
            switch (trackBar2.Value) { 
            
                case 0:
                    pictureBox1.ImageLocation = "C:\\Users\\Alberto\\Desktop\\2DAM\\Interfaces\\Tema 2\\ControlTermometro\\Imagenes\\Frio.jpg";
                    break;

                case 1:
                    pictureBox1.ImageLocation = "C:\\Users\\Alberto\\Desktop\\2DAM\\Interfaces\\Tema 2\\ControlTermometro\\Imagenes\\normal.jpg";
                    break;

                case 2:
                    pictureBox1.ImageLocation = "C:\\Users\\Alberto\\Desktop\\2DAM\\Interfaces\\Tema 2\\ControlTermometro\\Imagenes\\sudar.png";
                    break;
            }
        }
    }
}
