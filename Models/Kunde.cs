using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auftragsverwaltung.Models
{
    public class Kunde
    {

        [Key]
        public int KundenNr { get; set; }

        public string? Vorname { get; set; }

        public string? Nachname { get; set; }

        public string? Mail { get; set; }

        public string? Website { get; set; }

        public string? Passwort { get; set; }

        public ICollection<Auftrag> Auftraege { get; set; }

        public Kunde() 
        {

        }

    }
}
