using BlogSpotMvc.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace BlogSpotMvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            IEnumerable<MvcBlog> adminlist;
            HttpResponseMessage response = GlobalVar.WebApiClient.GetAsync("BlogInfoes").Result;
            adminlist = response.Content.ReadAsAsync<IEnumerable<MvcBlog>>().Result;
            return View(adminlist);
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