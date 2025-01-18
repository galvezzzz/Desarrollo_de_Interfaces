using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Security.Cryptography;

namespace ControlExamen
{
    public partial class Marcador : UserControl
    {
        public Marcador()
        {
            InitializeComponent();
        }

        [Category("Control personalizado")]
        [Description("Este control permite cambiar el nombre del equipo local")]
        public string nombreLocal 
        {
            set { localLbl.Text = value; }
            get { return localLbl.Text; ; }
        }

        [Category("Control personalizado")]
        [Description("Este control permite cambiar el nombre del equipo visitante")]
        public string nombreVisitante
        {
            set { visitanteLbl.Text = value; }
            get { return visitanteLbl.Text; ; }
        }

        [Category("Control personalizado")]
        [Description("Este control permite cambiar el marcador del equipo local")]
        public string marcadorLocal
        {
            set { mLocalLbl.Text = value; }
            get { return mLocalLbl.Text; ; }
        }

        [Category("Control personalizado")]
        [Description("Este control permite cambiar el marcador del equipo visitante")]
        public string marcadorVisitante
        {
            set { mVisitanteLbl.Text = value; }
            get { return mVisitanteLbl.Text; ; }
        }

        [Category("Control personalizado")]
        [Description("Este control permite cambiar la imagen del escudo local")]
        public Image escudoLocal
        {
            get
            {
                return escudoLocalImg.Image;
            }
            set
            {
                escudoLocalImg.Image = value;
            }
        }

        [Category("Control personalizado")]
        [Description("Este control permite cambiar la imagen del escudo visitante")]
        public Image escudoVisitante
        {
            get
            {
                return escudoVisitanteImg.Image;
            }
            set
            {
                escudoVisitanteImg.Image = value;
            }
        }

        [Category("Control personalizado")]
        [Description("Este control permite cambiar el periodo del partido")]
        public string periodo
        {
            set { periodoMarcador.Text = value; }
            get { return periodoMarcador.Text; }
        }

        [Category("Control personalizado")]
        [Description("Este control permite cambiar el tiempo del partido")]
        public string tiempo
        {
            set { tiempoLbl.Text = value; }
            get { return tiempoLbl.Text; }
        }


    }
}
