using System.Configuration.Internal;
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
        int sumaAngulo = 35;

        private const double COLORBLANCO = 0.98;
        private const int RPMARRANCADO = 1000;
        private const int RPMCERO = 0;
        private const int ANGULOCERO = 759;
        private const double ANGULOINICIO = 786;
        private const int ANGULOFINAL = 1017;
        private const string DIGITALCERO = "0";
        private const string DIGITALMIL = "1000";
        private const string ENCIENDE = "Enciende el motor";
        private const string ARRANCA = "El coche ha arrancado";
        private const string APAGA = "El coche se ha apagado";


        // caballos cambiarlos teniendo el coche apagado

        public MainWindow()
        {
            InitializeComponent();
            RotarAguja.Angle = ANGULOCERO;
            cuentaRevolucionesLbl.Content = DIGITALCERO;
        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            cuentaRevolucionesLbl1.Content = APAGA;
            cuentaRevolucionesLbl.Content = DIGITALCERO;
            rpmDigitales = RPMCERO;
            RotarAguja.Angle = ANGULOCERO;
            colorBlanco.Offset = COLORBLANCO;
            CaballosAltos.IsEnabled = true;
            CaballosMedios.IsEnabled = true;
            CaballosBajos.IsEnabled = true;

        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            cuentaRevolucionesLbl1.Content = ARRANCA;
            cuentaRevolucionesLbl.Content = DIGITALMIL;
            RotarAguja.Angle = ANGULOINICIO;
            CaballosAltos.IsEnabled = false;
            CaballosMedios.IsEnabled = false;
            CaballosBajos.IsEnabled = false;
        }

        private void BotonAcelerador_Click(object sender, RoutedEventArgs e)
        {
            establecerPedalAcelerador();
            BotonAcelerador.Width = 60;
            BotonAcelerador.Height = 60;
        }

        private void BotonFreno_Click(object sender, RoutedEventArgs e)
        {
            establecerPedalFreno();
            BotonFreno.Width = 60;
            BotonFreno.Height = 60;
        }

        private void CaballosBajos_Checked(object sender, RoutedEventArgs e)
        {
            establecerCaballos(1);
        }

        private void CaballosMedios_Checked(object sender, RoutedEventArgs e)
        {
            establecerCaballos(1.3);
        }

        private void CaballosAltos_Checked(object sender, RoutedEventArgs e)
        {
            establecerCaballos(1.75);
        }

        private double establecerCaballos(double velocidadCaballos)
        {
            sumaCaballos = velocidadCaballos;
            return sumaCaballos;
  
        }

        private void establecerPedalFreno()
        {
            if ((bool)arranque.IsChecked)
            {
                if (RotarAguja.Angle >= ANGULOINICIO)
                {
                    RotarAguja.Angle -= sumaCaballos;
                    rpmDigitales -= sumaAngulo * sumaCaballos;
                    colorBlanco.Offset += sumaCaballos * 0.01;
                }
                cuentaRevolucionesLbl.Content = rpmDigitales.ToString();
            }
            else
            {
                cuentaRevolucionesLbl1.Content = ENCIENDE;
            }
        }

        private void establecerPedalAcelerador()
        {
            if ((bool)arranque.IsChecked)
            {
                if (RotarAguja.Angle <= ANGULOFINAL)
                {
                    rpmDigitales += sumaAngulo * sumaCaballos;
                    RotarAguja.Angle += sumaCaballos;
                    colorBlanco.Offset -= sumaCaballos * 0.01;
                }
                cuentaRevolucionesLbl.Content = rpmDigitales.ToString();
            }
            else
            {
                cuentaRevolucionesLbl1.Content = ENCIENDE;
            }
        }
    }
}