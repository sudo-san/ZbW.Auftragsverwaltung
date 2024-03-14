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
    /// Interaction logic for ArtikelGruppeHinzufuegenWindow.xaml
    /// </summary>
    public partial class ArtikelGruppeHinzufuegenWindow : Window
    {
        private ArtikelgruppeWindow parentWindow;
        private string? existingBezeichnung;
        private bool isEditMode = false;

        public ArtikelGruppeHinzufuegenWindow(ArtikelgruppeWindow parent)
        {
            InitializeComponent();
            parentWindow = parent;


        }

        public ArtikelGruppeHinzufuegenWindow(ArtikelgruppeWindow parent, string bezeichnung)
        {
            InitializeComponent();
            parentWindow = parent;
            existingBezeichnung = bezeichnung;
            isEditMode = true;

        }
    }
}
