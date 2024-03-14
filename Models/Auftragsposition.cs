using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auftragsverwaltung.Models
{
    public class Auftragsposition
    {
        [Key]
        public int AuftragspositionID { get; set; }

        public int ArtikelID { get; set; }

        public int Position { get; set; }

        public int Anzahl { get; set; }

        public decimal Preis { get; set; }

        public int Auftragsnummer { get; set; }

        public Auftrag Auftrag { get; set; }

        public Auftragsposition() 
        {
        
        }   
    }
}
