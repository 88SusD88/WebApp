using Microsoft.AspNetCore.Mvc;
using WebApp.Data;
using WebApp.Models;

namespace WebApp.Controllers
{
    public class ProducerController : Controller
    {
        private readonly ApplicationDbContext _db;

        public ProducerController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            IEnumerable<Producer> producerList = _db.Producer;
            return View(producerList);
        }

    }
}
