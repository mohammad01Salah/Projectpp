using System.Collections.Generic;

namespace _10_DifferentProjects.Models.Social_Media_3_
{
    public class User
    {
        public int ID { get; set; }
        public string FullName { get; set; }
        public int Age { get; set; }

        //Relation(1) user(1) ->List_REq(M) 
        public ICollection<FriendRequest> FriendSender { get; set; }
        public ICollection<FriendRequest> FriendRecive { get; set; }

    }
}
