using Microsoft.AspNetCore.Mvc;
using MovieReview.Dto.Dtos.AdminMovieDtos;
using MovieReview.Dto.Dtos.AdminMovieDtos;
using Newtonsoft.Json;
using System.Text;

namespace MovieReview.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminMovieController(IHttpClientFactory _httpClientFactory) : Controller
    {
        public async Task<IActionResult> MovieList()
        {
            ViewBag.v1 = "Film Listesi";
            ViewBag.v2 = "Ana Sayfa";
            ViewBag.v3 = "Tüm Filmler";

            var client = _httpClientFactory.CreateClient("MovieReviewAPI");
            var response = await client.GetAsync("Movies/MovieList");
            if (response.IsSuccessStatusCode)
            {
                var jsonData = await response.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<AdminResultMovieDto>>(jsonData);
                return View(values);
            }


            return View();
        }

        public IActionResult CreateMovie()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateMovie(AdminCreateMovieDto createMovieDto)
        {
            var client = _httpClientFactory.CreateClient("MovieReviewAPI");
            var jsonData = JsonConvert.SerializeObject(createMovieDto);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync("Movies/CreateMovie", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("MovieList");
            }
            return View();
        }

     
    }
}
