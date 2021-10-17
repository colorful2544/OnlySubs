using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OnlySubs.Models.db;
using OnlySubs.Services.PostService;
using OnlySubs.Services.UserResourceService;
using OnlySubs.Services.UserService;
using OnlySubs.ViewModels.Responses;

namespace OnlySubs.Controllers
{
    [Authorize]
    [Route("[controller]")]
    public class AccountController : Controller
    {
        private readonly IUserService _userService;
        private readonly IPostService _postService;
        private readonly IUserResourceService _userResourceService;

        public AccountController(IUserService userService,
                                 IPostService postService,
                                 IUserResourceService userResourceService)
        {
            _userService = userService;
            _postService = postService;
            _userResourceService = userResourceService;
        }

        [HttpGet("{username}")]
        public async Task<IActionResult> Index(string username)
        {
            string userId = User.Claims.FirstOrDefault(user => user.Type == "id").Value;
            ViewData["Money"] = await _userResourceService.FindMoney(userId);
            
            User user = await _userService.FindByUsernameAsync(username);

            if(user == null)
            {
                ViewData["ErrorMessage"] = "Account not found.";
                return View();
            }

            var follower = await _userService.FindFollowerCount(user.Id);
            var following = await _userService.FindFollowingCount(user.Id);
            var resource = await _userResourceService.FindResource(user.Id);
            var postsImage = await _postService.FindFirstImagePost(user.Id);
            
            UserProfileResponse userProfileResponse = new UserProfileResponse
            {
                ImageName = user.ImageName,
                Username = user.Username,
                Description = user.Description,
                Follower = follower,
                Following = following,
                Krama = resource.Krama,
                PostsImage = postsImage
            };
            return View(userProfileResponse);
        }
        [HttpGet("setting")]
        public async Task<IActionResult> Setting()
        {
            string userId = User.Claims.FirstOrDefault(user => user.Type == "id").Value;
            ViewData["Money"] = await _userResourceService.FindMoney(userId);
            return View();
        }
    }
}