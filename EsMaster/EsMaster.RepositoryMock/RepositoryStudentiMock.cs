using EsMaster.Core.Entities;
using EsMaster.Core.InterfaceRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsMaster.RepositoryMock
{
    public class RepositoryStudentiMock : IRepositoryStudenti
    {
        public static List<Studente> Studenti = new List<Studente>()
        {

        };

        public static int Id { get; set; } = 1;



        public Studente Add(Studente item)
        {
            item.ID = Id;
            Id++;

            Studenti.Add(item);
            return item;
            
        }

        public bool CheckUnivocita(Studente s)
        {
            throw new NotImplementedException();
        }

        public bool Delete(Studente item)
        {
            Studenti.Remove(item);
            return true;
        }

        public List<Studente> GetAll()
        {
            return Studenti;
        }

        public List<Studente> GetByCodiceCorso(string codice)
        {
            List<Studente> studentiCorso = new List<Studente>();
            foreach (Studente s in Studenti)
            {
                if (s.CorsoCodice == codice)
                {
                    studentiCorso.Add(s);
                }
            }
            return studentiCorso;
        }

        public Studente GetByID(int id)
        {
            foreach (Studente s in Studenti)
            {
                if (s.ID == id)
                {
                    return s;
                }
            }
            return null;
        }

        public Studente Update(Studente item)
        {
            foreach (Studente s in Studenti)
            {
                if (s.ID == item.ID)
                {
                    s.Email = item.Email;
                    return s;
                }
            }
            return null;
        }
    }
}
