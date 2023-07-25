using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace _10_DifferentProjects.Models.Banking_System
{
    public class Branch
    {
        [Key]
        public int ID { get; set; }
        public string NameBranch { get; set; }

        //Relation 
        public ICollection<Account> Account { get; set; }
    }
}
