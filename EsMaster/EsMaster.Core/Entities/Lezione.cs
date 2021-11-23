using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EsMaster.Core.Entities
{
    public class Lezione
    {
        public int LezioneID { get; set; }
        public DateTime DataOraInizio { get; set; }
        public int Durata { get; set; }
        public string Aula { get; set; }

        public int DocenteID { get; set; } //FK
        public Docente Docente { get; set; } //NAV PROP

        public string CorsoCodice { get; set; }
        public Corso Corso { get; set; }


        public override string ToString()
        {
            return $"Lezione: {LezioneID}\tInizio: {DataOraInizio}\tAula: {Aula}\tDurata: {Durata} giorni";
        }
    }
}
