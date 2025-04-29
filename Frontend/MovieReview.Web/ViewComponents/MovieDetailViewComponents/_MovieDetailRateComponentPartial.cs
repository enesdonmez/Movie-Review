using Microsoft.AspNetCore.Mvc;

namespace MovieReview.Web.ViewComponents.MovieDetailViewComponents
{
    public class _MovieDetailRateComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
