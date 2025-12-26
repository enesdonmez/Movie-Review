using Microsoft.AspNetCore.Mvc;

namespace MovieReview.Web.ViewComponents.AdminLayoutViewComponents;

public class _AdminLayoutHeaderComponentPartial : ViewComponent
{
    public IViewComponentResult Invoke()
    {
        return View();
    }
}
