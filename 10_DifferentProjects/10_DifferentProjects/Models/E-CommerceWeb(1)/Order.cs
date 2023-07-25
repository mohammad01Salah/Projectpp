using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace _10_DifferentProjects.Models.ECommerceWeb_1_
{
    public class Order
    {
        public int ID { get; set; }

        public ICollection<Product> Product { get; set; }

        //Relation with Customer
        [ForeignKey("Customer")]
        public int ID_Customer { get; set; }
        public Customer Customer { get; set; }

        //Relation (2)
        public ICollection<OrderItem> OrderItem { get; set; }

    }
}
