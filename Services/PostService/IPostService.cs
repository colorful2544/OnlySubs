using System.Collections.Generic;
using System.Threading.Tasks;
using OnlySubs.Models;

namespace OnlySubs.Services.PostService
{
    public interface IPostService
    {
        Task CreateAsync();
        Task FindByUserId(string userId);
        Task FindByUsername(string username);
        Task<List<ProfilePostImage>> FindFirstImagePost(string username);
        Task UpdateAsync();
        Task Remove(string postId);
    }
}