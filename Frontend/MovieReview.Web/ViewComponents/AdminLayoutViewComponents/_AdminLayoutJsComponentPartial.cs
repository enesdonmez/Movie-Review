using Microsoft.AspNetCore.Mvc;

namespace MovieReview.Web.ViewComponents.AdminLayoutViewComponents;

public class _AdminLayoutJsComponentPartial : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}
