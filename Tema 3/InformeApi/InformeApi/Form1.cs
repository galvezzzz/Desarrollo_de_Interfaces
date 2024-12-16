using Newtonsoft.Json;
using RestSharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json.Nodes;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace InformeApi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
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

        private static void GetItem()
        {
            var texto = new RestClient("https://fakestoreapi.com/");
            var request = new RestRequest($"/products", Method.Get);
            var response = texto.Execute(request);
            Console.WriteLine(response.Content);
        }

        static void Main(string[] args)
        {
            GetItem();   
        }
    }
}
