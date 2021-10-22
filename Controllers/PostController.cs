using System;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OnlySubs.Models.db;
using OnlySubs.Services.BuyService;
using OnlySubs.Services.CommentService;
using OnlySubs.Services.ImageService;
using OnlySubs.Services.PostService;
using OnlySubs.Services.UserResourceService;
using OnlySubs.Services.UserService;
using OnlySubs.ViewModels.Requests;
using OnlySubs.ViewModels.Responses;

namespace OnlySubs.Controllers
{
    [Authorize]
    [Route("[controller]")]
    public class PostController : Controller
    {
        private readonly IImageService _imageService;
        private readonly IPostService _postService;
        private readonly IUserResourceService _userResourceService;
        private readonly IUserService _userService;
        private readonly IBuyPostService _buyPostService;
        private readonly ICommentService _commentService;

        public PostController(IImageService imageService,
                              IPostService postService,
                              IUserResourceService userResourceService,
                              IUserService userService,
                              IBuyPostService buyPostService,
                              ICommentService commentService)
        {
            _imageService = imageService;
            _postService = postService;
            _userResourceService = userResourceService;
            _userService = userService;
            _buyPostService = buyPostService;
            _commentService = commentService;
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
            User user = await _userService.FindByUserIdAsync(userId);
            ViewData["Money"] = await _userResourceService.FindMoney(userId);

            PostResponse result = await _postService.FindByPostId(postId, userId);
            if(result.Images == null) return Redirect($"buy/{postId}");

            ViewData["PostResponse"] = result;
            ViewData["currentUserImage"] = user.ImageName;
            return View();
        }

        [HttpGet("buy/{postId}")]
        public async Task<IActionResult> Buy(string postId)
        {
            string userId = User.Claims.FirstOrDefault(user => user.Type == "id").Value;
            ViewData["Money"] = await _userResourceService.FindMoney(userId);

            Post post = await _buyPostService.FindPost(postId);
            if(post == null)
            {
                return Redirect("/");
            }
            bool isSub = await _buyPostService.IsSub(postId, userId);
            if(isSub)
            {
                return Redirect($"/post/{postId}");
            }

            bool isBuy = await _buyPostService.Buy(userId, postId);
            if(!isBuy)
            {
                return Redirect($"/resource");
            }
            return Redirect($"/post/{postId}");
        }
        [HttpPost("comment/{postId}")]
        public async Task<IActionResult> Comment(string postId, CommentRequest commentRequest)
        {
            if(!ModelState.IsValid) return Redirect($"/post/{postId}");
            string userId = User.Claims.FirstOrDefault(user => user.Type == "id").Value;

            await _commentService.CommentByPostId(userId, postId, commentRequest.Description);
            return Redirect($"/post/{postId}");
        }
    }
}