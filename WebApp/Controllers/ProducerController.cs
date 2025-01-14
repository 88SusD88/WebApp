using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    public class ProducerController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
