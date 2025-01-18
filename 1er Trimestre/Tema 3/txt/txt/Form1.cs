using Microsoft.Reporting.WinForms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace txt
{
    public partial class Form1 : Form
    {
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
            List<Class1> lista = listaDesdeFichero();

            ReportDataSource ds = new ReportDataSource("DataSet1", lista);
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(ds);
        }

        private List<Class1> listaDesdeFichero()
        {
            List<Class1> allProducts = new List<Class1>();

            List<string> productlines = File.ReadAllLines("Product.txt").ToList();

            //Remove headers
            productlines.RemoveAt(0);

            foreach (string line in productlines)
            {
                string[] parts = line.Split(';');

                Class1 product = new Class1();
                product.Name = parts[0];
                product.Price = Convert.ToInt32(parts[1]);
                product.Quantity = Convert.ToInt32(parts[2]);
                allProducts.Add(product);
            }

            return allProducts;
        }
    }
}
