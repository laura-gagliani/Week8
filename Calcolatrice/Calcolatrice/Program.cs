using Calcolatrice.Core;
using System;

namespace Calcolatrice
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("****** App Calcolatrice ******");
            bool quit = false;
            double a;
            double b;

            do
            {
                Console.WriteLine("\nOperazioni:");
                Console.WriteLine("[1] Addizione");
                Console.WriteLine("[2] Sottrazione");
                Console.WriteLine("[3] Moltiplicazione");
                Console.WriteLine("[4] Divisione");
                Console.WriteLine("[5] Verifica maggioranza");
                Console.WriteLine("[0] Esci");

                int choice = GetMenuChoice(0, 5);
                Calculator c = new Calculator();
                double result;

                switch (choice)
                {
                    case 0:
                        quit = true;
                        break;
                    case 1:
                        Console.WriteLine("Inserisci i valori richiesti per l'operazione:");
                        a = GetDouble();
                        b = GetDouble();
                        result = c.SommaNumeri(a, b);
                        Console.WriteLine($"La somma tra {a} e {b} è {result}");
                        break;
                    case 2:
                        Console.WriteLine("Inserisci i valori richiesti per l'operazione:");
                        a = GetDouble();
                        b = GetDouble();
                        result = c.SottraiNumeri(a, b);
                        Console.WriteLine($"La differenza tra {a} e {b} è {result}");
                        break;
                    case 3:
                        Console.WriteLine("Inserisci i valori richiesti per l'operazione:");
                        a = GetDouble();
                        b = GetDouble();
                        result = c.MoltiplicaNumeri(a, b);
                        Console.WriteLine($"Il prodotto tra {a} e {b} è {result}");
                        break;
                    case 4:
                        Console.WriteLine("Inserisci i valori richiesti per l'operazione:");
                        a = GetDouble();
                        b = GetDouble();
                        double? rapporto = c.DividiNumeri(a, b);
                        if (rapporto != null)
                        {
                            Console.WriteLine($"Il quoziente tra {a} e {b} è {rapporto}");

                        }
                        else
                            Console.WriteLine($"Impossibile dividere per 0!");
                        break;
                    case 5:
                        Console.WriteLine("Inserisci i valori richiesti per l'operazione:");
                        a = GetDouble();
                        b = GetDouble();
                        bool isBigger = c.VerificaSeAMaggioreDiB(a, b);
                        if (isBigger)
                            Console.WriteLine($"{a} è maggiore o uguale di {b}");
                        else
                            Console.WriteLine($"{a} è minore di {b}");
                        break;
                }

            } while (!quit);

        }

        private static int GetMenuChoice(int min, int max)
        {
            int choice;
            bool parse;
            do
            {
                parse = int.TryParse(Console.ReadLine(), out choice);
            } while (!(parse && choice >= min && choice <= max));

            return choice;
        }

        private static double GetDouble()
        {
            double d;
            bool parse;

            do
            {
                parse = double.TryParse(Console.ReadLine(), out d);
            } while (!parse);
            return d;
        }
    }
}
