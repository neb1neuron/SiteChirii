using SiteChirii.Models;
using System.IO;
using System.Linq;
using System.Web.Mvc;

namespace SiteChirii.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.SiteName = "Unde stau in Cluj?";
            ViewBag.Message = @"Vrei sa dai in chirie apartamentul sau cauti chirie? Ai ajuns in locul potrivit. 
                                Tot aici mai poti gasi coleg de chirie daca nu ai deja unul. Doamne ajuta!";

            var RentModels = new RentModel()
            {
                ImagePaths = Directory.EnumerateFiles(Server.MapPath("~/Content/Poze"))
                                  .Select(fn => "~/Content/Poze/" + Path.GetFileName(fn)),
                Price = 300
            };
            return View(RentModels);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Rules()
        {
            throw new System.NotImplementedException();
        }
    }
}
