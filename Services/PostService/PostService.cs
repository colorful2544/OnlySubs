using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using OnlySubs.Context;
using OnlySubs.Models;
using OnlySubs.Services.UserService;

namespace OnlySubs.Services.PostService
{
    public class PostService : IPostService
    {
        private readonly OnlySubsContext _db;
        private readonly IUserService _userService;

        public PostService(OnlySubsContext db,
                           IUserService userService)
        {
            _db = db;
            _userService = userService;
        }

        public Task CreateAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task FindByUserId(string userId)
        {
            throw new System.NotImplementedException();
        }

        public Task FindByUsername(string username)
        {
            throw new System.NotImplementedException();
        }

        public async Task<List<ProfilePostImage>> FindFirstImagePost(string userId)
        {
            List<ProfilePostImage> postList = new List<ProfilePostImage>();

            var posts = await _db.Posts.Where(post => post.UserId == userId).ToListAsync();
            foreach(var post in posts)
            {
                string image = await _db.PostsImages.OrderBy(i => i.Created).Select(u => u.ImageName).FirstOrDefaultAsync();
                ProfilePostImage profilePost = new ProfilePostImage
                {
                    ImageName = image,
                    PostId = post.Id
                };
                postList.Add(profilePost);
            }
            return postList;
        }

        public Task UpdateAsync()
        {
            throw new System.NotImplementedException();
        }

        public Task Remove(string postId)
        {
            throw new System.NotImplementedException();
        }
    }
}