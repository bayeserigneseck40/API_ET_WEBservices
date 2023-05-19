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
    /// Logique d'interaction pour PopupQuantity.xaml
    /// </summary>
    public partial class PopupQuantity : Window
    {
        NorthwindEntities dataEntities = new NorthwindEntities();
        public int id;
       // public short quantity;
        public PopupQuantity(int ID)
        {
            InitializeComponent();
            id= ID;
           

        }

        private void Ajouter_quantite(object sender, RoutedEventArgs e)
        {
            //L'utilisateur saisie la quantite du produit à commander et verifie sa validité
            var quantity = short.Parse(this.textbox12.Text);
            if (quantity <= 0)
                MessageBox.Show("La quantite ne peut inferieur ou egal a 0");
            else
            {
                var produits = (from od in dataEntities.Products
                                where od.ProductID == id
                                select od).First();
                var Qte = produits.UnitsInStock;
                if (quantity <= Qte)
                {
                    var add = new AjouterCommande(quantity, id);
                    bool? result = add.ShowDialog();
                }
                else { MessageBox.Show("La quantite Saisie n'est pas disponible..."); }

            }

        }
    }
}
