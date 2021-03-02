using GeekForums.Data;
using GeekForums.Models.Forum;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace GeekForums.Controllers
{
    public class ForumController : Controller
    {
        private readonly IForum _forumService;
        private readonly IPost _postService;


        public ForumController(IForum forumService)
        {
            _forumService = forumService;
        }

        public IActionResult Index()
        {
            var forums = _forumService.GetAll()
                .Select(selector: forum => new ForumListingModel {
                    Id =forum.Id,
                    Name=forum.Title,
                    Description=forum.Description
                });
            var model = new ForumIndexModel
            {
                ForumList = forums
            };

            return View(model);
        }

        public IActionResult Topic(int id)
        {
            var forum = _forumService.GetById(id);
            var posts = _postService.GetFilteredPosts(id);

            var postlistings = ...
        }
    }
}