using Microsoft.AspNetCore.Mvc;

namespace EndPoint.WEB.Areas.Admin_Side.Controllers
{
    public class DashboardController : Controller
    {
        [Area("Admin-Side")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
