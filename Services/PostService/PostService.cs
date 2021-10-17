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

        public async Task<string> CreateAsync(PostCreateRequest postCreateRequest, string userId)
        {
            string postId = Guid.NewGuid().ToString();
            bool isSub = false;

            if(postCreateRequest.Price > 0)
            {
                isSub = true;
            }

            Post post = new Post
            {
                Id = postId,
                UserId = userId,
                Description = postCreateRequest.Description,
                IsSub = isSub
            };
            _db.Posts.Add(post);

            if(postCreateRequest.Price > 0)
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
                imagesName.Add(imageName);
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

            return postId;
        }
        
        public async Task<List<PostsResponse>> FindsByUsername(string username)
        {
            User user =  await _db.Users.FirstOrDefaultAsync(u => u.Username == username);
            IEnumerable<Post> posts = await _db.Posts.Where(p => p.UserId == user.Id).ToListAsync();

            List<PostsResponse> postsResponses = new List<PostsResponse>(); 
            foreach(Post post in posts)
            {
                string image = await _db.PostsImages.OrderBy(p => p.Id)
                                                    .Where(p => p.PostId == post.Id)
                                                    .Select(p => p.ImageName)
                                                    .FirstOrDefaultAsync();
                
                PostsResponse postResponse = new PostsResponse
                {
                    Username = user.Username,
                    ImageName = image,
                    Created = post.Created
                }; 

                postsResponses.Add(postResponse);
            }

            return postsResponses;
        }

        public async Task<PostResponse> FindByPostId(string postId)
        {
            Post post = await _db.Posts.FirstOrDefaultAsync(p => p.Id == postId);
            User user =  await _db.Users.FirstOrDefaultAsync(u => u.Id == post.UserId);

            List<string> images = await _db.PostsImages.Where(i => i.PostId == post.Id)
                                                       .Select(i => i.ImageName)
                                                       .ToListAsync();
            int likesCount = await _db.PostsLikes.Where(l => l.PostId == postId)
                                                 .CountAsync();
            List<PostsComment> commentRaw = await _db.PostsComments.Where(c => c.PostId == post.Id)
                                                      .ToListAsync();
            List<Comment> commentsWarm = new List<Comment>();
            foreach(PostsComment raw in commentRaw)
            {
                User userComment =  await _db.Users.FirstOrDefaultAsync(u => u.Id == raw.UserId);
                Comment comment = new Comment
                {
                    Username = userComment.Username,
                    UserImage = userComment.ImageName,
                    Description = raw.Description,
                    Created = raw.Created
                };
                commentsWarm.Add(comment);
            }
            
            PostResponse postResponse = new PostResponse
            {
                PostId = post.Id,
                UserImage = user.ImageName,
                Username = user.Username,
                Images = images,
                LikesCount = likesCount,
                Comment = commentsWarm,
                Created = post.Created

            };
            return postResponse;
        }

        public async Task<List<ProfilePostImage>> FindFirstImagePost(string userId)
        {
            List<ProfilePostImage> postList = new List<ProfilePostImage>();

            var posts = await _db.Posts.Where(post => post.UserId == userId)
                                       .ToListAsync();
            foreach(var post in posts)
            {
                string image = await _db.PostsImages.OrderBy(i => i.Created)
                                                    .Select(u => u.ImageName)
                                                    .FirstOrDefaultAsync();
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