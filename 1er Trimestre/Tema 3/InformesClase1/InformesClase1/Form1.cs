using Microsoft.Reporting.WinForms;
using Npgsql;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InformesClase1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            using (NpgsqlConnection conn = new NpgsqlConnection("Server=localhost; Port=5432; User Id=postgres; Password=iesbelen; Database=Empleados"))
            {
                conn.Open();

                NpgsqlCommand cmd = new NpgsqlCommand("SELECT * FROM empleado", conn);
                NpgsqlDataAdapter dr = new NpgsqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                dr.Fill(dt);

                ReportDataSource ds1 = new ReportDataSource("DataSetEmpleados", dt);
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(ds1);



                NpgsqlCommand cmd1 = new NpgsqlCommand("SELECT * FROM departamento", conn);
                NpgsqlDataAdapter dr1 = new NpgsqlDataAdapter(cmd1);
                DataTable dt1 = new DataTable();
                dr1.Fill(dt1);


                ReportDataSource ds2 = new ReportDataSource("DataSetDepartamento", dt1);
                reportViewer1.LocalReport.DataSources.Add(ds2);

            }

            this.reportViewer1.RefreshReport();
        }
    }
}
