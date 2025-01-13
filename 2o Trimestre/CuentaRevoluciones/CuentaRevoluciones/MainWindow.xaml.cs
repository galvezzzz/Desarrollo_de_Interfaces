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
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int rpmDigitales = 1000;

        public MainWindow()
        {
            InitializeComponent();

            while (!BotonAcelerador.IsPressed && rpmDigitales >= 1000)
            {
                rpmDigitales -= 21;
            }
        }


        private void StartCar()
        {
            MessageBox.Show("¡El coche ha arrancado!", "Estado del Coche");
        }

        private void StopCar()
        {
            MessageBox.Show("El coche se ha apagado.", "Estado del Coche");
        }

        private void CheckBox_Unchecked(object sender, RoutedEventArgs e)
        {
            StopCar();
            cuentaRevolucionesLbl.Content = "0";
            rpmDigitales = 0;
        }

        private void CheckBox_Checked(object sender, RoutedEventArgs e)
        {
            StartCar();
            cuentaRevolucionesLbl.Content = "1000";
        }

        private void BotonAcelerador_Click(object sender, RoutedEventArgs e)
        {
            if ((bool)arranque.IsChecked)
            {
                rpmDigitales += 21;

                cuentaRevolucionesLbl.Content = rpmDigitales.ToString();
            }
            else
            {
                MessageBox.Show("Enciende el motor para poder acelerar", "¡Atención!");
            }

            
        }
    }
}