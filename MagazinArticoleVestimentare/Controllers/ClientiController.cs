using MagazinArticoleVestimentare.Data;
using MagazinArticoleVestimentare.Data.Services;
using Microsoft.AspNetCore.Mvc;

namespace MagazinArticoleVestimentare.Controllers
{
    public class ClientiController : Controller
    {
        private readonly IProduseServices _service;
        public ClientiController(IProduseServices service)
        {
            _service = service;
        }
        public IActionResult Index()
        {
            var totiClientii = _service.GetAll();
            return View(totiClientii);
        }
    }
}
