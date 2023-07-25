using System.Collections.Generic;

namespace _10_DifferentProjects.Models.Blog_PlatformWeb_2_
{
    public class Tag
    {
        public int ID { get; set; }
        public string TitleTag { get; set; }

        //Relation(1) with Tag(1)-->
        public int MyProperty { get; set; }

        //Relation (2)
        public ICollection<CommentTag> CommentTag { get; set; }
    }
}
