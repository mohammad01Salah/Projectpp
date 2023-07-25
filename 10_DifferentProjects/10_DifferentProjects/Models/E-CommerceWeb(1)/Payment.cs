using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace _10_DifferentProjects.Models.ECommerceWeb_1_
{
    public class Payment
    {
        public int ID { get; set; }
        public DateTime PaymentDate { get; set; }= DateTime.Now;

        //Relation (1) with Order
        
        public Order Order { get; set; }

        // Relation (2) with customer
        [ForeignKey("Customer")]
        public int ID_Customer { get; set; }
        public Customer Customer { get; set; }
    }
}
