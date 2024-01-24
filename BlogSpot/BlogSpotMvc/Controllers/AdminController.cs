using BlogSpotMvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace BlogSpotMvc.Controllers
{
    public class AdminController : Controller
    {
        [HttpGet]
        public ActionResult Index()
        {
            return View(new MvcAdmin());
        }
        [HttpPost]
        public ActionResult Index(MvcAdmin sign)
        {
            IEnumerable<MvcAdmin> adminlist;
            HttpResponseMessage response = GlobalVar.WebApiClient.GetAsync("AdminInfoes").Result;
            adminlist = response.Content.ReadAsAsync<IEnumerable<MvcAdmin>>().Result;
            foreach (MvcAdmin admin in adminlist)
            {
                if (admin.EmailId == sign.EmailId && admin.Password == sign.Password)
                {
                    return RedirectToAction("Index", "Employee");
                }
                else
                {
                    ViewBag.ErrorMessage = "Ivalid Credentials";
                }
            }
            return View();
        }
    }
}
