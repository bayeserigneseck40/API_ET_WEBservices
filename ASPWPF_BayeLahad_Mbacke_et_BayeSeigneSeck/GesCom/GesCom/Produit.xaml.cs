using GesCom.models;
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

namespace GesCom
{
    /// <summary>
    /// Logique d'interaction pour Produit.xaml
    /// </summary>
    public partial class Produit : Window
    {
        NorthwindEntities dataEntities = new NorthwindEntities();
        private DataGrid datagrid;

        public Produit()
        {
            InitializeComponent();
            load();
        }
       
           
           //lister l'ensemble des produits

        public void load()
        {
            dataGridProduit.ItemsSource = dataEntities.Products.ToList();
            datagrid = dataGridProduit;
        }

        //Selectionner un produit pour effectuer une commande

        private void addBtn_Click(object sender, RoutedEventArgs e)
        {
            int Id = (dataGridProduit.SelectedItem as Products).ProductID;
           // MessageBox.Show(Id.ToString());

            var add = new PopupQuantity(Id);
            bool? result = add.ShowDialog();

          /*  var add = new AjouterCommande(Id);
            bool? result = add.ShowDialog();*/
             
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
            bool? result = fd.ShowDialog();
        }

        private void Produit_click(object sender, RoutedEventArgs e)
        {
            var fd = new Produit();
            bool? result = fd.ShowDialog();
        }
    }
}
