using System.ComponentModel.DataAnnotations.Schema;

namespace _10_DifferentProjects.Models.Blog_PlatformWeb_2_
{
    public class CommentTag
    {
        public int ID { get; set; }

        //Relation (1) with Comment
        [ForeignKey("Comment")]
        public int Id_Comment { get; set; }
        public Comment Comment { get; set; }

        //Relation (2) with Tag
        [ForeignKey("Tag")]
        public int Id_Tag { get; set; }
        public Tag Tag { get; set; }

    }
}
