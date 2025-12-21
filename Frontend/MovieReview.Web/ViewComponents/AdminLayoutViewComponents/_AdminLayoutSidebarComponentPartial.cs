using Microsoft.AspNetCore.Mvc;

namespace MovieReview.Web.ViewComponents.AdminLayoutViewComponents;

public class _AdminLayoutSidebarComponentPartial : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}
