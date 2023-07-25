using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _10_DifferentProjects.Models.Banking_System
{
    public class Transaction
    {
        [Key]
        public int ID { get; set; }
        public decimal Amount { get; set; }

        //Relation (1) with Account
        [ForeignKey("Account")]
        public int ID_Account { get; set; }
        public Account Account { get; set; }
    }
}
