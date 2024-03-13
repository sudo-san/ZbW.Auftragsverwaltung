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
        }

        private void KundeHinzufuegen(object sender, RoutedEventArgs e)
        {
            KundeHinzufuegenWindow kundeHinzufuegen = new KundeHinzufuegenWindow(this);
            kundeHinzufuegen.Owner = this;
            kundeHinzufuegen.ShowDialog();
        }

        public void KundeHinzufuegenButton(string vorname, string nachname)
        {
            KundeListe.Items.Add(new { Vorname = vorname, Nachname = nachname });

        }
    }
}
