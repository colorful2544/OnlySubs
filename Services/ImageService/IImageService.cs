using System.Collections.Generic;
using Microsoft.AspNetCore.Http;

namespace OnlySubs.Services.ImageService
{
    public interface IImageService
    {
         string Create(IFormFile image);
         bool ValidatesExtension(List<IFormFile> image, string[] extension);
         bool ValidateExtension(IFormFile image, string[] extension);
    }
}