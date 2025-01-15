using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace CuentaRevoluciones
{
    public partial class MainWindow : Window
    {
        double rpmDigitales = 1000;
        double sumaCaballos;

        public MainWindow()
        {
            InitializeComponent();
            RotarAguja.Angle = 759.452;
            cuentaRevolucionesLbl.Content = "0";
        }


        private void StartCar()
        {
            cuentaRevolucionesLbl1.Content = "El coche ha arrancado";
        }

        private void StopCar()
        {
            cuentaRevolucionesLbl1.Content = "El coche se ha apagado";
        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            StopCar();
            cuentaRevolucionesLbl.Content = "0";
            rpmDigitales = 0;
            RotarAguja.Angle = 759.452;
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            StartCar();
            cuentaRevolucionesLbl.Content = "1000";
            RotarAguja.Angle = 786.577;
        }

        private void BotonAcelerador_Click(object sender, RoutedEventArgs e)
        {

            if ((bool)arranque.IsChecked)
            {
                if (RotarAguja.Angle <= 1017.702)
                {
                    rpmDigitales += 35 * sumaCaballos;
                    RotarAguja.Angle += sumaCaballos;
                    colorBlanco.Offset -= sumaCaballos * 0.01;
                }
                cuentaRevolucionesLbl.Content = rpmDigitales.ToString();
            }
            else
            { 
                cuentaRevolucionesLbl1.Content = "Enciende el motor";
            }
        }

        private void CaballosBajos_Checked(object sender, RoutedEventArgs e)
        {
            if ((bool)arranque.IsChecked)
            {
                sumaCaballos = 1;
                rpmDigitales = 1000;
                RotarAguja.Angle = 786.577;
                cuentaRevolucionesLbl.Content = "1000";
            }
            else
            {
                cuentaRevolucionesLbl1.Content = "Enciende el motor";
            }
        }

        private void CaballosMedios_Checked(object sender, RoutedEventArgs e)
        {
            if ((bool)arranque.IsChecked)
            {
                sumaCaballos = 1.25;
                rpmDigitales = 1000;
                RotarAguja.Angle = 786.577;
                cuentaRevolucionesLbl.Content = "1000";
            }
            else
            {
                cuentaRevolucionesLbl1.Content = "Enciende el motor";
            }
        }

        private void CaballosAltos_Checked(object sender, RoutedEventArgs e)
        {
            if ((bool)arranque.IsChecked)
            {
                sumaCaballos = 1.75;
                rpmDigitales = 1000;
                RotarAguja.Angle = 786.577;
                cuentaRevolucionesLbl.Content = "1000";
            }
            else
            {
                cuentaRevolucionesLbl1.Content = "Enciende el motor";
            }
        }

        private void BotonFreno_Click(object sender, RoutedEventArgs e)
        {
            if (RotarAguja.Angle >= 786.576)
            {
                RotarAguja.Angle -= sumaCaballos;
                rpmDigitales -= 35 * sumaCaballos;
                colorBlanco.Offset += sumaCaballos * 0.01;
            }


            cuentaRevolucionesLbl.Content = rpmDigitales.ToString();
        }
    }
}