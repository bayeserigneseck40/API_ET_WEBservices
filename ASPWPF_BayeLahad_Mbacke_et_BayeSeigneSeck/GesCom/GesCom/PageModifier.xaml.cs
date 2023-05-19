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
    /// Logique d'interaction pour PageModifier.xaml
    /// </summary>
    public partial class PageModifier : Window
    {
        NorthwindEntities dataEntities = new NorthwindEntities();
        int orderid;
        int prodid;
        //le constructeur da la class PageModifier prend deux argument le numero du produit à modifier et le numero de la commande concerné
        public PageModifier(int orderid,int prodid)
        {
            InitializeComponent();
            this.orderid= orderid;
            this.prodid = prodid;

            Load();
            
        }

        private void Update_click(object sender, RoutedEventArgs e)
        {
            //l'utilisateur saisie la nouvelle quantite et valide et la quantite est mise a jour
            var OrderUpdate=(from m in dataEntities.Order_Details
                             where m.OrderID==orderid && m.ProductID==prodid select m).Single();
            OrderUpdate.Quantity = short.Parse(textbox1.Text);
            dataEntities.SaveChanges();
            Essai.datagrid.ItemsSource = dataEntities.Orders.ToList();
            MessageBox.Show("Commande modifie avec success......");
           
        }
        private void Load()
        {
            // on recupere la quantite du produit à modifier et la charge dans le textbox
            var query =(
          from details in dataEntities.Order_Details 
          where details.OrderID==orderid && details.ProductID == prodid
          select new { details.OrderID, details.ProductID, details.Quantity,details.UnitPrice,
              }).Single();



            textbox1.Text = (query.Quantity).ToString();
        }

        private void FERMER_CLICK(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Au revoir.....");
            this.Close();
        }

        private void textbox4_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
