using Microsoft.AspNetCore.Mvc;
using MovieReview.Dto.Dtos.RegisterDtos;
using Newtonsoft.Json;
using System.Text;

namespace MovieReview.Web.Controllers
{
    public class RegisterController(IHttpClientFactory _httpClientFactory) : Controller
    {

        public IActionResult SignUp()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SignUp(CreateRegisterDto registerDto)
        {
            var client = _httpClientFactory.CreateClient("MovieReviewAPI");
            var json = JsonConvert.SerializeObject(registerDto);
            StringContent stringContent = new StringContent(json, Encoding.UTF8, "application/json");
            var response = await client.PostAsync("register", stringContent);
            if (response.IsSuccessStatusCode)
            {
                return RedirectToAction("SignIn", "Login");
            }
            ViewBag.error = "Kayıt başarısız oldu lütfen tekrar deneyiniz!";
            return View();
        }

    }
}
