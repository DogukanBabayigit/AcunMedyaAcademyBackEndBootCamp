using Microsoft.AspNetCore.Mvc;

namespace Project08_ProtfolioApp.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        // GET: HomeController
        public ActionResult Index()
        {
            return View();
        }

    }
}
