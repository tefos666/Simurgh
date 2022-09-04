using Microsoft.AspNetCore.Mvc;

namespace EndPoint.WEB.Areas.User_Side.Controllers
{
    public class DashboardController : Controller
    {
        [Area("User-Side")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
