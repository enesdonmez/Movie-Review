using Microsoft.AspNetCore.Mvc;

namespace MovieReview.Web.ViewComponents.AdminLayoutViewComponents;

public class _AdminLayoutBreadCrumbComponentPartial : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}

