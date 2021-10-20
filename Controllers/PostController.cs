using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OnlySubs.Services.ImageService;
using OnlySubs.Services.PostService;
using OnlySubs.Services.UserResourceService;
using OnlySubs.ViewModels.Requests;

namespace OnlySubs.Controllers
{
    [Authorize]
    [Route("[controller]")]
    public class PostController : Controller
    {
        private readonly IImageService _imageService;
        private readonly IPostService _postService;
        private readonly IUserResourceService _userResourceService;

        public PostController(IImageService imageService,
                              IPostService postService,
                              IUserResourceService userResourceService)
        {
            _imageService = imageService;
            _postService = postService;
            _userResourceService = userResourceService;
        }
        [HttpGet("create")]
        public async Task<IActionResult> Index()
        {
            string userId = User.Claims.FirstOrDefault(user => user.Type == "id").Value;
            ViewData["Money"] = await _userResourceService.FindMoney(userId);
            return View();
        }
        [HttpPost("create")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Index(PostCreateRequest postCreateRequest)
        {
            string userId = User.Claims.FirstOrDefault(user => user.Type == "id").Value;
            ViewData["Money"] = await _userResourceService.FindMoney(userId);

            if(!ModelState.IsValid) return View(postCreateRequest);

            string[] extention = new string[] {".jpg", ".png"};
            Console.WriteLine(postCreateRequest.Images.Count());
            if(!_imageService.ValidateExtension(postCreateRequest.Images, extention))
            {
                ViewData["ErrorMessage"] = "Please upload an image with a .jpg , .png file extension.";
                return View(postCreateRequest);
            }
            
            string postId = await _postService.CreateAsync(postCreateRequest, userId);

            return Redirect($"/post/{postId}");
        }
        [HttpGet("{postId}")]
        public async Task<IActionResult> FindByPostId(string postId)
        {
            string userId = User.Claims.FirstOrDefault(user => user.Type == "id").Value;
            ViewData["Money"] = await _userResourceService.FindMoney(userId);
            return View();
        }
    }
}