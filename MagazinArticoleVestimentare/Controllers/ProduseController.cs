using Microsoft.AspNetCore.Mvc;

namespace MagazinArticoleVestimentare.Controllers
{
    public class ProduseController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
