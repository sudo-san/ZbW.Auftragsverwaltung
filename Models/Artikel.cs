using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auftragsverwaltung.Models
{
    public class Artikel
    {
        [Key]
        public int ArtikelNr { get; set; }
        public string Bezeichnung { get; set; }
        public decimal Preis { get; set; }
        public int ArtikelgruppeID { get; set; }
        public Artikelgruppe Artikelgruppe { get; set; }

        // Konstruktor für Artikel
        public Artikel()
        {

        }

        // Braucht es das??
        //public Artikel(int artikelNr, string bezeichnung, decimal preis, Artikelgruppe artikelgruppe)
        //{
        //    ArtikelNr = artikelNr;
        //    Bezeichnung = bezeichnung;
        //    Preis = preis;
        //    Artikelgruppe = artikelgruppe;
        //}
    }
}
