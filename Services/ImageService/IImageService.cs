using Microsoft.AspNetCore.Http;

namespace OnlySubs.Services.ImageService
{
    public interface IImageService
    {
         string Create(IFormFile image);
    }
}