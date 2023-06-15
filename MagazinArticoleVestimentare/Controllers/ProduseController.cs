using MagazinArticoleVestimentare.Data;
using MagazinArticoleVestimentare.Data.Services;
using MagazinArticoleVestimentare.Models;
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

        [HttpPost]
        public IActionResult Create([Bind("ImagineProdusUrle, Nume, Marime, CantitateInStoc, Pret")]Produse produs)
        {

            if (!ModelState.IsValid)
            {
                return View(produs);

            }

            _service.Add(produs);
            return RedirectToAction(nameof(Index));

        }
    }
}
