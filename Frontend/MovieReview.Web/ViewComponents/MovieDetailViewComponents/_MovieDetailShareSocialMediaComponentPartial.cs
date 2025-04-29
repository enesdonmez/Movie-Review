using Microsoft.AspNetCore.Mvc;

namespace MovieReview.Web.ViewComponents.MovieDetailViewComponents
{
    public class _MovieDetailShareSocialMediaComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
