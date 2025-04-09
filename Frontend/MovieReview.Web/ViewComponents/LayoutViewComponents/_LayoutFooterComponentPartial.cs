using Microsoft.AspNetCore.Mvc;

namespace MovieReview.Web.ViewComponents.LayoutViewComponents
{
    public class _LayoutFooterComponentPartial : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View();
        }
    }
}
