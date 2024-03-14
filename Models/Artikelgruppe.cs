using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auftragsverwaltung.Models
{
    public class Artikelgruppe
    {
        [Key]
        public int ArtikelgruppeID { get; set; }

        public string Name { get; set; }

        public virtual ICollection<Artikel> Artikels { get; set; }

        public Artikelgruppe UebergeordneteGruppe { get; set; }

    }
}
