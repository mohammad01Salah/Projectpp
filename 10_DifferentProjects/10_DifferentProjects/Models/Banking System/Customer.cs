using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _10_DifferentProjects.Models.Banking_System
{
    public class Customer
    {
        [Key]
        public int ID { get; set; }
        public string Name { get; set; }

        //Relation(1) with Account
        public ICollection<Account> Account { get; set; }
    }
}
