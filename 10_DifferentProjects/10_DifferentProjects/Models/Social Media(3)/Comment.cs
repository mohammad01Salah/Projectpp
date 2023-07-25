namespace _10_DifferentProjects.Models.Social_Media_3_
{
    public class Comment
    {
        public int ID { get; set; }

        public string Title_Comment { get; set; }

        //Relation(1) with Post
        public int ID_Post { get; set; }
        public Post Post { get; set; }

    }
}
