using System.Collections.Generic;

namespace GeekForums.Models.Forum
{
    public class ForumIndexModel
    {
       public IEnumerable<ForumListingModel> ForumList { get; set; }
    }
}
