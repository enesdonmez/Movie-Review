﻿using Microsoft.AspNetCore.Mvc;

namespace MovieReview.Web.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
