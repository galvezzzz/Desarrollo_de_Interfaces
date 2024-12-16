using Microsoft.Reporting.WinForms;
using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Informulario
{
    public partial class Form1 : Form
    {
        public bool Check1 { get; set; }
        public bool Check2 { get; set; }
        public bool Check3 { get; set; }
        public bool Check4 { get; set; }
        public bool Check5 { get; set; }
        public bool Check6 { get; set; }
        public int ValueTrack { get; set; }
        public int ValueTextBox { get; set; }
        public string ValueComboBox { get; set; }


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cargarDatos();
            this.reportViewer1.RefreshReport();
        }

        private void cargarDatos()
        {
            List<Producto> lista = listaDesdeApi();

            // Muestra las columnas seleccionadas con checkbox
            var listaProyectada = lista.Select(producto => new
            {
                id = Check1 ? producto.id : (int?)null,
                title = Check2 ? producto.title : null,
                price = Check3 ? producto.price : (double?)null,
                description = Check4 ? producto.description : null,
                category = Check5 ? producto.category : null,
                image = Check6 ? producto.image: null,
            }).ToList();

            if (Check3)
            {
                listaProyectada = listaProyectada.FindAll(a => a.price >= ValueTrack).ToList();
            }

            if (Check1 && ValueTextBox != -1)
            {
                listaProyectada = listaProyectada.FindAll(a => a.id == ValueTextBox).ToList();
            }

            if (Check5 && !ValueComboBox.Equals(""))
            {
                listaProyectada = listaProyectada.FindAll(a => a.category.Equals(ValueComboBox)).ToList();
            }


            ReportDataSource ds = new ReportDataSource("DataSet1", listaProyectada);
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
