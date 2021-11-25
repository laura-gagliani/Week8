using Calcolatrice.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calcolatrice.WinForm
{
    public partial class CalculatorForm : Form
    {
        double valueA;
        double valueB;
        string operation;
        Calculator c = new Calculator();

        public CalculatorForm()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            textValue.Text += btn1.Text;
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            textValue.Text += btn2.Text;
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            textValue.Text += btn0.Text;
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            textValue.Text += btn3.Text;
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            textValue.Text += btn4.Text;
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            textValue.Text += btn5.Text;
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            textValue.Text += btn6.Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            textValue.Text += btn7.Text;
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            textValue.Text += btn8.Text;
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            textValue.Text += btn9.Text;
        }

        private void btnVirgola_Click(object sender, EventArgs e)
        {
            textValue.Text += btnVirgola.Text;
        }

        private void btnCanc_Click(object sender, EventArgs e)
        {
            textValue.Clear();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SetOperation(textValue.Text, btnAdd.Tag.ToString());

        }

        private void SetOperation(string contentValue, string operationToDo)
        {
            valueA = double.Parse(contentValue);
            operation = operationToDo;
            textValue.Clear();
        }

        private void btnSottr_Click(object sender, EventArgs e)
        {
            SetOperation(textValue.Text, "sottrai");
        }

        private void btnMolt_Click(object sender, EventArgs e)
        {
            SetOperation(textValue.Text, "moltiplica");
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            SetOperation(textValue.Text, "dividi");
        }

        private void btnEquals_Click(object sender, EventArgs e)
        {
            valueB = string.IsNullOrEmpty(textValue.Text) ? 0 : double.Parse(textValue.Text);
            
            switch (operation)
            {
                case "somma":
                    textValue.Text = c.SommaNumeri(valueA, valueB).ToString();
                    break;
                case "sottrai":
                    textValue.Text = c.SottraiNumeri(valueA, valueB).ToString();
                    break;
                case "moltiplica":
                    textValue.Text = c.MoltiplicaNumeri(valueA, valueB).ToString();
                    break;
                case "dividi":                    
                    var risultato = c.DividiNumeri(valueA, valueB);
                    textValue.Text = (risultato == null) ? "Error!" : risultato.ToString();                                       
                    break;

            }
            
        }
    }
}
