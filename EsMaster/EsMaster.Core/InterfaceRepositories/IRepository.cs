using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsMaster.Core.InterfaceRepositories
{
    public interface IRepository<T>
    {
        // le interfacce comuni contengono solitamente le operazioni CRUD
        public List<T> GetAll();

        // il metodo può rendere un bool o T per dire se l'oggetto è stato inserito correttamente o no
        public T Add(T item);
        public T Update(T item);
        public bool Delete(T item);

    }
}
