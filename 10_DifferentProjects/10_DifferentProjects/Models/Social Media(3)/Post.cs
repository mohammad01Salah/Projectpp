using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace _10_DifferentProjects.Models.Social_Media_3_
{
    public class Post
    {
        public int ID { get; set; }
        public string Descrption { get; set; }

        //Relation(1) with User
        [ForeignKey("User")]
        public int ID_User { get; set; }
        public User User { get; set; }

        //Relation 2
        public ICollection<Like> Like { get; set; }
        public ICollection<Comment> Comment { get; set; }

    }
}
