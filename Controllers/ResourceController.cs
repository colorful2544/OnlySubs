using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using OnlySubs.Services.UserResourceService;

namespace OnlySubs.Controllers
{
    [Authorize]
    [Route("[controller]")]
    public class ResourceController : Controller
    {
        private readonly IUserResourceService _userResourceService;

        public ResourceController(IUserResourceService userResourceService)
        {
            _userResourceService = userResourceService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            string userId = User.Claims.FirstOrDefault(user => user.Type == "id").Value;
            ViewData["Money"] = await _userResourceService.FindMoney(userId);
            return View();
        }
    }
}