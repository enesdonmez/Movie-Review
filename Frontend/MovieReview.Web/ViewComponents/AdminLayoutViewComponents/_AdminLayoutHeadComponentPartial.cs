using Microsoft.AspNetCore.Mvc;

namespace MovieReview.Web.ViewComponents.AdminLayoutViewComponents;

public class _AdminLayoutHeadComponentPartial : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}
