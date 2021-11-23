using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsMaster.Core.Entities
{
    public class Docente : Persona
    {
        public string NumeroTelefono { get; set; }

        public List<Lezione> Lezioni { get; set; } = new List<Lezione>(); // inizializziamo a una lista vuota (costruttore vuoto)


        public override string ToString()
        {
            return $"Id: {ID}\tNome: {Nome} {Cognome}\tAltre info: {Email} - {NumeroTelefono}";
            
        }
    }
}
