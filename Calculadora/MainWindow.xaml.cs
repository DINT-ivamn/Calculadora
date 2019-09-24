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
        }

        private void RealizarOperacion(object sender, TextChangedEventArgs e)
        {
            if(!int.TryParse(Operando1TextBox.Text, out int operando1))
            {
                Operando1TextBox.Text = "0";
                operando1 = 0;
            }
            if (!int.TryParse(Operando2TextBox.Text, out int operando2))
            {
                Operando2TextBox.Text = "0";
                operando2 = 0;
            }
            string textoFinal = "0";
            if (SumaRadioButton.IsChecked == true)
            {
                textoFinal = $"{operando1 + operando2}";
            }
            else if (RestaRadioButton.IsChecked == true)
            {
                textoFinal = $"{operando1 - operando2}";
            }
            else if (MultiplicacionRadioButton.IsChecked == true)
            {
                textoFinal = $"{operando1 * operando2}";
            }
            else
            {
                textoFinal = operando2 != 0 ? $"{operando1 / operando2}" : "Error";
            }
            ResultadoTextBox.Text = textoFinal;
        }
    }
}
