using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
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
using Auftragsverwaltung.Models;
using Auftragsverwaltung.Views;

namespace Auftragsverwaltung
{
    /// <summary>
    /// Interaction logic for KundeWindow.xaml
    /// </summary>
    public partial class KundeWindow : Window
    {
        public KundeWindow()
        {
            InitializeComponent();

            KundeSuchen.TextChanged += KundeSuchen_TextChanged;
            SucheKunde(string.Empty);

        }

        private void KundeWindow_Loaded(object sender, RoutedEventArgs e)
        {
            // Lade die Kunden beim Laden des Fensters
            LadenKunden();
        }
        private void LadenKunden()
        {
            using (var context = new AuftragsverwaltungDbContext())
            {
                // Lade alle Kunden aus der Datenbank
                var kunden = context.Kunde.ToList();

                // Füge jeden Kunden zur Kundenliste hinzu
                foreach (var kunde in kunden)
                {
                    KundeListe.Items.Add(new { Vorname = kunde.Vorname, Nachname = kunde.Nachname, Mail = kunde.Mail, Website = kunde.Website, Passwort = kunde.Passwort });
                }
            }
        }

        private void KundeHinzufuegen(object sender, RoutedEventArgs e)
        {
            KundeHinzufuegenWindow kundeHinzufuegen = new KundeHinzufuegenWindow(this);
            kundeHinzufuegen.Owner = this;
            kundeHinzufuegen.ShowDialog();
        }

        public void KundeHinzufuegenButton(string vorname, string nachname, string mail, string website, string passwort)
        {
            using (var context = new AuftragsverwaltungDbContext())
            {
                // Lade alle Kunden aus der Datenbank
                var kunden = context.Kunde.ToList();

                // Füge jeden Kunden zur Kundenliste hinzu
                foreach (var kunde in kunden)
                {
                    KundeListe.Items.Add(new { Vorname = vorname, Nachname = nachname, Mail = mail, Website = website, Passwort = passwort });
                }
            }
        }

        private void KundeSuchen_TextChanged(object sender, TextChangedEventArgs e)
        {
            string suchbegriff = KundeSuchen.Text;
            SucheKunde(suchbegriff);
        }

        public void SucheKunde(string suchbegriff)
        {
            // Leere die vorhandenen Elemente in der Kundenliste
            KundeListe.Items.Clear();

            using (var context = new AuftragsverwaltungDbContext())
            {
                // Suche nach Kunden mit übereinstimmendem Vorname oder Nachname
                var kunden = context.Kunde
                                    .Where(k => k.Vorname.Contains(suchbegriff) || k.Nachname.Contains(suchbegriff) || k.Mail.Contains(suchbegriff) || k.Website.Contains(suchbegriff))
                                    .ToList();

                // Füge jeden gefundenen Kunden zur Kundenliste hinzu
                foreach (var kunde in kunden)
                {
                    KundeListe.Items.Add(new { Vorname = kunde.Vorname, Nachname = kunde.Nachname, Mail = kunde.Mail, Website = kunde.Website });
                }
            }
        }

        private void KundeEditieren_Click(object sender, RoutedEventArgs e)
        {
            if (KundeListe.SelectedItem != null)
            {
                dynamic selectedKunde = KundeListe.SelectedItem;
                string vorname = selectedKunde.Vorname;
                string nachname = selectedKunde.Nachname;

                using (var context = new AuftragsverwaltungDbContext())
                {
                    var kunde = context.Kunde.FirstOrDefault(k => k.Vorname == vorname && k.Nachname == nachname);
                    if (kunde != null)
                    {
                        string mail = kunde.Mail; // Mail vom ausgewählten Kunden abrufen
                        string website = kunde.Website; // Website vom ausgewählten Kunden abrufen
                        string passwort = kunde.Passwort; // Passwort vom ausgewählten Kunden abrufen

                        // Öffnen des KundeHinzufuegenWindow mit den ausgewählten Daten
                        KundeHinzufuegenWindow kundeHinzufuegen = new KundeHinzufuegenWindow(this, vorname, nachname, mail, website, passwort);
                        kundeHinzufuegen.Owner = this;
                        kundeHinzufuegen.ShowDialog();
                    }
                }
            }
            else
            {
                MessageBox.Show("Bitte wählen Sie einen Kunden aus, den Sie bearbeiten möchten.");
            }
        }

        private void KundeLoeschen_Click(object sender, RoutedEventArgs e)
        {
            if (KundeListe.SelectedItems.Count > 0)
            {
                MessageBoxResult result = MessageBox.Show("Möchten Sie die ausgewählten Kunden wirklich löschen?", "Kunden löschen", MessageBoxButton.YesNo, MessageBoxImage.Warning);
                if (result == MessageBoxResult.Yes)
                {
                    using (var context = new AuftragsverwaltungDbContext())
                    {
                        foreach (var selectedItem in KundeListe.SelectedItems)
                        {
                            dynamic selectedKunde = selectedItem;
                            string vorname = selectedKunde.Vorname;
                            string nachname = selectedKunde.Nachname;

                            var kunde = context.Kunde.FirstOrDefault(k => k.Vorname == vorname && k.Nachname == nachname);
                            if (kunde != null)
                            {
                                context.Kunde.Remove(kunde);
                            }
                        }

                        context.SaveChanges();
                    }

                    // Aktualisiere die Kundenliste nach dem Löschen
                    SucheKunde(string.Empty); // Suche mit leerem Suchbegriff, um alle Kunden zu laden
                }
            }
            else
            {
                MessageBox.Show("Bitte wählen Sie mindestens einen Kunden aus, den Sie löschen möchten.");
            }
        }
    }
}
