using MagazinArticoleVestimentare.Data;
using MagazinArticoleVestimentare.Data.Services;
using Microsoft.AspNetCore.Mvc;

namespace MagazinArticoleVestimentare.Controllers
{
    public class ProduseController : Controller
    {
        private readonly IProduseServices _service;
        public ProduseController(IProduseServices service)
        {
             _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var data = await _service.GetAll();
            return View(data);
        }

        //Get request Produse/Create
        public IActionResult Create()
        {
            return View();
        }
    }
}
