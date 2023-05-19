using System.ComponentModel.DataAnnotations;

namespace GestionCommandeASP.models
{
    public class Order_Details
    {
        [Key]
        public int OrderID { get; set; }
        public int productID { get; set; }
        public decimal UnitPrice { get; set; }
        public short Quantity { get; set; }
        public float Discount { get; set; }

        public static implicit operator Order_Details(Details v)
        {
            throw new NotImplementedException();
        }
    }
}
