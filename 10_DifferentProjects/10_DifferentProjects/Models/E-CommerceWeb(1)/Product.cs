using System.ComponentModel.DataAnnotations.Schema;

namespace _10_DifferentProjects.Models.ECommerceWeb_1_
{
    public class Product
    {
        public int ID { get; set; }
        public string NameProduct { get; set; }

        //Relation (1) with Category
        [ForeignKey("Category")]
        public int ID_Category { get; set; }
        public Category Category { get; set; }

        //Relation (2) with Order
        [ForeignKey("Order")]
        public int ID_Order { get; set; }
        public Order Order { get; set; }

    }
}
