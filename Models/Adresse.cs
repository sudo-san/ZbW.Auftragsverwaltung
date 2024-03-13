using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media.Media3D;

namespace Auftragsverwaltung.Models
{
    public class Adresse
    {
        public int AdresseID { get; set; }

        public string? Strasse { get; set; }

        public string? PLZ { get; set; }

        public string? Ort { get; set; }

        public Adresse() 
        {
        
        }
    }
}
