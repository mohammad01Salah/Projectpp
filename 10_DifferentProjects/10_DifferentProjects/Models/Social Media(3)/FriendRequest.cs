using System.ComponentModel.DataAnnotations.Schema;

namespace _10_DifferentProjects.Models.Social_Media_3_
{
    public class FriendRequest
    {
        public int ID { get; set; }

        //Relation(1) with UserSender
        [ForeignKey("User")]
        public int ID_UserSender { get; set; }
        public User UserSender { get; set; }

        //Relation(2) with UserRecive
        [ForeignKey("User")]
        public int ID_UserRecive { get; set; }
        public User UserRecive { get; set; }
    }
}
