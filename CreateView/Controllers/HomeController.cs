using Microsoft.AspNetCore.Mvc;

namespace CreateView.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
