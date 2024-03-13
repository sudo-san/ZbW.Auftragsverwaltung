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
        public int KundeID { get; set; }

        public int Auftragsnummer { get; set; }

        public DateTime Datum { get; set; }

        // Fremdschlüssel für die Beziehung
        public int KundenId { get; set; }

        // Navigation Property für One-to-Many-Beziehung
        public Kunde Kunde { get; set; }

        public Auftrag() 
        {
        
        }    
    }
}
