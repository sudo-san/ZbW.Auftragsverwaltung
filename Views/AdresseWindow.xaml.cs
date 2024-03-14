using Auftragsverwaltung.Models;
using Auftragsverwaltung.Views;
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

namespace Auftragsverwaltung
{
    /// <summary>
    /// Interaction logic for AdresseWindow.xaml
    /// </summary>
    public partial class AdresseWindow : Window
    {
        public AdresseWindow()
        {
            InitializeComponent();
            AdresseSuchen.TextChanged += AdresseSuchen_TextChanged;
            SucheAdresse(string.Empty);
        }

        private void AdresseHinzufuegen_Click(object sender, RoutedEventArgs e)
        {
            AdresseHinzufuegenWindow adresseHinzufuegen = new AdresseHinzufuegenWindow(this);
            adresseHinzufuegen.Owner = this;
            adresseHinzufuegen.ShowDialog();

        }
        private void AdresseWindow_Loaded(object sender, RoutedEventArgs e)
        {
            // Lade die Adressen beim Laden des Fensters
            LadenAdressen();
        }
        private void LadenAdressen()
        {
            using (var context = new AuftragsverwaltungDbContext())
            {
                // Lade alle Adressen aus der Datenbank
                var adressen = context.Adresse.ToList();

                // Füge jede Adresse zur Adressliste hinzu
                foreach (var adresse in adressen)
                {
                    AdresseListe.Items.Add(new { Strasse = adresse.Strasse, Ort = adresse.Ort, PLZ = adresse.PLZ });
                }
            }
        }

        private void AdresseSuchen_TextChanged(object sender, TextChangedEventArgs e)
        {
            string suchbegriff = AdresseSuchen.Text;
            SucheAdresse(suchbegriff);
        }
        public void SucheAdresse(string suchbegriff)
        {
            // Leere die vorhandenen Elemente in der Adressliste
            AdresseListe.Items.Clear();

            using (var context = new AuftragsverwaltungDbContext())
            {
                // Suche nach Adressen mit übereinstimmungen
                var adressen = context.Adresse
                                    .Where(k => k.Strasse.Contains(suchbegriff) || k.Ort.Contains(suchbegriff) || k.PLZ.Contains(suchbegriff))
                                    .ToList();

                // Füge jeden gefundene Adresse zur Adressenliste hinzu
                foreach (var adresse in adressen)
                {
                    AdresseListe.Items.Add(new { Strasse = adresse.Strasse, Ort = adresse.Ort, PLZ = adresse.PLZ });
                }
            }
        }

        private void AdresseEditieren_Click(object sender, RoutedEventArgs e)
        {
            // Sicherstellen das Adresse selektiert wurde
            if (AdresseListe.SelectedItem != null)
            {
                // Abrufen der ausgewählten Daten der Adresse
                dynamic selectedAdresse = AdresseListe.SelectedItem;
                string strasse = selectedAdresse.Strasse;
                string plz = selectedAdresse.PLZ;
                string ort = selectedAdresse.Ort;

                // Öffnen des AdresseHinzufuegenWindow mit den ausgewählten Daten
                AdresseHinzufuegenWindow adresseHinzufuegen = new AdresseHinzufuegenWindow(this, strasse, plz, ort);
                adresseHinzufuegen.Owner = this;
                adresseHinzufuegen.ShowDialog();
            }
            else
            {
                MessageBox.Show("Bitte wählen Sie eine Adresse aus, die Sie bearbeiten möchten.");
            }
        }

        private void AdresseLoeschen_Click(object sender, RoutedEventArgs e)
        {
            if (AdresseListe.SelectedItems.Count > 0)
            {
                MessageBoxResult result = MessageBox.Show("Möchten Sie die ausgewählte Adresse wirklich löschen?", "Adresse löschen", MessageBoxButton.YesNo, MessageBoxImage.Warning);
                if (result == MessageBoxResult.Yes)
                {
                    using (var context = new AuftragsverwaltungDbContext())
                    {
                        foreach (var selectedItem in AdresseListe.SelectedItems)
                        {
                            dynamic selectedAdresse = selectedItem;
                            string strasse = selectedAdresse.Strasse;
                            string plz = selectedAdresse.PLZ;
                            string ort= selectedAdresse.Ort;

                            var adresse = context.Adresse.FirstOrDefault(k => k.Strasse == strasse && k.PLZ == plz && k.Ort == ort);
                            if (adresse != null)
                            {
                                context.Adresse.Remove(adresse);
                            }
                        }

                        context.SaveChanges();
                    }

                    // Aktualisiere die Adressenliste nach dem Löschen
                    SucheAdresse(string.Empty); // Suche mit leerem Suchbegriff, um alle Adressen zu laden
                }
            }
            else
            {
                MessageBox.Show("Bitte wählen Sie mindestens eine Adresse aus, den Sie löschen möchten.");
            }
        }
    }
    
}
