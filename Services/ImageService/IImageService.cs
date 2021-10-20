using System.Collections.Generic;
using Microsoft.AspNetCore.Http;

namespace OnlySubs.Services.ImageService
{
    public interface IImageService
    {
         string Create(IFormFile image);
         bool ValidateExtension(List<IFormFile> image, string[] extension);
    }
}