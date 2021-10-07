using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace kTrack.Controllers
{
    [AllowAnonymous]
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            string content = User.Identity.IsAuthenticated + "\n"
                + User.Identity.Name + "\n"
                + User.Identity.AuthenticationType;
            return Content(content);
        }
    }
}
