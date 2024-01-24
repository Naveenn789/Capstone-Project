using BlogSpotMvc.Models;
using Microsoft.AspNetCore.Mvc;

namespace BlogSpotMvc.Controllers
{
    public class EmployeeController : Controller
    {
        
        public IActionResult Index()
        {
            IEnumerable<MvcEmployee> adminlist;
            HttpResponseMessage response = GlobalVar.WebApiClient.GetAsync("EmpInfoes").Result;
            adminlist = response.Content.ReadAsAsync<IEnumerable<MvcEmployee>>().Result;
            return View(adminlist);
        }
        public IActionResult Create()
        {
            return View(new MvcEmployee());
        }
        [HttpPost]
        public IActionResult Create(MvcEmployee emp)
        {
            HttpResponseMessage response = GlobalVar.WebApiClient.PostAsJsonAsync("EmpInfoes", emp).Result; 
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Login()
        {
            return View(new MvcEmployee());
        }
        [HttpPost]
        public ActionResult Login(MvcEmployee sign)
        {
            IEnumerable<MvcEmployee> adminlist;
            HttpResponseMessage response = GlobalVar.WebApiClient.GetAsync("EmpInfoes").Result;
            adminlist = response.Content.ReadAsAsync<IEnumerable<MvcEmployee>>().Result;
            foreach (MvcEmployee admin in adminlist)
            {
                if (admin.EmailId == sign.EmailId && admin.PassCode == sign.PassCode)
                {
                    return RedirectToAction("Create", "BlogSPot");
                }
                else
                {
                    ViewBag.ErrorMessage = "Ivalid Credentials";
                }
            }
            return View();
        }
        public IActionResult Logout()
        {
            return RedirectToAction("Index","Admin");
        }

    }
}
