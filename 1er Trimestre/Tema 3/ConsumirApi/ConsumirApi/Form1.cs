using Microsoft.Reporting.WinForms;
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
using static System.Net.WebRequestMethods;

namespace ConsumirApi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnPost_Click(object sender, EventArgs e)
        {

        }

        private void btnPrueba_Click(object sender, EventArgs e)
        {

        }
    }

    public class Data
    {
        public int id;
        public string title;
        public float price;
        string description;
        string category;
        string image;
        Rating rating;

    }

    public class Rating
    {
        float rate;
        int count;
    }


    
}
