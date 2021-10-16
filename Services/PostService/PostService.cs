using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using OnlySubs.Context;
using OnlySubs.Models;
using OnlySubs.Models.db;
using OnlySubs.Services.ImageService;
using OnlySubs.Services.UserService;
using OnlySubs.ViewModels.Requests;
using OnlySubs.ViewModels.Responses;

namespace OnlySubs.Services.PostService
{
    public class PostService : IPostService
    {
        private readonly OnlySubsContext _db;
        private readonly IUserService _userService;
        private readonly IImageService _imageService;

        public PostService(OnlySubsContext db,
                           IUserService userService,
                           IImageService imageService)
        {
            _db = db;
            _userService = userService;
            _imageService = imageService;
        }

        public async Task CreateAsync(PostCreateRequest postCreateRequest, string userId)
        {
            string postId = Guid.NewGuid().ToString();
            Post post = new Post
            {
                Id = postId,
                UserId = userId,
                Description = postCreateRequest.Description,
                IsSub = postCreateRequest.IsSub
            };
            _db.Posts.Add(post);

            if(postCreateRequest.IsSub)
            {
                PostsPrice price = new PostsPrice
                {
                    PostId = postId,
                    Price = postCreateRequest.Price
                };
                _db.PostsPrices.Add(price);
            }

            List<string> imagesName = new List<string>();
            foreach(IFormFile image in postCreateRequest.Images)
            {
                string imageName = _imageService.Create(image);
            }
            foreach(string image in imagesName)
            {
                PostsImage postImage = new PostsImage
                {
                    PostId = postId,
                    ImageName = image,
                };
                _db.PostsImages.Add(postImage);
            }

            await _db.SaveChangesAsync();
        }

        public async Task<List<PostResponse>> FindByUsername(string username)
        {
            User user =  await _db.Users.FirstOrDefaultAsync(u => u.Username == username);
            List<Post> post =  await _db.Posts.Where(post => post.UserId == user.Id).ToListAsync();
            
            List<PostResponse> postResponses = new List<PostResponse>();

            foreach(Post item in post)
            {
                List<string> images = await _db.PostsImages.Where(i => i.PostId == item.Id).Select(o => o.ImageName).ToListAsync();
                int likesCount = await _db.PostsLikes.Where(p => p.PostId == item.Id).CountAsync();
                
                List<PostsComment> commentRaw = await _db.PostsComments.Where(p => p.PostId == item.Id).ToListAsync();
                
                List<Comment> commentWarm = new List<Comment>();
                foreach(PostsComment c in commentRaw)
                {
                    User userCom = await _db.Users.FirstOrDefaultAsync(u => u.Id == c.UserId);
                    Comment comment = new Comment
                    {
                        UserImage = userCom.ImageName,
                        Username = userCom.Username,
                        Created = c.Created,
                        Description = c.Description
                    };
                    commentWarm.Add(comment);
                }

                PostResponse postResponse = new PostResponse
                {
                    PostId = item.Id,
                    UserImage = user.ImageName,
                    Username = user.Username,
                    Images = images,
                    LikesCount = likesCount,
                    Comment = commentWarm,
                    Created = item.Created
                };
                postResponses.Add(postResponse);
            }
            return postResponses;
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