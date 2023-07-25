using System.ComponentModel.DataAnnotations.Schema;

namespace _10_DifferentProjects.Models.Social_Media_3_
{
    public class Like
    {
        public int ID { get; set; }


        //Relation(1)
        [ForeignKey("Post")]
        public int ID_Post { get; set; }
        public Post Post { get; set; }


    }
}
