using System.Web.Mvc;

namespace Fw.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
        public ActionResult addwork()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
        public ActionResult addproject()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
        public ActionResult report()
        {
            ViewBag.Title = "Home Page";

            return View();
        }
        public ActionResult DashBorad()
        {
            ViewBag.Title = "Home Page";

            return View();
        }

        public ActionResult Login()
        {
            ViewBag.Title = "Login Page";

            return View();
        }
    }
}
