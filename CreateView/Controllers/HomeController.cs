using Microsoft.AspNetCore.Mvc;

namespace CreateView.Controllers
{
    public class HomeController : Controller
    {
        [Route("/")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
    