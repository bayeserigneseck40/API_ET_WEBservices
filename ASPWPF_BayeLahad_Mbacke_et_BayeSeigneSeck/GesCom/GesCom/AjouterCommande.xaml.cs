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
    /// Logique d'interaction pour AjouterCommande.xaml
    /// </summary>
    public partial class AjouterCommande : Window
    {
        NorthwindEntities dataEntities = new NorthwindEntities();
        public static ComboBox combo;
        public static ComboBox combo1;
        public int idPP;
        public short quantite;
        public AjouterCommande(short Quantite,int idP)
        {
            InitializeComponent();
            fillcombo();
            idPP = idP;
            quantite=Quantite;
            
        }
        public AjouterCommande()
        {
            InitializeComponent();
            fillcombo();
           
        }

        private void Ajouter_commande(object sender, RoutedEventArgs e)
        {
            var produits = (from od in dataEntities.Products
                            where od.ProductID == idPP
                            select od).First();
            var Qte = produits.UnitsInStock;
            if (quantite <= Qte) { 


            var ods = new Orders {
              //  OrderID = int.Parse(this.textbox1.Text),
                CustomerID = this.textbox29.Text,
                EmployeeID = int.Parse(this.textbox30.Text),
                OrderDate = System.DateTime.Parse(this.textbox7.Text),
                RequiredDate = System.DateTime.Parse(this.textbox8.Text),
                ShippedDate = System.DateTime.Parse(this.textbox9.Text),

                ShipVia = int.Parse(this.textbox10.Text),
                Freight = decimal.Parse(this.textbox16.Text),
                ShipName = this.textbox17.Text,
                ShipAddress = this.textbox15.Text,
                ShipCity = this.textbox11.Text,
                ShipRegion = this.textbox12.Text,
                ShipPostalCode = this.textbox13.Text,
                ShipCountry = this.textbox14.Text
                    

            };
    
            dataEntities.Orders.Add(ods);
            dataEntities.SaveChanges();

            //On recupere l'ID apres Insetion
            int maxID = dataEntities.Orders.Max(u => u.OrderID);
           // MessageBox.Show(maxID.ToString());

            //On recpere l'information d'un produit
            
           // MessageBox.Show(produits.ProductID.ToString());
            MessageBox.Show("Commande Enregistrée avec success!!!!");

            var odds = new Order_Details
            {
                OrderID = maxID,
                ProductID = produits.ProductID,
                UnitPrice = (decimal)produits.UnitPrice,
                Quantity = quantite,
                Discount = 0,
            };
            dataEntities.Order_Details.Add(odds);
            dataEntities.SaveChanges();
            MessageBox.Show(" Les Details de la Commande Enregistrée avec success!!!!");
            var OrderUpdate = (from m in dataEntities.Products
                               where m.ProductID == idPP
                               select m).Single(); 
            OrderUpdate.UnitsInStock = (short?)(OrderUpdate.UnitsInStock-quantite);
            dataEntities.SaveChanges();
            
          

            }
            else { MessageBox.Show("La quantite Saisie n'est pas disponible..."); }

        }


        private void Fermer_click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("AU REVOIR!!!!");
            this.Close();
        }

        private void textbox9_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void ComboBox_SelectionChanged_1(object sender, SelectionChangedEventArgs e)
        {

        }
        private void Load()
        {
            textbox29.ItemsSource = dataEntities.Orders.ToList();

            combo = textbox29;
        }

        void fillcombo()
        {
            NorthwindEntities dataEntities = new NorthwindEntities();


            textbox29.ItemsSource = dataEntities.Customers.ToList(); 
                textbox29.DisplayMemberPath = "CustomerID";
            textbox30.ItemsSource = dataEntities.Orders.ToList();
            textbox30.DisplayMemberPath = "EmployeeID";        }
    }
}
