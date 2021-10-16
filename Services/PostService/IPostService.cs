using System.Collections.Generic;
using System.Threading.Tasks;
using OnlySubs.Models;
using OnlySubs.ViewModels.Requests;
using OnlySubs.ViewModels.Responses;

namespace OnlySubs.Services.PostService
{
    public interface IPostService
    {
        Task CreateAsync(PostCreateRequest postCreateRequest, string userId);
        Task<List<PostsResponse>> FindsByUsername(string username);
        Task<List<PostResponse>> FindByUsername(string username);
        Task<List<ProfilePostImage>> FindFirstImagePost(string username);
        Task UpdateAsync();
        Task Remove(string postId);
    }
}