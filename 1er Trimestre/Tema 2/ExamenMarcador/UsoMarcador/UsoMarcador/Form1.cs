using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UsoMarcador
{
    public partial class Form1 : Form
    {

        int mm, ss;
        string m, s;
        public Form1()
        {
            InitializeComponent();
        }

        private void trackBarLocal_Scroll(object sender, EventArgs e)
        {
            switch (trackBarLocal.Value)
            {

                case 0:
                    marcador1.marcadorLocal = trackBarLocal.Value.ToString();
                    break;
                case 1:
                    marcador1.marcadorLocal = trackBarLocal.Value.ToString();
                    break;
                case 2:
                    marcador1.marcadorLocal = trackBarLocal.Value.ToString();        
                    break;
                case 3:
                    marcador1.marcadorLocal = trackBarLocal.Value.ToString();
                    break;

                case 4:
                    marcador1.marcadorLocal = trackBarLocal.Value.ToString();
                    break;
                case 5:
                    marcador1.marcadorLocal = trackBarLocal.Value.ToString();
                    break;
                case 6:
                    marcador1.marcadorLocal = trackBarLocal.Value.ToString();
                    break;
                case 7:
                    marcador1.marcadorLocal = trackBarLocal.Value.ToString();
                    break;

                case 8:
                    marcador1.marcadorLocal = trackBarLocal.Value.ToString();
                    break;
                case 9:
                    marcador1.marcadorLocal = trackBarLocal.Value.ToString();
                    break;
            }
        }

        private void trackBarVisitante_Scroll(object sender, EventArgs e)
        {
            switch (trackBarVisitante.Value)
            {

                case 0:
                    marcador1.marcadorVisitante = trackBarVisitante.Value.ToString();
                    break;
                case 1:
                    marcador1.marcadorVisitante = trackBarVisitante.Value.ToString();
                    break;
                case 2:
                    marcador1.marcadorVisitante = trackBarVisitante.Value.ToString();
                    break;
                case 3:
                    marcador1.marcadorVisitante = trackBarVisitante.Value.ToString();
                    break;

                case 4:
                    marcador1.marcadorVisitante = trackBarVisitante.Value.ToString();
                    break;
                case 5:
                    marcador1.marcadorVisitante = trackBarVisitante.Value.ToString();
                    break;
                case 6:
                    marcador1.marcadorVisitante = trackBarVisitante.Value.ToString();
                    break;
                case 7:
                    marcador1.marcadorVisitante = trackBarVisitante.Value.ToString();
                    break;

                case 8:
                    marcador1.marcadorVisitante = trackBarVisitante.Value.ToString();
                    break;   
                case 9:
                    marcador1.marcadorVisitante = trackBarVisitante.Value.ToString();
                    break;
            }
        }

        private void btnComenzar_Click(object sender, EventArgs e)
        {
            if (timer.Enabled)
            {
                timer.Stop();
                timer.Enabled = false;
                btnComenzar.Text = "COMENZAR";
            }
            else
            {
                timer.Start();
                timer.Enabled = true;
                btnComenzar.Text = "PARAR";
            }
        }

        private void periodoCombo_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (periodoCombo.SelectedIndex == 0)
            {
                timer.Stop();
                marcador1.periodo = "1";
                marcador1.tiempo = "00:00";
                mm = 0;
                ss = 0;
                establecerTiempoMarcador();

            }
            else
            {
                timer.Stop();
                
                marcador1.periodo = "2";
                marcador1.tiempo = "45:00";
                mm = 45;
                ss = 0;
                establecerTiempoMarcador();
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            ss += 1;

            establecerTiempoMarcador();
           
        }

        public void establecerTiempoMarcador()
        {
            m = Convert.ToString(mm);
            s = Convert.ToString(ss);

            marcador1.tiempo = Convert.ToString(mm + ":" + ss / 10);
            if (ss > 590)
            {
                mm += 1;
                ss = 0;

                if (mm >= 45 && ss == 0)
                {
                    MessageBox.Show("¡¡Final de la primera parte!!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }

                if (mm >= 90)
                {
                    MessageBox.Show("¡¡Final del partido!!", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    return;
                }
            }
        }
    }
}
