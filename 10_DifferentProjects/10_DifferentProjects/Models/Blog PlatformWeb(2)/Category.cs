using System.Collections.Generic;

namespace _10_DifferentProjects.Models.Blog_PlatformWeb_2_
{
    public class Category
    {
        public int ID { get; set; }

        public string Name_Category { get; set; }

        //Relation  Category(1) ---> Author(M)  || Author(M) --->Category(1)

        public ICollection<Author> Author { get; set; }

    }
}
