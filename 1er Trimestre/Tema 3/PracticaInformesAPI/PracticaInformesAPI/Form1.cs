using Microsoft.Reporting.WinForms;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PracticaInformesAPI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public bool comboSeleccion { get; set; }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargarDatos();
            reportViewer1.LocalReport.SetParameters(new ReportParameter("ReportParameter1", "Alberto El King"));
            this.reportViewer1.RefreshReport();
            
        }

        private void cargarDatos()
        {
            List<Producto> lista = listaDesdeApi();

            if (comboSeleccion)
            {
                lista = lista.FindAll(a => a.price >= 50).ToList();
            }

            ReportDataSource ds = new ReportDataSource("DataSet1", lista);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(ds);
        }

        private List<Producto> listaDesdeApi()
        {
            RestClient client = new RestClient("https://fakestoreapi.com/");
            RestRequest request = new RestRequest("products");

            RestResponse response = client.Execute(request);
            List<Producto> products = JsonConvert.DeserializeObject<List<Producto>>(response.Content);

            return products;
        }
    }
}
