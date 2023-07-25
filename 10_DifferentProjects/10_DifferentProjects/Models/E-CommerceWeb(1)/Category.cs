using System.Collections.Generic;

namespace _10_DifferentProjects.Models.ECommerceWeb_1_
{
    public class Category
    {
        public int ID { get; set; }
        public string NameCategory { get; set; }

        public ICollection<Product> Product { get; set; }

    }
}
