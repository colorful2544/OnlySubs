using System.Collections.Generic;
using System.Threading.Tasks;
using OnlySubs.Models;
using OnlySubs.ViewModels.Requests;
using OnlySubs.ViewModels.Responses;

namespace OnlySubs.Services.PostService
{
    public interface IPostService
    {
        Task<string> CreateAsync(PostCreateRequest postCreateRequest, string userId);
        Task<List<PostsResponse>> FindsByUsername(string username);
        Task<PostResponse> FindByPostId(string postId);
        Task<List<ProfilePostImage>> FindFirstImagePost(string username);
        Task UpdateAsync();
        Task Remove(string postId);
    }
}