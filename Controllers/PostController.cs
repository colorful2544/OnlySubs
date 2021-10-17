using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OnlySubs.Services.ImageService;
using OnlySubs.Services.PostService;
using OnlySubs.ViewModels.Requests;

namespace OnlySubs.Controllers
{
    [Authorize]
    [Route("[controller]")]
    public class PostController : Controller
    {
        private readonly IImageService _imageService;
        private readonly IPostService _postService;

        public PostController(IImageService imageService,
                              IPostService postService)
        {
            _imageService = imageService;
            _postService = postService;
        }
        [HttpGet("create")]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost("create")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index(PostCreateRequest postCreateRequest)
        {
            if(!ModelState.IsValid) return View(postCreateRequest);

            string[] extention = new string[] {".jpg", ".png"};
            Console.WriteLine(postCreateRequest.Images.Count());
            if(!_imageService.ValidateExtension(postCreateRequest.Images, extention))
            {
                ViewData["ErrorMessage"] = "Please upload an image with a .jpg , .png file extension.";
                return View(postCreateRequest);
            }

            string userId = User.Claims.FirstOrDefault(u => u.Type == "id").Value;
            string postId = await _postService.CreateAsync(postCreateRequest, userId);

            return Redirect($"/post/{postId}");
        }
        [HttpGet("{postId}")]
        public IActionResult FindByPostId(string postId)
        {
            return View();
        }
    }
}