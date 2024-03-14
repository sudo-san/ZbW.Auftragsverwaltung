using Auftragsverwaltung.Models;
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
    /// Interaction logic for AdresseHinzufuegenWindow.xaml
    /// </summary>
    public partial class AdresseHinzufuegenWindow : Window
    {
        private AdresseWindow parentWindow;
        private string? existingStrasse;
        private string? existingOrt;
        private string? existingPLZ;
        private bool isEditMode = false;

        private List<Kunde> kundenListe;
        public AdresseHinzufuegenWindow(AdresseWindow parent)
        {
            InitializeComponent();
            parentWindow = parent;

            FillAdresseComboBox();
        }

        public AdresseHinzufuegenWindow(AdresseWindow parent, string strasse, string ort, string plz)
        {
            InitializeComponent();
            parentWindow = parent;
            existingStrasse = strasse;
            existingOrt = ort;
            existingPLZ = plz;  
            isEditMode = true;

            TxtStrasse.Text = strasse;
            TxtPLZ.Text = plz;
            TxtOrt.Text = ort;

            FillAdresseComboBox();
        }
        private void FillAdresseComboBox()
        {
            using (var context = new AuftragsverwaltungDbContext())
            {
                kundenListe = context.Kunde.ToList();
                foreach (var kunde in kundenListe)
                {
                    CbKunden.Items.Add(kunde);
                }
            }
        }

        private void HinzufuegenButton(object sender, RoutedEventArgs e)
        {
            using (var context = new AuftragsverwaltungDbContext())
            {
                // Wenn wir uns im Bearbeitungsmodus befinden, aktualisieren wir die vorhandene Adresse
                if (isEditMode)
                {
                    var adresse = context.Adresse.FirstOrDefault(k => k.Strasse == existingStrasse && k.PLZ == existingPLZ && k.Ort == existingOrt);
                    if (adresse != null)
                    {
                        adresse.Strasse = TxtStrasse.Text;
                        adresse.PLZ = TxtPLZ.Text;
                        adresse.Ort = TxtOrt.Text;

                        // Änderungen in der Datenbank speichern
                        context.SaveChanges();
                    }
                }
                else // Ansonsten fügen wir eine neue Adresse hinzu
                {
                    var selectedKunde = (Kunde)CbKunden.SelectedItem; // Ausgewählten Kunden aus der ComboBox abrufen
                    var neueAdresse = new Adresse { Strasse = TxtStrasse.Text, PLZ = TxtPLZ.Text, Ort = TxtOrt.Text, KundeId = selectedKunde.KundenNr };

                    // Neue Adresse zur Datenbank hinzufügen
                    context.Adresse.Add(neueAdresse);

                    // Änderungen in der Datenbank speichern
                    context.SaveChanges();
                }
            }


            this.Close();

            parentWindow.SucheAdresse(string.Empty);
        }
    }
}
