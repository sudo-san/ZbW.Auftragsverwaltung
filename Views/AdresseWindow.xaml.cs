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
        }

        private void AdresseHinzufuegen_Click(object sender, RoutedEventArgs e)
        {
            AdresseHinzufuegenWindow adresseHinzufuegen = new AdresseHinzufuegenWindow();
            adresseHinzufuegen.ShowDialog();
        }
    }
}
