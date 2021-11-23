using EsMaster.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsMaster.Core.InterfaceRepositories
{
    public interface IRepositoryStudenti : IRepository<Studente>
    {
        public Studente GetByID(int id);
        public List<Studente> GetByCodiceCorso(string codice);
        public bool CheckUnivocita(Studente s);
    }
}
