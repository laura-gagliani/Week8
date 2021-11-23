using EsMaster.Core.BusinessLayer;
using EsMaster.Core.Entities;
using EsMaster.RepositoryADO;
using EsMaster.RepositoryMock;
using System;
using System.Collections.Generic;

namespace EsMaster.ConsoleApp
{
    class Program
    {
        //private static readonly IBusinessLayer bl = new MainBusinessLayer(new RepositoryCorsiMock(), new RepositoryStudentiMock());
        private static readonly IBusinessLayer bl = new MainBusinessLayer(new RepositoryCorsiADO(), new RepositoryStudentiADO());


        static void Main(string[] args)
        {
            //qua ci starà l'interfaccia utente (il menu)
            // le classi dovranno andare nel CORE

            Console.WriteLine("Benvenuto al Master");

            bool quit = false;
            do
            {

                int choice = SchermoMenu();
                quit = SelezioneSwitchCase(choice);
            } while (!quit);


        }

        private static bool SelezioneSwitchCase(int choice)
        {
            switch (choice)
            {
                case 1:
                    VisualizzaCorsi();
                    break;
                case 2:
                    InserisciCorso();
                    break;
                case 3:
                    ModificaCorso();
                    break;
                case 4:
                    EliminaCorso();
                    break;
                case 5:
                    VisualizzaStudenti();
                    break;
                case 6:
                    VisualizzaStudentiPerCorso();
                    break;
                case 7:
                    InserisciStudente();
                    break;
                case 8:
                    ModificaDatiStudente();
                    break;
                case 9:
                    EliminaDatiStudente();
                    break;


                case 0:
                    return true;

            }
            return false;
        }

        private static void VisualizzaStudentiPerCorso()
        {
            Console.WriteLine("I corsi disponibili sono:");
            VisualizzaCorsi();
            Console.WriteLine("Inserisci il codice del corso per il quale vuoi visualizzare gli studenti:");
            string codiceCorso = Console.ReadLine();

            List<Studente> studentiCorso = bl.GetStudentiPerCorso(codiceCorso, out Esito e);
            if (e.isOk)
            {
                if (studentiCorso.Count == 0)
                {
                    Console.WriteLine("\nNessuno studente iscritto a questo corso!");
                }
                else
                {
                    foreach (var item in studentiCorso)
                    {
                        Console.WriteLine(item.ToString());
                    }
                }
            }
            else
            {
                Console.WriteLine(e.Messaggio);
            }


        }

        private static void EliminaDatiStudente()
        {
            Console.WriteLine("Gli studenti attualmente in elenco sono:");
            VisualizzaStudenti();
            Console.WriteLine("\nInserisci l'ID dello studente di cui vuoi eliminare i dati:");
            int id = GetInt();

            Esito esito = bl.EliminaStudente(id);
            Console.WriteLine(esito.Messaggio);
        }

        private static void ModificaDatiStudente()
        {
            Console.WriteLine("\nInserisci l'ID dello studente cercato: ");
            int id = GetInt();
            Console.WriteLine("\nInserisci la nuova e-mail: ");
            string nuovaEmail = Console.ReadLine();

            Esito esito = bl.ModificaStudente(id, nuovaEmail);
            Console.WriteLine(esito.Messaggio);

        }

        private static int GetInt()
        {
            int id;
            bool parse;

            do
            {
                parse = int.TryParse(Console.ReadLine(), out id);
            } while (!parse);

            return id;
        }

        private static void InserisciStudente()
        {
            Console.WriteLine("\n****** Inserimento Dati ******");
            Console.WriteLine("Nome:");
            string nome = Console.ReadLine();
            Console.WriteLine("Cognome:");
            string cognome = Console.ReadLine();
            Console.WriteLine("E-Mail:");
            string email = Console.ReadLine();
            Console.WriteLine("Titolo di studio:");
            string titoloStudio = Console.ReadLine();
            Console.WriteLine("Data di nascita:");
            DateTime dataNascita = GetDateTime();
            Console.WriteLine("Codice del corso:");
            string codiceCorso = Console.ReadLine();
            Console.WriteLine("\n****** ******** ******");

            Esito esito = bl.AggiungiStudente(nome, cognome, email, titoloStudio, dataNascita, codiceCorso);
            Console.WriteLine(esito.Messaggio);


        }

