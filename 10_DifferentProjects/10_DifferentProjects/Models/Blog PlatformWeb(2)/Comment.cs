using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace _10_DifferentProjects.Models.Blog_PlatformWeb_2_
{
    public class Comment
    {
        public int ID { get; set; }
        public string Description_Comment { get; set; }

        //Relation (1) with Post
        [ForeignKey("Post")]
        public int ID_Post { get; set; }
        public Post Post { get; set; }

        //Relation (2)
        public ICollection<CommentTag> CommentTag { get; set; }
    }
}
