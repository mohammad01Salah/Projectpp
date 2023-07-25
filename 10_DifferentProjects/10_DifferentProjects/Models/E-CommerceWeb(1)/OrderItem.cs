using System.ComponentModel.DataAnnotations.Schema;

namespace _10_DifferentProjects.Models.ECommerceWeb_1_
{
    public class OrderItem
    {
        public int ID { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }

        //Relation (1) with ORder
        [ForeignKey("Order")]
        public int ID_Order { get; set; }
        public Order Order { get; set; }
    }
}
