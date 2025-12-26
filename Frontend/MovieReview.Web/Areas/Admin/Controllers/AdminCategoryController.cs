using Microsoft.AspNetCore.Mvc;
using MovieReview.Dto.Dtos.AdminCategoryDtos;
using Newtonsoft.Json;
using System.Text;

namespace MovieReview.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class AdminCategoryController(IHttpClientFactory _httpClientFactory) : Controller
    {
        public async Task<IActionResult> CategoryList()
        {
            var client = _httpClientFactory.CreateClient("MovieReviewAPI");
            var responseMessage = await client.GetAsync("Categories/CategoryList");
            if (responseMessage.IsSuccessStatusCode)
            {
                var jsonData = await responseMessage.Content.ReadAsStringAsync();
                var values = JsonConvert.DeserializeObject<List<AdminResultCategoryDto>>(jsonData);
                return View(values);
            }
            return View();
        }

        public IActionResult CreateCategory()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateCategory(AdminCreateCategoryDto createCategoryDto)
        {
            var client = _httpClientFactory.CreateClient("MovieReviewAPI");
            var jsonData = JsonConvert.SerializeObject(createCategoryDto);
            StringContent stringContent = new StringContent(jsonData, Encoding.UTF8, "application/json");
            var responseMessage = await client.PostAsync("Categories", stringContent);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("CategoryList");
            }
            return View();
        }

        public async Task<IActionResult> DeleteCategory(int id)
        {
            var client = _httpClientFactory.CreateClient("MovieReviewAPI");
            var responseMessage = await client.DeleteAsync("Categories/DeleteCategory?id=" + id);
            if (responseMessage.IsSuccessStatusCode)
            {
                return RedirectToAction("CategoryList", "AdminCategory", new { area = "Admin" });
            }
            return View();
        }
    }
}
