using Microsoft.AspNetCore.Mvc;

namespace MovieReview.Web.Controllers
{
    public class LoginController : Controller
    {
        [HttpGet]
        public IActionResult SignIn()
        {
            return View();
        }
    }
}
