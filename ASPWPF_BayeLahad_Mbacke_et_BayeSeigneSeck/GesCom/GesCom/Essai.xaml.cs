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
    /// Logique d'interaction pour Essai.xaml
    /// </summary>
    public partial class Essai : Window
    {
        NorthwindEntities dataEntities = new NorthwindEntities();
        public static DataGrid datagrid;
        public Essai()
        {
            InitializeComponent();
            Load();
        }
        private void Load()
        {
            myDataGrid.ItemsSource = dataEntities.Order_Details.ToList();
            datagrid = myDataGrid;     
        }

        private void deleted_btn_click(object sender, RoutedEventArgs e)
        {    
            //suprimmer une commande on demande à l'utilisateur s'il veut vraiment supprimer si oui on valide la supression
            if (MessageBox.Show("Etes vous sure de vouloir supprimer?", "Confirm", MessageBoxButton.YesNo) == MessageBoxResult.Yes) 
                {
                int id = (myDataGrid.SelectedItem as Order_Details).OrderID;
                
                var deleteorder2 = dataEntities.Orders.Where(o => o.OrderID == id).Single();
                dataEntities.Orders.Remove(deleteorder2);
                dataEntities.SaveChanges();
                myDataGrid.ItemsSource = dataEntities.Orders.ToList();
                MessageBox.Show("SUPPRESSION REUSSI!!!");
                this.Close();
            } 
          
        }

        private void Ajouter_commande(object sender, RoutedEventArgs e)
        {
            var fd = new AjouterCommande();
            bool? result = fd.ShowDialog();

        }

        private void modifier_commande(object sender, RoutedEventArgs e)
        {
            //modifier une commande on recupere l'id du produit qu'on veut modifer et le numero de la commande
         
            int id = (myDataGrid.SelectedItem as Order_Details).ProductID;
            int idOr = (myDataGrid.SelectedItem as Order_Details).OrderID;

            MessageBox.Show(id.ToString());
            MessageBox.Show(idOr.ToString());
            PageModifier modif = new PageModifier(idOr,id);
            modif.ShowDialog();



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

