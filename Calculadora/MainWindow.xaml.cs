using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Calculadora
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            Operando1TextBox.Text = "0";
            Operando2TextBox.Text = "0";
            ResultadoTextBox.Text = "0";
            SumaRadioButton.IsChecked = true;
        }

        private void RealizarOperacion()
        {
            if (!double.TryParse(Operando1TextBox.Text, out double operando1))
            {
                Operando1TextBox.Text = "";
                operando1 = 0;
            }
            if (!double.TryParse(Operando2TextBox.Text, out double operando2))
            {
                Operando2TextBox.Text = "";
                operando2 = 0;
            }
            string textoFinal = "0";
            if (SumaRadioButton.IsChecked == true)
            {
                textoFinal = $"{Math.Round(operando1 + operando2, 3)}";
            }
            else if (RestaRadioButton.IsChecked == true)
            {
                textoFinal = $"{Math.Round(operando1 - operando2, 3)}";
            }
            else if (MultiplicacionRadioButton.IsChecked == true)
            {
                textoFinal = $"{Math.Round(operando1 * operando2, 3)}";
            }
            else if(DivisionRadioButton.IsChecked == true)
            {
                textoFinal = operando2 != 0 ? $"{Math.Round(operando1 / operando2, 3)}" : "Error";
            }
            ResultadoTextBox.Text = textoFinal;
        }

        private void TextoCambiado(object sender, TextChangedEventArgs e)
        {
            RealizarOperacion();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            SumaRadioButton.IsChecked = true;
            Operando1TextBox.Text = "0";
            Operando2TextBox.Text = "0";
        }

        private void Click_RadioButton(object sender, RoutedEventArgs e)
        {
            RealizarOperacion();
        }

        private void VaciarTextBox1(object sender, RoutedEventArgs e)
        {
            if (Operando1TextBox.Text == "0")
            {
                Operando1TextBox.Text = "";
            }
        }

        private void VaciarTextBox2(object sender, RoutedEventArgs e)
        {
            if (Operando2TextBox.Text == "0")
            {
                Operando2TextBox.Text = "";
            }
        }
    }
}
