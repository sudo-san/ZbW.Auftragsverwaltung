using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Auftragsverwaltung.Views
{
    /// <summary>
    /// Interaction logic for ArtikelgruppeWindow.xaml
    /// </summary>
    public partial class ArtikelgruppeWindow : Window
    {
        public ArtikelgruppeWindow()
        {
            InitializeComponent();

            ArtikelGruppeSuchen.TextChanged += ArtikelGruppeSuchen_TextChanged;
            SucheArtikelGruppe(string.Empty);
        }

        private void ArtikelGruppeWindow_Loaded(object sender, RoutedEventArgs e)
        {
            
            LadenArtikelGruppen();
        }
        private void LadenArtikelGruppen()
        {
            using (var context = new AuftragsverwaltungDbContext())
            {
                
                var artikelGruppen = context.Artikelgruppe.ToList();

                
                foreach (var artikelGruppe in artikelGruppen)
                {
                    ArtikelGruppeListe.Items.Add(new { Bezeichnung = artikelGruppe.Name });
                }
            }
        }

        private void ArtikelGruppeSuchen_TextChanged(object sender, TextChangedEventArgs e)
        {
            string suchbegriff = ArtikelGruppeSuchen.Text;
            SucheArtikelGruppe(suchbegriff);
        }

        private void ArtikelGruppeHinzufuegen_Click(object sender, RoutedEventArgs e)
        {
            ArtikelGruppeHinzufuegenWindow artikelGruppeHinzufuegen = new ArtikelGruppeHinzufuegenWindow(this);
            artikelGruppeHinzufuegen.Owner = this;
            artikelGruppeHinzufuegen.ShowDialog();
        }

        //private void ArtikelGruppeEditieren_Click(string bezeichnung)
        //{
        //    using (var context = new AuftragsverwaltungDbContext())
        //    {
                
        //        var artikelGruppen = context.Artikelgruppe.ToList();
                                
        //        foreach (var artikelGruppe in artikelGruppen)
        //        {
        //            ArtikelGruppeListe.Items.Add(new { Bezeichnung = bezeichnung});
        //        }
        //    }
        //}

        private void ArtikelGruppeLoeschen_Click(object sender, RoutedEventArgs e)
        {
            if (ArtikelGruppeListe.SelectedItems.Count > 0)
            {
                MessageBoxResult result = MessageBox.Show("Möchten Sie die ausgewählten Artikelgruppen wirklich löschen?", "Artikelgruppe löschen", MessageBoxButton.YesNo, MessageBoxImage.Warning);
                if (result == MessageBoxResult.Yes)
                {
                    using (var context = new AuftragsverwaltungDbContext())
                    {
                        foreach (var selectedItem in ArtikelGruppeListe.SelectedItems)
                        {
                            dynamic selectedArtikelGruppe = selectedItem;
                            string bezeichnung = selectedArtikelGruppe.Bezeichnung;

                            var artikelGruppe = context.Artikelgruppe.FirstOrDefault(k => k.Name == bezeichnung);
                            if (artikelGruppe != null)
                            {
                                context.Artikelgruppe.Remove(artikelGruppe);
                            }
                        }

                        context.SaveChanges();
                    }

                    SucheArtikelGruppe(string.Empty);
                }
            }
            else
            {
                MessageBox.Show("Bitte wählen Sie mindestens eine Artikelgruppe aus, den Sie löschen möchten.");
            }
        }

        public void SucheArtikelGruppe(string suchbegriff)
        {
            
            ArtikelGruppeListe.Items.Clear();

            using (var context = new AuftragsverwaltungDbContext())
            {
                
                var artikelGruppe = context.Artikelgruppe
                                    .Where(k => k.Name.Contains(suchbegriff))
                                    .ToList();

                
                foreach (var gruppe in artikelGruppe)
                {
                    //ArtikelGruppeListe.Items.Add(new { Bezeichnung = artikelGruppe.Name });
                }
            }
        }
    }
}
