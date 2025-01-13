using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventoTermometro
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public event EventHandler Termometro;

        protected virtual void OnCambioTermometro(EventArgs e)
        {
            EventHandler handler = Termometro;
            handler?.Invoke(this, e);
        }
    }
}
