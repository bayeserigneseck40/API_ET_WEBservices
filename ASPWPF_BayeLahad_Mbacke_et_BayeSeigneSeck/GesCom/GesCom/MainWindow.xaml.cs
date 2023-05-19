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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GesCom
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void menuListe_Click(object sender, RoutedEventArgs e)
        {
            var fd = new Window2();
            bool? result = fd.ShowDialog();
        }

        private void menuSaisir_Click(object sender, RoutedEventArgs e)
        {
            var fd = new AjouterCommande();
            bool? result = fd.ShowDialog();
        }

        private void menuQuitter_Click(object sender, RoutedEventArgs e)
        {

        }

        private void menuVoir_Details(object sender, RoutedEventArgs e)
        {
            var fd = new VoirDetails();
            bool? result = fd.ShowDialog();
        }

        private void About_click(object sender, RoutedEventArgs e)
        {
            var fd = new Essai();
            bool? result=fd.ShowDialog();
        }

        private void Produit_click(object sender, RoutedEventArgs e)
        {
            var fd = new Produit();
            bool? result = fd.ShowDialog();
        }
    }
}
