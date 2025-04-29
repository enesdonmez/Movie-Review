using Microsoft.AspNetCore.Mvc;
using MovieReview.Dto.Dtos.MovieDtos;
using Newtonsoft.Json;

namespace MovieReview.Web.Controllers
{
    public class MovieController(IHttpClientFactory _httpClientFactory) : Controller
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
                var values = JsonConvert.DeserializeObject<List<ResultMovieDto>>(jsonData);
                return View(values);
            }


            return View();
        }

        public async Task<IActionResult> MovieDetail(int id)
        {
            return View();
        }
    }
}
