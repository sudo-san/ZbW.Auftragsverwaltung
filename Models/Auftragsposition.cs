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
        public int AuftragspositionID { get; set; }

        public int ArtikelID { get; set; }

        public int Position { get; set; }

        public int Anzahl { get; set; }

        public Auftragsposition() 
        {
        
        }   
    }
}
