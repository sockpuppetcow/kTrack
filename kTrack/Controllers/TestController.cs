using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Identity;

namespace kTrack.Controllers
{
    [AllowAnonymous]
    public class TestController : Controller
    {
        private readonly UserManager<IdentityUser> _userManager;
        
        public TestController(UserManager<IdentityUser> userManager)
        {
            _userManager = userManager;
        }

        public IActionResult Index()
        {
            string content = User.Identity.IsAuthenticated + "\n"
                + User.Identity.Name + "\n"
                + User.Identity.AuthenticationType + "\n"
                + _userManager.GetUserId(this.User);
            return Content(content);
        }
    }
}
