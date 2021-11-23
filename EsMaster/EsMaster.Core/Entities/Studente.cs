using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsMaster.Core.Entities
{
    public class Studente : Persona
    {
        public string TitoloStudio { get; set; }
        public DateTime DataDiNascita { get; set; }

        public string CorsoCodice { get; set; }
        public Corso Corso { get; set; }

        public override string ToString()
        {
            return $"Id: {ID}\tNome: {Nome} {Cognome}\tData di nascita: {DataDiNascita.ToShortDateString()}\tAltre info: {Email} - {TitoloStudio}";
        }
    }
}
