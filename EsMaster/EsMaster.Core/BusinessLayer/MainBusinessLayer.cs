using EsMaster.Core.Entities;
using EsMaster.Core.InterfaceRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsMaster.Core.BusinessLayer
{
    public class MainBusinessLayer : IBusinessLayer
    {
        //tutta la parte di CONTROLLI del programma mi va qua, nel business layer

        //mi dichiaro quali sono i repository che ho a disposizione
        private readonly IRepositoryCorsi corsiRepo;
        private readonly IRepositoryStudenti studentiRepo;

        public MainBusinessLayer(IRepositoryCorsi corsi, IRepositoryStudenti studenti)
        {
            corsiRepo = corsi;
            studentiRepo = studenti;
        }



        public Esito AggiungiCorso(Corso c)
        {
            //controllo: non devi far inserire corsi con lo stesso codice
            Corso corsoEsistente = corsiRepo.GetByCode(c.CorsoCodice);
            if (corsoEsistente.CorsoCodice == null)
            {
                corsiRepo.Add(c);
                return new Esito { Messaggio = "Corso aggiunto correttamente", isOk = true };
            }
            else
                return new Esito { Messaggio = "Errore. Impossibile aggiungere il corso: il suo codice è già in database", isOk = false };



        }

        public Esito AggiungiStudente(string nome, string cognome, string email, string titoloStudio, DateTime dataNascita, string corsoCodice)
        {
            Corso corsoEsistente = corsiRepo.GetByCode(corsoCodice);

            if (corsoEsistente != null)
            {
                Studente s = new Studente();
                s.Nome = nome;
                s.Cognome = cognome;
                s.Email = email;
                s.TitoloStudio = titoloStudio;
                s.DataDiNascita = dataNascita;
                s.CorsoCodice = corsoCodice;
                s.Corso = corsoEsistente;

                bool isUnique = studentiRepo.CheckUnivocita(s);

                if (isUnique)
                {
                    studentiRepo.Add(s);
                    return new Esito { Messaggio = "Studente correttamente inserito in elenco", isOk = true };
                }
                else
                    return new Esito { Messaggio = "Attenzione. Studente già in elenco! Inserimento annullato", isOk = false };
                
            }

            return new Esito { Messaggio = "Attenzione! Il codice corso inserito per questo studente è inesistente. Inserimento annullato", isOk = false };

        }

        public Esito EliminaCorso(string codice)
        {
            Corso corsoEsistente = corsiRepo.GetByCode(codice);
            if (corsoEsistente != null)
            {
                List<Studente> l = studentiRepo.GetByCodiceCorso(corsoEsistente.CorsoCodice);

                if (l.Count == 0)
                {
                    corsiRepo.Delete(corsoEsistente);
                    return new Esito { Messaggio = "Corso correttamente rimosso", isOk = true };
                }
                else
                    return new Esito { Messaggio = "Impossibile eliminare corso! Numero di iscritti diverso da 0", isOk = false };


            }

            else
            {
                return new Esito { Messaggio = "Nessun corso corrispondente al codice inserito", isOk = false };
            }
        }

        public Esito EliminaStudente(int id)
        {
            Studente s = studentiRepo.GetByID(id);
            if (s != null)
            {
                studentiRepo.Delete(s);
                return new Esito { Messaggio = "Dati studente correttamente rimossi", isOk = true };

            }

            else
            {
                return new Esito { Messaggio = "Nessuno studente corrispondente all'ID inserito", isOk = false };
            }
        }

        public List<Corso> GetAllCorsi()
        {
            return corsiRepo.GetAll();
        }

        public List<Studente> GetAllStudenti()
        {
            return studentiRepo.GetAll();
        }

        public List<Studente> GetStudentiPerCorso(string codiceCorso, out Esito e)
        {
            Corso c = corsiRepo.GetByCode(codiceCorso);
            if (c != null)
            {
                e = new Esito() { isOk = true };
                return studentiRepo.GetByCodiceCorso(codiceCorso);
            }
            else
            {
                e = new Esito() { Messaggio = "Codice corso richiesto non in elenco!", isOk = false };
                return null;
            }

        }

        public Esito ModificaCorso(string codice, string nuovoNome, string nuovaDescrizione)
        {
            Corso corsoEsistente = corsiRepo.GetByCode(codice);
            if (corsoEsistente != null)
            {
                Corso corsoDaAggiornare = new Corso();

                corsoDaAggiornare.CorsoCodice = corsoEsistente.CorsoCodice;
                corsoDaAggiornare.Nome = nuovoNome;
                corsoDaAggiornare.Descrizione = nuovaDescrizione;

                corsiRepo.Update(corsoDaAggiornare);
                return new Esito { Messaggio = "Corso correttamente aggiornato", isOk = true };

            }

            else
            {
                return new Esito { Messaggio = "Nessun corso corrispondente al codice inserito", isOk = false };
            }


        }

        public Esito ModificaStudente(int id, string email)
        {
            //cerca per id
            // if found - edit email
            Studente studEsistente = studentiRepo.GetByID(id);
            if (studEsistente != null)
            {
                Studente studNuovo = studEsistente;
                studNuovo.Email = email;

                studentiRepo.Update(studNuovo);
                return new Esito { Messaggio = "E-mail aggiornata correttamente", isOk = true };
            }
            return new Esito { Messaggio = "L'ID studente inserito non è in elenco. Modifica annullata", isOk = false };

        }
    }
}
