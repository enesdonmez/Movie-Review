using Microsoft.AspNetCore.Mvc;

namespace MovieReview.Web.Controllers
{
    public class AdminLayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
