using Calcolatrice.Core;
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

namespace Calcolatrice.WPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        double valueA;
        double valueB;
        string operation;
        Calculator c = new Calculator();

        public MainWindow()
        {
            InitializeComponent();
        }

        private void btn7_Click(object sender, RoutedEventArgs e)
        {
            txtBoxSchermo.Text += btn7.Content;
        }

        private void btn8_Click(object sender, RoutedEventArgs e)
        {
            txtBoxSchermo.Text += btn8.Content;
        }

        private void btn9_Click(object sender, RoutedEventArgs e)
        {
            txtBoxSchermo.Text += btn9.Content;
        }

        private void btn4_Click(object sender, RoutedEventArgs e)
        {
            txtBoxSchermo.Text += btn4.Content;
        }

        private void btn5_Click(object sender, RoutedEventArgs e)
        {
            txtBoxSchermo.Text += btn5.Content;
        }

        private void btn6_Click(object sender, RoutedEventArgs e)
        {
            txtBoxSchermo.Text += btn6.Content;
        }

        private void btn1_Click(object sender, RoutedEventArgs e)
        {
            txtBoxSchermo.Text += btn1.Content;
        }

        private void btn2_Click(object sender, RoutedEventArgs e)
        {
            txtBoxSchermo.Text += btn2.Content;
        }

        private void btn3_Click(object sender, RoutedEventArgs e)
        {
            txtBoxSchermo.Text += btn3.Content;
        }

        private void btn0_Click(object sender, RoutedEventArgs e)
        {
            txtBoxSchermo.Text += btn0.Content;
        }

        private void btnVirg_Click(object sender, RoutedEventArgs e)
        {
            txtBoxSchermo.Text += btnVirg.Content;
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            txtBoxSchermo.Clear();
        }

        private void SetOperation(string contentValue, string operationToDo)
        {
            valueA = double.Parse(contentValue);
            operation = operationToDo;
            txtBoxSchermo.Clear();
        }

        private void btnAdd_Click(object sender, RoutedEventArgs e)
        {
            SetOperation(txtBoxSchermo.Text, "somma");
        }

        private void btnSottr_Click(object sender, RoutedEventArgs e)
        {
            SetOperation(txtBoxSchermo.Text, "sottrai");

        }

        private void btnMolt_Click(object sender, RoutedEventArgs e)
        {
            SetOperation(txtBoxSchermo.Text, "moltiplica");

        }

        private void btnDiv_Click(object sender, RoutedEventArgs e)
        {
            SetOperation(txtBoxSchermo.Text, "dividi");

        }

        private void btnUgual_Click(object sender, RoutedEventArgs e)
        {
            valueB = string.IsNullOrEmpty(txtBoxSchermo.Text) ? 0 : double.Parse(txtBoxSchermo.Text);

            switch (operation)
            {
                case "somma":
                    txtBoxSchermo.Text = c.SommaNumeri(valueA, valueB).ToString();
                    break;
                case "sottrai":
                    txtBoxSchermo.Text = c.SottraiNumeri(valueA, valueB).ToString();
                    break;
                case "moltiplica":
                    txtBoxSchermo.Text = c.MoltiplicaNumeri(valueA, valueB).ToString();
                    break;
                case "dividi":
                    var risultato = c.DividiNumeri(valueA, valueB);
                    txtBoxSchermo.Text = (risultato == null) ? "Error!" : risultato.ToString();
                    break;

            }
        }

        private void itemExit_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }
    }
}
