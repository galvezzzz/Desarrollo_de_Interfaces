using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace cocheMercedes
{
    public partial class Form1 : Form
    {

        List<Extra> extras1;
        List<Extra> extras2;
        List<Extra> extras3;
        List<Extra> extras4;
        double precioBase = 0;
        int precio = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            Extra ex;
            

            extras1 = new List<Extra>() { new Extra("Audio Base", 70), new Extra("Bizoma", 40), new Extra("Cámara trasera",80), new Extra("Sensores",80) };
            extras2 = new List<Extra>(extras1) { new Extra("Cuero", 15), new Extra("Cambio velocidad", 50), new Extra("Cambio carril", 90)};
            extras3 = new List<Extra>(extras2) { new Extra("GPS", 35), new Extra("Llantas", 55), new Extra("Asistencia aparcamiento", 95)};
            extras4 = new List<Extra>(extras3) { new Extra("CR7", 200), new Extra("Bale", 175), new Extra("Benzema", 150)};

            switch (comboBox1.SelectedItem)
            {
                case "Clase A":
                    pictureBox2.ImageLocation = "C:\\Users\\Alberto\\Desktop\\Interfaces\\cocheMercedes\\Images\\clasea.png";
                    clearAll();

                    for (int i = 0; i < extras1.Count; i++)
                    {
                        listBox1.Items.Add(extras1[i].NombreExtra);
                  
                    }
                    
                    label10.Text = "40.000€";
                    label4.Text = "40.000€";
                    precioBase = 40000;

                    break;

                case "Clase M":
                    pictureBox2.ImageLocation = "C:\\Users\\Alberto\\Desktop\\Interfaces\\cocheMercedes\\Images\\clasem.png";
                    clearAll();

                    for (int i = 0; i < extras2.Count; i++)
                    {
                        listBox1.Items.Add(extras2[i].NombreExtra);
                   
                    }

                    label10.Text = "50.000€";
                    label4.Text = "50.000€";
                    precioBase = 50000;

                    break;

                case "Clase G":
                    pictureBox2.ImageLocation = "C:\\Users\\Alberto\\Desktop\\Interfaces\\cocheMercedes\\Images\\gwagon.png";
                    clearAll();

                    for (int i = 0; i < extras3.Count; i++)
                    {
                        listBox1.Items.Add(extras3[i].NombreExtra);
                    }

                    

                    label10.Text = "80.000€";
                    label4.Text = "80.000€";
                    precioBase = 80000;

                    break;

                case "Coupé":
                    pictureBox2.ImageLocation = "C:\\Users\\Alberto\\Desktop\\Interfaces\\cocheMercedes\\Images\\coupe.png";
                    clearAll();

                    for (int i = 0; i < extras4.Count; i++)
                    {
                        listBox1.Items.Add(extras4[i].NombreExtra);
                     
                    }

                    label10.Text = "60.000€";
                    label4.Text = "60.000€";
                    precioBase = 60000;

                    break;
            }
        }

        public void clearAll()
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            

            int index = listBox1.SelectedIndex;
            listBox2.Items.Add(listBox1.SelectedItem);

            precio += extras1[listBox1.SelectedIndex].Precio;
            label11.Text = precio.ToString();

            listBox1.Items.RemoveAt(index);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int index = listBox2.SelectedIndex;
            listBox1.Items.Add(listBox2.SelectedItem);
            listBox2.Items.RemoveAt(index);
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

            if (checkBox1.Checked == false)
            {
                numericUpDown1.Enabled = false;
                label12.Text = "0";
            }
            else
            {
                numericUpDown1.Enabled = true;
                
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int porcentajeExtra;
            double cuota;
            double cuotaTotal;

            if (numericUpDown1.Value <= 6)
            {
                porcentajeExtra = 5;
                cuota = precioBase * porcentajeExtra / 100;
                label5.Text = cuota.ToString();
                cuotaTotal = cuota * (double) numericUpDown1.Value;
                label12.Text = cuotaTotal.ToString();

            }
            else if (numericUpDown1.Value <= 12)
            {
                porcentajeExtra = 3;
                cuota = precioBase * porcentajeExtra / 100;
                label5.Text = cuota.ToString();;
                cuotaTotal = cuota * (double)numericUpDown1.Value;
                label12.Text = cuotaTotal.ToString();
            }
            else
            {
                porcentajeExtra = 1;
                cuota = precioBase * porcentajeExtra / 100;
                label5.Text = cuota.ToString();
                cuotaTotal = cuota * (double)numericUpDown1.Value;
                label12.Text = cuotaTotal.ToString();
            }
        }
    }
}
