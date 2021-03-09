using GeekForums.Data.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GeekForums.Data
{
    public interface IPost
    {
        Post GetById(int id);
        IEnumerable<Post> GetAll();
        IEnumerable<Post> GetFilteredPosts(string searchQuery);
        IEnumerable<Post> GetPostsByForum(int id);
        IEnumerable<Post> GetLatestPost(int n);


        Task Add(Post post);
        Task Delete(int id);
        Task EditPostContent(int id, string newContent);
        
    }
}
