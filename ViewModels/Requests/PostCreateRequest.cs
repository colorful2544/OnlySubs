using System.Collections.Generic;
using Microsoft.AspNetCore.Http;

namespace OnlySubs.ViewModels.Requests
{
    public class PostCreateRequest
    {
        public string Description { get; set; }
        public bool IsSub { get; set; }
        public int Price { get; set; }
        public List<IFormFile> Images { get; set; }
    }
}