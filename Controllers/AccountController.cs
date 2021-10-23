using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OnlySubs.Models.db;
using OnlySubs.Services.PostService;
using OnlySubs.Services.ProfileService;
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
        private readonly IProfileService _profileService;

        public AccountController(IUserService userService,
                                 IPostService postService,
                                 IUserResourceService userResourceService,
                                 IProfileService profileService)
        {
            _userService = userService;
            _postService = postService;
            _userResourceService = userResourceService;
            _profileService = profileService;
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

            var result = await _profileService.FindDetail(userId, user.Id);
            
            ViewData["isFollow"] = await _profileService.IsFollow(userId, user.Id);

            return View(result);
        }
        [HttpGet("setting")]
        public async Task<IActionResult> Setting()
        {
            string userId = User.Claims.FirstOrDefault(user => user.Type == "id").Value;
            ViewData["Money"] = await _userResourceService.FindMoney(userId);
            return View();
        }
        [HttpPost("follow/{username}")]
        public async Task<IActionResult> FollowToggle(string username)
        {
            string userId = User.Claims.FirstOrDefault(user => user.Type == "id").Value;
            User user = await _userService.FindByUsernameAsync(username);

            if(user == null) return Redirect($"/account/{username}");

            await _userService.FollowToggle(userId, user.Id);
            return Redirect($"/account/{username}");
        }
    }
}