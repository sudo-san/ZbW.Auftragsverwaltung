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
        public KundeHinzufuegenWindow(KundeWindow parent)
        {
            InitializeComponent();
            parentWindow = parent;
        }

        private void HinzufuegenButton(object sender, RoutedEventArgs e)
        {
            using (var context = new AuftragsverwaltungDbContext())
            {
                var neuerKunde = new Kunde { Vorname = TxtVorname.Text, Nachname = TxtNachname.Text };
                context.Kunde.Add(neuerKunde);
                context.SaveChanges();
            }

            
            this.Close();
        }
    }
}
