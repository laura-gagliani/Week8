using EquazioniSecondoGrado.Core;
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

namespace EquazioniSecondoGrado.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double a;
        double b;
        double c;
        Equation eq = new Equation();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCalcola_Click(object sender, RoutedEventArgs e)
        {
            a = string.IsNullOrEmpty(coeffA.Text) ? 0 : double.Parse(coeffA.Text);
            b = string.IsNullOrEmpty(coeffB.Text) ? 0 : double.Parse(coeffB.Text);
            c = string.IsNullOrEmpty(coeffC.Text) ? 0 : double.Parse(coeffC.Text);

            coeffA.Clear();
            coeffB.Clear();
            coeffC.Clear();
            textBoxEquazione.Text = $"{a}x² + {b}x + {c} = 0";
            double[] res = eq.RisolviEquazioneDiSecondoGrado(a, b, c);

            if (res == null)
            {
                textBoxSoluzioni.Text = "L'equazione non ha soluzioni!";

            }
            else if (res.Length == 1)
            {
                textBoxSoluzioni.Text = $"Coincidenti: x₁ = x₂ = {Math.Round(res[0], 2)}";
            }
            else if (res.Length == 2)
            {
                textBoxSoluzioni.Text = $"Distinte: x₁ = {Math.Round(res[0], 2)}\tx₂ = {Math.Round(res[1], 2)}";
            }
        }
    }
}
