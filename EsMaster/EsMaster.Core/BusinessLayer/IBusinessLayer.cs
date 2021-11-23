using EsMaster.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsMaster.Core.BusinessLayer
{
    public interface IBusinessLayer 
    {
        //visualizza tutti i corsi... sarà un
        public List<Corso> GetAllCorsi();

        public Esito AggiungiCorso(Corso c);
        public Esito ModificaCorso(string codice, string nuovoNome, string nuovaDescrizione);
        public Esito EliminaCorso(string codice);


        // metodi STUDENTI
        public List<Studente> GetAllStudenti();
        public Esito AggiungiStudente(string nome, string cognome, string email, string titoloStudio, DateTime dataNascita, string corsoCodice);
        public Esito ModificaStudente(int id, string email);
        public Esito EliminaStudente(int id);
        List<Studente> GetStudentiPerCorso(string codiceCorso, out Esito e);
    }
}
