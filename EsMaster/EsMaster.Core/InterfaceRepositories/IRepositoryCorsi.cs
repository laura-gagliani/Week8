using EsMaster.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsMaster.Core.InterfaceRepositories
{
    public interface IRepositoryCorsi : IRepository<Corso>
    {
        public Corso GetByCode(string codice);
    }
}
