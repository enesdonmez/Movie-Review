using Microsoft.AspNetCore.Mvc;

namespace MovieReview.Web.ViewComponents.LayoutViewComponents
{
    public class _LayoutPreloaderComponentPartial : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
   
}
