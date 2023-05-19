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
    /// Logique d'interaction pour Window2.xaml
    /// </summary>
    public partial class Window2 : Window
    {
        NorthwindEntities dataEntities = new NorthwindEntities();
        public Window2()
        {
            InitializeComponent();
            dataGrid3.Visibility = Visibility.Collapsed;

        }

        private void dataGrid1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
        //fonction pour afficher l'ensemble des commandes qui ont ete effectuées
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var query =
        from orders in dataEntities.Orders
        select new { orders.OrderID, orders.OrderDate, orders.CustomerID, orders.ShipName };
            dataGrid1.ItemsSource = query.ToList();
          
          
        }
        //filter la liste des commandes par customerid
        private void Recher_customer(object sender, RoutedEventArgs e)
        {
            dataGrid3.Visibility = Visibility.Visible;
            string dt = this.textCom2.Text;
            var query =
               from orders in dataEntities.Orders
               where orders.CustomerID==dt
               select new { orders.OrderID, orders.OrderDate, orders.CustomerID, orders.ShipName };
          
            dataGrid3.ItemsSource = query.ToList();           
        }

        private void Retourner(object sender, RoutedEventArgs e)
        {
            var fd = new MainWindow();
            bool? result = fd.ShowDialog();
        }

        private void textbox1_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btnSupprimer_click(object sender, RoutedEventArgs e)
        {

            int id = (dataGrid1.SelectedItem as Orders).OrderID;
            var deleteorder = dataEntities.Orders.Where(o => o.OrderID == id).Single();
            dataEntities.Orders.Remove(deleteorder);
            dataEntities.SaveChanges();
            dataGrid1.ItemsSource = dataEntities.Orders.ToList();
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
