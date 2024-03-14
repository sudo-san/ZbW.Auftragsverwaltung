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
    public partial class KundeHinzufuegenWindow : Window
    {
        private KundeWindow parentWindow;
        private string? existingVorname;
        private string? existingNachname;
        private bool isEditMode = false;

        public KundeHinzufuegenWindow(KundeWindow parent)
        {
            InitializeComponent();
            parentWindow = parent;
        }

        public KundeHinzufuegenWindow(KundeWindow parent, string vorname, string nachname, string mail, string website, string passwort)
        {
            InitializeComponent();
            parentWindow = parent;
            existingVorname = vorname;
            existingNachname = nachname;
            isEditMode = true;

            TxtVorname.Text = vorname;
            TxtNachname.Text = nachname;
            TxtMail.Text = mail;
            TxtWebsite.Text = website;
            TxtPasswort.Text = passwort;
        }

        private void HinzufuegenButton(object sender, RoutedEventArgs e)
        {
            using (var context = new AuftragsverwaltungDbContext())
            {
                if (isEditMode)
                {
                    var kunde = context.Kunde.FirstOrDefault(k => k.Vorname == existingVorname && k.Nachname == existingNachname);
                    if (kunde != null)
                    {
                        kunde.Vorname = TxtVorname.Text;
                        kunde.Nachname = TxtNachname.Text;
                        kunde.Mail = TxtMail.Text;
                        kunde.Website = TxtWebsite.Text;
                        kunde.Passwort = TxtPasswort.Text;
                        context.SaveChanges();
                    }
                }
                else
                {
                    var newKunde = new Kunde
                    {
                        Vorname = TxtVorname.Text,
                        Nachname = TxtNachname.Text,
                        Mail = TxtMail.Text,
                        Website = TxtWebsite.Text,
                        Passwort = TxtPasswort.Text
                    };
                    context.Kunde.Add(newKunde);
                    context.SaveChanges();
                }
            }

            this.Close();
            parentWindow.SucheKunde(string.Empty);
        }
    }
}
