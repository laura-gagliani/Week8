using EquazioniSecondoGrado.Core;
using System;

namespace EquazioniSecondoGrado
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** Equazioni di Secondo Grado ****");

            Console.WriteLine("\nData l'equazione ax^2+bx+c=0...");
            Console.Write("Inserisci il coefficiente a:");
            double a = GetDouble();
            Console.Write("Inserisci il coefficiente b:");
            double b = GetDouble();
            Console.Write("Inserisci il coefficiente c:");
            double c = GetDouble();

            Console.WriteLine($"\nL'equazione inserita è {a}x^2 + {b}x + {c} = 0");
            Equation e = new Equation();
            double[] risultato = e.RisolviEquazioneDiSecondoGrado(a, b, c);

            if (risultato == null)
            {
                Console.WriteLine("\nL'equazione non ha soluzioni!");
            }
            else if (risultato.Length == 1)
            {
                Console.WriteLine($"\nSoluzioni coincidenti: x1 = x2 = {risultato[0]}");
            }
            else if (risultato.Length == 2)
            {
                Console.WriteLine($"\nSoluzioni distinte: x1 = {risultato[0]}\tx2 = {risultato[1]}");
            }


            //TODO interfaccia utente che prende (a b c) e rende le soluzioni
        }

        private static double GetDouble()
        {
            bool parse;
            double valore;
            do
            {
                parse = double.TryParse(Console.ReadLine(), out valore);
            } while (!parse);
            return valore;
        }
    }
}
