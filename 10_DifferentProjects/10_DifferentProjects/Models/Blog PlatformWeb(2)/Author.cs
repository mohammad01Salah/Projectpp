using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace _10_DifferentProjects.Models.Blog_PlatformWeb_2_
{
    public class Author
    {

        public int ID { get; set; }
        public string Name { get; set; }

        //Relation (1) with Category
        [ForeignKey("Category")]
        public int ID_Category { get; set; }
        public Category Category { get; set; }

        //Relation (2) with Post
        public ICollection<Post> Post { get; set; }

    }
}
