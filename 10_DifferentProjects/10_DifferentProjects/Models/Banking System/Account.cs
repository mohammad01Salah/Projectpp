using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _10_DifferentProjects.Models.Banking_System
{
    public class Account
    {
        [Key]
        public int ID { get; set; }
        public string AccountNumber { get; set; }
        public string TypeAccount { get; set; }

        //Relation(1) with Branch
        [ForeignKey("Branch")]
        public int ID_Branch { get; set; }
        public Branch Branch { get; set; }

        //Relation(2) with Customer
        [ForeignKey("Customer")]
        public int ID_Customer { get; set; }
        public Customer Customer { get; set; }

        //
        public ICollection<Transfer> TransAccountSender { get; set; }
        public ICollection<Transfer> TransAccountRecive { get; set; }
        // 
        public ICollection<Transaction> Transaction { get; set; }
    }
}
