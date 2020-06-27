using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using TestingProject.DTOs;
using TestingProject.WebApiClient.Models;

namespace TestingProject.WebApiClient.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> Get()
        {
            var cars = Enumerable.Empty<CarDTO>();

            var client = new HttpClient();
            var dataTask = await client.GetAsync("https://localhost:5001/api/car");
            if (dataTask.IsSuccessStatusCode)
                cars = dataTask.Content.ReadAsAsync<IEnumerable<CarDTO>>().Result;

            return View(cars);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