        private static DateTime GetDateTime()
        {
            DateTime dt = new DateTime();
            bool parse;

            do
            {
                parse = DateTime.TryParse(Console.ReadLine(), out dt);
            } while (!parse);

            return dt;
        }

        private static void VisualizzaStudenti()
        {
            Console.WriteLine("\nGli studenti presenti in elenco sono:");
            List<Studente> studenti = bl.GetAllStudenti();
            if (studenti.Count == 0)
            {
                Console.WriteLine("\nNessuno studente attualmente in elenco!");
            }
            else
            {
                foreach (var item in studenti)
                {
                    Console.WriteLine(item.ToString());
                }
            }


        }

        private static void EliminaCorso()
        {
            Console.WriteLine("I corsi attualmente in elenco sono:");
            VisualizzaCorsi();
            Console.WriteLine("\nInserisci il codice del corso che vuoi eliminare:");
            string codice = Console.ReadLine();

            Esito esito = bl.EliminaCorso(codice);
            Console.WriteLine(esito.Messaggio);
        }

        private static void ModificaCorso()
        {
            Console.WriteLine("I corsi attualmente in elenco sono:");
            VisualizzaCorsi();
            Console.WriteLine("\nInserisci il codice del corso che vuoi modificare:");
            string codice = Console.ReadLine();
            Console.WriteLine("\nInserisci il nuovo nome del corso:");
            string nuovoNome = Console.ReadLine();
            Console.WriteLine("\nInserisci la nuova descrizione del corso:");
            string nuovaDescrizione = Console.ReadLine();

            Esito esito = bl.ModificaCorso(codice, nuovoNome, nuovaDescrizione);
            Console.WriteLine(esito.Messaggio);

        }

        private static void InserisciCorso()
        {
            Corso nuovoCorso = new Corso();

            Console.WriteLine("Codice nuovo corso:");
            nuovoCorso.CorsoCodice = Console.ReadLine();
            Console.WriteLine("Nome nuovo corso:");
            nuovoCorso.Nome = Console.ReadLine();
            Console.WriteLine("Descrizione nuovo corso:");
            nuovoCorso.Descrizione = Console.ReadLine();

            Esito esito = bl.AggiungiCorso(nuovoCorso);
            Console.WriteLine(esito.Messaggio);
        }

        private static void VisualizzaCorsi()
        {
            List<Corso> corsi = bl.GetAllCorsi();
            foreach (var item in corsi)
            {
                Console.WriteLine(item.ToString());
            }
        }

        private static int SchermoMenu()
        {
            Console.WriteLine("----------------------  MENU  ----------------------");

            Console.WriteLine("\nFunzionalità CORSI");
            Console.WriteLine("[1] Visualizza corsi");
            Console.WriteLine("[2] Inserisci nuovo corso");
            Console.WriteLine("[3] Modifica corso");
            Console.WriteLine("[4] Elimina corso");

            Console.WriteLine("\nFunzionalità STUDENTI");
            Console.WriteLine("[5] Visualizza studenti");
            Console.WriteLine("[6] Visualizza studenti per corso");
            Console.WriteLine("[7] Inserisci nuovo studente");
            Console.WriteLine("[8] Modifica email studente");
            Console.WriteLine("[9] Elimina dati studente");
            Console.WriteLine("\n[0] Chiudi");

            return GetMenuInt(0, 9);


        }

        private static int GetMenuInt(int min, int max)
        {
            bool isInt;
            int num;
            do
            {
                isInt = int.TryParse(Console.ReadLine(), out num);

            } while (!isInt || num < min || num > max);

            return num;
        }
    }
}
