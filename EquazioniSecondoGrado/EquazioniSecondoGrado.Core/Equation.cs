using System;

namespace EquazioniSecondoGrado.Core
{
    public class Equation
    {
        public double[] RisolviEquazioneDiSecondoGrado(double a, double b, double c)
        {
            double delta = Math.Pow(b, 2) - (4 * a * c);
            double[] result;

            if (delta > 0)
            {
                result = new double[2];
                result[0] = (-b - Math.Sqrt(delta)) / (2 * a);
                result[1] = (-b + Math.Sqrt(delta)) / (2 * a);
                return result;
            }

            if (delta == 0)
            {
                result = new double[1];
                result[0] = (-b) / (2 * a);
                return result;                
            }

            return null;
            
        }
    }
}
