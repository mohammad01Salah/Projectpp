using System.Collections.Generic;

namespace _10_DifferentProjects.Models.ECommerceWeb_1_
{
    public class Customer
    {
        public int ID { get; set; }
        public string Name { get; set; }

        public ICollection<Order> Order { get; set; }
        public ICollection<Payment> Payment { get; set; }


    }
}
