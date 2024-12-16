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

namespace ControlCronometro
{
    public partial class Cronometro: UserControl
    {
        private Stopwatch stopwatch;
        public Cronometro()
        {
            InitializeComponent();
            stopwatch = new Stopwatch();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (timer.Enabled)
            {
                stopwatch.Stop();
                timer.Enabled = false;
            }
            else
            {
                stopwatch.Start();
                timer.Enabled = true;
            }
        }
        private void button3_Click(object sender, EventArgs e)
        {
            stopwatch.Restart();
            timer.Enabled = true;
        }

        
        Color c = Color.Black;
        [Category("Control personalizado")]
        [Description("Este control permite cambiar el color del cronómetro")]
        public Color cambiarColorNumeros { 
            get { return c; }
            set 
            {
                c = value;
                dataGridView1.BackgroundColor = c;
                dataGridView2.BackgroundColor = c;
                dataGridView3.BackgroundColor = c;
                dataGridView4.BackgroundColor = c;
                dataGridView5.BackgroundColor = c;
                dataGridView6.BackgroundColor = c;
                dataGridView7.BackgroundColor = c;
                dataGridView8.BackgroundColor = c;
                dataGridView9.BackgroundColor = c;
                dataGridView10.BackgroundColor = c;
                dataGridView11.BackgroundColor = c;
                dataGridView12.BackgroundColor = c;
                dataGridView13.BackgroundColor = c;
                dataGridView14.BackgroundColor = c;
                dataGridView15.BackgroundColor = c;
                dataGridView16.BackgroundColor = c;
                dataGridView17.BackgroundColor = c;
                dataGridView18.BackgroundColor = c;
                dataGridView19.BackgroundColor = c;
                dataGridView20.BackgroundColor = c;
                dataGridView21.BackgroundColor = c;
                dataGridView22.BackgroundColor = c;
                dataGridView23.BackgroundColor = c;
                dataGridView24.BackgroundColor = c;
                dataGridView25.BackgroundColor = c;
                dataGridView26.BackgroundColor = c;
                dataGridView27.BackgroundColor = c;
                dataGridView28.BackgroundColor = c;
                dataGridView29.BackgroundColor = c;
                dataGridView30.BackgroundColor = c;
            }
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            TimeSpan ts = new TimeSpan(0, 0, 0, 0, (int) stopwatch.ElapsedMilliseconds);
   
            int minutosUd = ts.Minutes % 10;
            int minutosDe = ts.Minutes / 10 % 10;
            int segundosUd = ts.Seconds % 10;
            int segundosDe = ts.Seconds / 10 % 10;
            int milisegundos = ts.Milliseconds;

            if (milisegundos >= 0 && milisegundos < 500) {
                dataGridView29.Visible = true;
                dataGridView30.Visible = true;
            }
            else
            {
                dataGridView29.Visible = false;
                dataGridView30.Visible = false;
            }

            switch (segundosUd)
            {
                case 1:
                    dataGridView22.Visible = false;
                    dataGridView23.Visible = false;
                    dataGridView24.Visible = false;
                    dataGridView25.Visible = true;
                    dataGridView26.Visible = true;
                    dataGridView27.Visible = false;
                    dataGridView28.Visible = false;
                    break;
                case 2:
                    dataGridView22.Visible = true;
                    dataGridView23.Visible = true;
                    dataGridView24.Visible = true;
                    dataGridView25.Visible = true;
                    dataGridView26.Visible = false;
                    dataGridView27.Visible = true;
                    dataGridView28.Visible = false;
                    break ;
                case 3:
                    dataGridView22.Visible = true;
                    dataGridView23.Visible = true;
                    dataGridView24.Visible = false;
                    dataGridView25.Visible = true;
                    dataGridView26.Visible = true;
                    dataGridView27.Visible = true;
                    dataGridView28.Visible = false;
                    break;
                case 4:
                    dataGridView22.Visible = true;
                    dataGridView23.Visible = false;
                    dataGridView24.Visible = false;
                    dataGridView25.Visible = true;
                    dataGridView26.Visible = true;
                    dataGridView27.Visible = false;
                    dataGridView28.Visible = true;
                    break;
                case 5:
                    dataGridView22.Visible = true;
                    dataGridView23.Visible = true;
                    dataGridView24.Visible = false;
                    dataGridView25.Visible = false;
                    dataGridView26.Visible = true;
                    dataGridView27.Visible = true;
                    dataGridView28.Visible = true;
                    break;
                case 6:
                    dataGridView22.Visible = true;
                    dataGridView23.Visible = true;
                    dataGridView24.Visible = true;
                    dataGridView25.Visible = false;
                    dataGridView26.Visible = true;
                    dataGridView27.Visible = true;
                    dataGridView28.Visible = true;
                    break;
                case 7:
                    dataGridView22.Visible = false;
                    dataGridView23.Visible = false;
                    dataGridView24.Visible = false;
                    dataGridView25.Visible = true;
                    dataGridView26.Visible = true;
                    dataGridView27.Visible = true;
                    dataGridView28.Visible = false;
                    break;
                case 8:
                    dataGridView22.Visible = true;
                    dataGridView23.Visible = true;
                    dataGridView24.Visible = true;
                    dataGridView25.Visible = true;
                    dataGridView26.Visible = true;
                    dataGridView27.Visible = true;
                    dataGridView28.Visible = true;
                    break;
                case 9:
                    dataGridView22.Visible = true;
                    dataGridView23.Visible = true;
                    dataGridView24.Visible = false;
                    dataGridView25.Visible = true;
                    dataGridView26.Visible = true;
                    dataGridView27.Visible = true;
                    dataGridView28.Visible = true;
                    break;
                case 0:
                    dataGridView22.Visible = false;
                    dataGridView23.Visible = true;
                    dataGridView24.Visible = true;
                    dataGridView25.Visible = true;
                    dataGridView26.Visible = true;
                    dataGridView27.Visible = true;
                    dataGridView28.Visible = true;
                    break;
            }

            switch (segundosDe)
            {
                case 1:
                    dataGridView15.Visible = false;
                    dataGridView16.Visible = false;
                    dataGridView17.Visible = false;
                    dataGridView18.Visible = true;
                    dataGridView19.Visible = true;
                    dataGridView20.Visible = false;
                    dataGridView21.Visible = false;
                    break;
                case 2:
                    dataGridView15.Visible = true;
                    dataGridView16.Visible = true;
                    dataGridView17.Visible = true;
                    dataGridView18.Visible = true;
                    dataGridView19.Visible = false;
                    dataGridView20.Visible = true;
                    dataGridView21.Visible = false;
                    break;
                case 3:
                    dataGridView15.Visible = true;
                    dataGridView16.Visible = true;
                    dataGridView17.Visible = false;
                    dataGridView18.Visible = true;
                    dataGridView19.Visible = true;
                    dataGridView20.Visible = true;
                    dataGridView21.Visible = false;
                    break;
                case 4:
                    dataGridView15.Visible = true;
                    dataGridView16.Visible = false;
                    dataGridView17.Visible = false;
                    dataGridView18.Visible = true;
                    dataGridView19.Visible = true;
                    dataGridView20.Visible = false;
                    dataGridView21.Visible = true;
                    break;
                case 5:
                    dataGridView15.Visible = true;
                    dataGridView16.Visible = true;
                    dataGridView17.Visible = false;
                    dataGridView18.Visible = false;
                    dataGridView19.Visible = true;
                    dataGridView20.Visible = true;
                    dataGridView21.Visible = true;
                    break;
                case 6:
                    dataGridView15.Visible = true;
                    dataGridView16.Visible = true;
                    dataGridView17.Visible = true;
                    dataGridView18.Visible = false;
                    dataGridView19.Visible = true;
                    dataGridView20.Visible = true;
                    dataGridView21.Visible = true;
                    break;
                case 0:
                    dataGridView15.Visible = false;
                    dataGridView16.Visible = true;
                    dataGridView17.Visible = true;
                    dataGridView18.Visible = true;
                    dataGridView19.Visible = true;
                    dataGridView20.Visible = true;
                    dataGridView21.Visible = true;
                    break;
            }

            switch (minutosUd)
            {
                case 1:
                    dataGridView4.Visible = false;
                    dataGridView5.Visible = false;
                    dataGridView10.Visible = false;
                    dataGridView11.Visible = true;
                    dataGridView12.Visible = true;
                    dataGridView13.Visible = false;
                    dataGridView14.Visible = false;
                    break;
                case 2:
                    dataGridView4.Visible = true;
                    dataGridView5.Visible = true;
                    dataGridView10.Visible = true;
                    dataGridView11.Visible = true;
                    dataGridView12.Visible = false;
                    dataGridView13.Visible = true;
                    dataGridView14.Visible = false;
                    break;
                case 3:
                    dataGridView4.Visible = true;
                    dataGridView5.Visible = true;
                    dataGridView10.Visible = false;
                    dataGridView11.Visible = true;
                    dataGridView12.Visible = true;
                    dataGridView13.Visible = true;
                    dataGridView14.Visible = false;
                    break;
                case 4:
                    dataGridView4.Visible = true;
                    dataGridView5.Visible = false;
                    dataGridView10.Visible = false;
                    dataGridView11.Visible = true;
                    dataGridView12.Visible = true;
                    dataGridView13.Visible = false;
                    dataGridView14.Visible = true;
                    break;
                case 5:
                    dataGridView4.Visible = true;
                    dataGridView5.Visible = true;
                    dataGridView10.Visible = false;
                    dataGridView11.Visible = false;
                    dataGridView12.Visible = true;
                    dataGridView13.Visible = true;
                    dataGridView14.Visible = true;
                    break;
                case 6:
                    dataGridView4.Visible = true;
                    dataGridView5.Visible = true;
                    dataGridView10.Visible = true;
                    dataGridView11.Visible = false;
                    dataGridView12.Visible = true;
                    dataGridView13.Visible = true;
                    dataGridView14.Visible = true;
                    break;
                case 7:
                    dataGridView4.Visible = false;
                    dataGridView5.Visible = false;
                    dataGridView10.Visible = false;
                    dataGridView11.Visible = true;
                    dataGridView12.Visible = true;
                    dataGridView13.Visible = true;
                    dataGridView14.Visible = false;
                    break;
                case 8:
                    dataGridView4.Visible = true;
                    dataGridView5.Visible = true;
                    dataGridView10.Visible = true;
                    dataGridView11.Visible = true;
                    dataGridView12.Visible = true;
                    dataGridView13.Visible = true;
                    dataGridView14.Visible = true;
                    break;
                case 9:
                    dataGridView4.Visible = true;
                    dataGridView5.Visible = true;
                    dataGridView10.Visible = false;
                    dataGridView11.Visible = true;
                    dataGridView12.Visible = true;
                    dataGridView13.Visible = true;
                    dataGridView14.Visible = true;
                    break;
                case 0:
                    dataGridView4.Visible = false;
                    dataGridView5.Visible = true;
                    dataGridView10.Visible = true;
                    dataGridView11.Visible = true;
                    dataGridView12.Visible = true;
                    dataGridView13.Visible = true;
                    dataGridView14.Visible = true;
                    break;
            }

            switch (minutosDe)
            {
                case 1:
                    dataGridView1.Visible = false;
                    dataGridView2.Visible = false;
                    dataGridView3.Visible = false;
                    dataGridView6.Visible = false;
                    dataGridView7.Visible = true;
                    dataGridView8.Visible = true;
                    dataGridView9.Visible = false;
                    break;
                case 2:
                    dataGridView1.Visible = false;
                    dataGridView2.Visible = true;
                    dataGridView3.Visible = true;
                    dataGridView6.Visible = true;
                    dataGridView7.Visible = false;
                    dataGridView8.Visible = true;
                    dataGridView9.Visible = true;
                    break;
                case 3:
                    dataGridView1.Visible = false;
                    dataGridView2.Visible = true;
                    dataGridView3.Visible = true;
                    dataGridView6.Visible = true;
                    dataGridView7.Visible = true;
                    dataGridView8.Visible = true;
                    dataGridView9.Visible = false;
                    break;
                case 4:
                    dataGridView1.Visible = true;
                    dataGridView2.Visible = false;
                    dataGridView3.Visible = true;
                    dataGridView6.Visible = false;
                    dataGridView7.Visible = true;
                    dataGridView8.Visible = true;
                    dataGridView9.Visible = false;
                    break;
                case 5:
                    dataGridView1.Visible = true;
                    dataGridView2.Visible = true;
                    dataGridView3.Visible = true;
                    dataGridView6.Visible = true;
                    dataGridView7.Visible = true;
                    dataGridView8.Visible = false;
                    dataGridView9.Visible = false;
                    break;
                case 6:
                    dataGridView1.Visible = true;
                    dataGridView2.Visible = true;
                    dataGridView3.Visible = true;
                    dataGridView6.Visible = true;
                    dataGridView7.Visible = true;
                    dataGridView8.Visible = false;
                    dataGridView9.Visible = true;
                    break;
                case 0:
                    dataGridView1.Visible = true;
                    dataGridView2.Visible = true;
                    dataGridView3.Visible = false;
                    dataGridView6.Visible = true;
                    dataGridView7.Visible = true;
                    dataGridView8.Visible = true;
                    dataGridView9.Visible = true;
                    break;
            }
        }

        [Category("Evento personalizado")]
        [Description("Este evento permite mostrar los segundos")]
        public event EventHandler pasarSegundos;

        private void secondPassEvent()
        {
            if (pasarSegundos != null)
            {
                this.pasarSegundos.Invoke(this, EventArgs.Empty);
            }
        }
    }
}
