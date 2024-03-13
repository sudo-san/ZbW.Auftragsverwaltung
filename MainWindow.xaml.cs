using Auftragsverwaltung.Views;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Auftragsverwaltung
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OpenKundeWindow(object sender, RoutedEventArgs e)
        {
            KundeWindow kundenWindow = new KundeWindow();
            kundenWindow.Owner = this;
            kundenWindow.ShowDialog();
        }

        private void OpenAdresseWindow(object sender, RoutedEventArgs e)
        {
            AdresseWindow adresseWindow = new AdresseWindow();
            adresseWindow.Owner = this;
            adresseWindow.ShowDialog();
        }

        private void OpenAuftragWindow(object sender, RoutedEventArgs e)
        {
            AuftragWindow auftragWindow = new AuftragWindow();
            auftragWindow.Owner = this;
            auftragWindow.ShowDialog();
        }

        private void OpenArtikelWindow(object sender, RoutedEventArgs e)
        {
            ArtikelWindow artikelWindow = new ArtikelWindow();
            artikelWindow.Owner = this;
            artikelWindow.ShowDialog();
        }

        private void OpenArtikelGruppeWindow(object sender, RoutedEventArgs e)
        {
            ArtikelgruppeWindow artikelgruppeWindow = new ArtikelgruppeWindow();
            artikelgruppeWindow.Owner = this;
            artikelgruppeWindow.ShowDialog();
        }
    }
}