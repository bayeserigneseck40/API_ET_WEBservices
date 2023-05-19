using System.ComponentModel.DataAnnotations;

namespace GestionCommandeASP.models
{
    public class Details
    {
        [Key]
        public int DetailID { get; set; }
        public int OrderID { get; set; }
        public int productID { get; set; }
        public decimal UnitPrice { get; set; }
        public short Quantity { get; set; }
        public float Discount { get; set; }

      
    }
}
