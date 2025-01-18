using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ExamenInformes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public bool CiudadesGrandes { get; set; }
        public bool ActivarZonaHoraria { get; set; }
        public string ZonaHoraria { get; set; }
        public string BuscaCiudad { get; set; }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargarDatos();

            reportViewer1.LocalReport.SetParameters(new ReportParameter("CiudadesHeader", "Ciudades EEUU"));
            reportViewer1.LocalReport.SetParameters(new ReportParameter("ParamZonaHoraria", ZonaHoraria));
            this.reportViewer1.RefreshReport();
        }

        private void cargarDatos()
        {
            List<CiudadesEEUU> lista = listaDesdeFichero();

            if (CiudadesGrandes)
            {
                lista = lista.FindAll(a => a.Population > 1000000).ToList();
                reportViewer1.LocalReport.SetParameters(new ReportParameter("CiudadGrandeParam", "Ciudades grandes seleccionadas"));
            }
            else
            {
                reportViewer1.LocalReport.SetParameters(new ReportParameter("CiudadGrandeParam", "Ciudades grandes no seleccionadas"));
            }

            if (ActivarZonaHoraria)
            {
                lista = lista.FindAll(a => a.Timezone.Equals(ZonaHoraria)).ToList();
            }

            if (!BuscaCiudad.Equals(""))
            {
                lista = lista.FindAll(a => a.Name.Equals(BuscaCiudad)).ToList();
            }

            ReportDataSource ds = new ReportDataSource("DataSet1", lista);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(ds);
        }

        private List<CiudadesEEUU> listaDesdeFichero()
        {
            List<CiudadesEEUU> cities = new List<CiudadesEEUU>();

            List<string> lineasCiudades = File.ReadAllLines("CiudadesEEUU.csv").ToList();

            lineasCiudades.RemoveAt(0);

            foreach (string line in lineasCiudades)
            {
                string[] parts = line.Split(';');

                CiudadesEEUU columna = new CiudadesEEUU();
                columna.Name = parts[0];
                columna.Latitude = (int)Convert.ToDouble(parts[1]);
                columna.Longitude = Convert.ToDouble(parts[2]);
                columna.Population = Convert.ToInt32(parts[3]);
                columna.Timezone = parts[4];
                cities.Add(columna);
                
            }

            return cities;
        }
    }
}
