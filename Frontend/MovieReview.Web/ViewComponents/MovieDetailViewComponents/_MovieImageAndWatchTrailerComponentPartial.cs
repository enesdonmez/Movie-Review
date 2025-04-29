using Microsoft.AspNetCore.Mvc;

namespace MovieReview.Web.ViewComponents.MovieDetailViewComponents
{
    public class _MovieImageAndWatchTrailerComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
