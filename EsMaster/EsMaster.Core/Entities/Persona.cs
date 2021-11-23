using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsMaster.Core.Entities
{
    public abstract class Persona //siccome ora bisogna comunicare TRA PROGETTI è necessario il public
    {
        public int ID { get; set; }
        public string Nome { get; set; }
        public string Cognome { get; set; }
        public string Email { get; set; }

    }
}
