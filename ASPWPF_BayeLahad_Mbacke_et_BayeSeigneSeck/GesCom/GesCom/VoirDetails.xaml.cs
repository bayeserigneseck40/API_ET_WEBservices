using GesCom.models;
using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Objects;
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
    /// Logique d'interaction pour VoirDetails.xaml
    /// </summary>
    public partial class VoirDetails : Window
    {
        NorthwindEntities dataEntities = new NorthwindEntities();
        public VoirDetails()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            NorthwindEntities dataEntities = new NorthwindEntities();

        }
        //rechercher une commande avec ses produits la quantite de chaque produit

        private void recherche(object sender, RoutedEventArgs e)
        {
            int dt = int.Parse( this.textCom.Text);

            var query =
            from orderdetails in dataEntities.Order_Details join prod in dataEntities.Products on orderdetails.ProductID equals(prod.ProductID)
            where orderdetails.OrderID == dt
            select new { orderdetails.OrderID, orderdetails.ProductID, orderdetails.UnitPrice, orderdetails.Quantity,orderdetails.Discount,prod.ProductName }
            ;
            dataGrid2.ItemsSource = query.ToList();
        }

        private void Fermer_click(object sender, RoutedEventArgs e)
        {
            this.Close();
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
    
