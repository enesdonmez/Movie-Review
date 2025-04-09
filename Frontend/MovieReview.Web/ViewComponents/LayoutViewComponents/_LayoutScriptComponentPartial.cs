using Microsoft.AspNetCore.Mvc;

namespace MovieReview.Web.ViewComponents.LayoutViewComponents
{
    public class _LayoutScriptComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
   
}
