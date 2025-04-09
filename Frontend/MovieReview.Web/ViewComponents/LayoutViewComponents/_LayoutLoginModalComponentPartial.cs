using Microsoft.AspNetCore.Mvc;

namespace MovieReview.Web.ViewComponents.LayoutViewComponents
{
    public class _LayoutLoginModalComponentPartial : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
