using EquazioniSecondoGrado.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EquazioniSecondoGrado.WinForm
{
    public partial class EquationForm : Form
    {
        double a;
        double b;
        double c;
        Equation eq = new Equation();

        public EquationForm()
        {
            InitializeComponent();
        }

        private void btnCalcola_Click(object sender, EventArgs e)
        {
            a = string.IsNullOrEmpty(coeffA.Text)? 0: double.Parse(coeffA.Text);
            b = string.IsNullOrEmpty(coeffB.Text)? 0: double.Parse(coeffB.Text);
            c = string.IsNullOrEmpty(coeffC.Text)? 0: double.Parse(coeffC.Text);
            
            coeffA.Clear();
            coeffB.Clear();
            coeffC.Clear();
            textBoxEquazione.Text = $"Equazione: {a}x² + {b}x + {c} = 0";
            double[] res = eq.RisolviEquazioneDiSecondoGrado(a, b, c);

            if (res == null)
            {
                textBoxSoluzioni.Text = "L'equazione non ha soluzioni!";
                
            }
            else if (res.Length == 1)
            {
                textBoxSoluzioni.Text = $"Soluzioni coincidenti: x₁ = x₂ = {Math.Round(res[0], 2)}";
            }
            else if (res.Length == 2)
            {
                textBoxSoluzioni.Text = $"\nSoluzioni distinte: x₁ = {Math.Round(res[0],2)}\tx₂ = {Math.Round(res[1],2)}";
            }
        }

    } 
}
