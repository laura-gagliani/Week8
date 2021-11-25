using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calcolatrice.Core
{
    public class Calculator
    {
        public double SommaNumeri(double v1, double v2)
        {
            return v1 + v2;
        }

        public double? DividiNumeri(double v1, double v2)
        {
            if (v2 == 0)
            {
                return null;
            }
            else
            {
                return v1 / v2;
            }

        }

        public double SottraiNumeri(double v1, double v2)
        {
            return v1 - v2;
        }

        public double MoltiplicaNumeri(double v1, double v2)
        {
            return v1 * v2;
        }

        public bool VerificaSeAMaggioreDiB(double a, double b)
        {
            if (a >= b)
            {
                return true;
            }
            else return false;
        }
    }
}
