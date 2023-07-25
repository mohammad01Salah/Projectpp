using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace _10_DifferentProjects.Models.Banking_System
{
    public class Transfer
    {
        [Key]
        public int ID { get; set; }

        //Relation(1) with Account
        [ForeignKey("Account")]
        public int ID_AccountSender { get; set; }
        public Account AccountSender { get; set; }
        //Relation(2) with Account
        [ForeignKey("Account")]
        public int ID_AccountRecive { get; set; }
        public Account AccountRecive { get; set; }
    }
}
