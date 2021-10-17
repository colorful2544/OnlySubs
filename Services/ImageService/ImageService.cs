using System;
using System.Collections.Generic;
using System.IO;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.FileProviders;

namespace OnlySubs.Services.ImageService
{
    public class ImageService : IImageService
    {
        public string Create(IFormFile image)
        {
            string fileName = Path.GetFileName(image.FileName);
            string fileExt = Path.GetExtension(fileName);
            string tmpName = Guid.NewGuid().ToString();
            string newFileName = string.Concat(tmpName, fileExt);
            string filePath = new PhysicalFileProvider(Path.Combine(Directory.GetCurrentDirectory(),"wwwroot","Images")).Root + $@"{newFileName}";
        
            using (FileStream fs = System.IO.File.Create(filePath))
            {
                image.CopyTo(fs);
                fs.Flush();
            }
            
            return newFileName;
        }

        public bool ValidateExtension(List<IFormFile> images, string[] extension)
        {
            bool result = false;
            foreach(IFormFile image in images)
            {
                string fileName = Path.GetFileName(image.FileName);
                string fileExt = Path.GetExtension(fileName);
                
                foreach(string ex in extension)
                {
                    if(fileExt == ex)
                    {
                        result = true;
                        break;
                    }
                    else 
                    {
                        result = false;
                    }
                }
            }
            return result;
        }
    }
}