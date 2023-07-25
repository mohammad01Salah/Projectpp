using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace _10_DifferentProjects.Models.Blog_PlatformWeb_2_
{
    public class Post
    {
        public int ID { get; set; }
        public string Description { get; set; }

        //Relation Author(1)-->Post(M) FK
        [ForeignKey("Author")]
        public int ID_Author { get; set; }
        public Author Author { get; set; }

        //Relation(2) with Comment
        public ICollection<Comment> Comment { get; set; }

    }
}
