using BlogSpotMvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace BlogSpotMvc.Controllers
{
    public class BlogSPotController : Controller
    {
        
        public IActionResult Index()
        {
            IEnumerable<MvcBlog> adminlist;
            HttpResponseMessage response = GlobalVar.WebApiClient.GetAsync("BlogInfoes").Result;
            adminlist = response.Content.ReadAsAsync<IEnumerable<MvcBlog>>().Result;
            return View(adminlist);
        }
        public IActionResult Display()
        {
            IEnumerable<MvcBlog> adminlist;
            HttpResponseMessage response = GlobalVar.WebApiClient.GetAsync("BlogInfoes").Result;
            adminlist = response.Content.ReadAsAsync<IEnumerable<MvcBlog>>().Result;
            return View(adminlist);
        }
        public IActionResult Create()
        {
            return View(new MvcBlog());
        }
        [HttpPost]
        public IActionResult Create(MvcBlog blog)
        {
            HttpResponseMessage response = GlobalVar.WebApiClient.PostAsJsonAsync("BlogInfoes",blog).Result;
            return RedirectToAction("Display");
        }
        public IActionResult Logout()
        {
            return RedirectToAction("Index", "BlogSPot");
        }
    }
}
