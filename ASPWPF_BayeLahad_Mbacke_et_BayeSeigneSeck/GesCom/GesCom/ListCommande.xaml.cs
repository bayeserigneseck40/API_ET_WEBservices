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
    /// Logique d'interaction pour Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        NorthwindEntities dataEntities = new NorthwindEntities();
        public Window1()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var query =
          from orders in dataEntities.Orders
          select new { orders.OrderID, orders.OrderDate, orders.CustomerID, orders.ShipName,orders.ShippedDate,orders.RequiredDate,orders.ShipCity };
            dataGrid1.ItemsSource = query.ToList();
        }
    }
}
