using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Auftragsverwaltung.Models
{
    public class Auftrag
    {
        [Key]
        public int Auftragsnummer { get; set; }

        public DateTime Datum { get; set; }

        public int KundenId { get; set; }

        public Kunde Kunde { get; set; }

        public int AdresseId { get; set; }

        public Adresse Adresse { get; set; }

        public ICollection<Auftragsposition> Auftragspositionen { get; set; }

        public Auftrag() 
        {
        
        }    
    }
}
