using Microsoft.AspNetCore.Mvc;

namespace MovieReview.Web.Controllers
{
    public class MainLayoutController : Controller
    {
        public IActionResult Layout()
        {
            return View();
        }
    }
}
