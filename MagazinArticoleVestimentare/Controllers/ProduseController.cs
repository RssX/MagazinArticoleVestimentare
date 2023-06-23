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
            var data = await _service.GetAllAsync();
            return View(data);
        }

        //Get request Produse/Create
        public IActionResult Create()
        {
            return View();
        }

        //Post request
        [HttpPost]
        public async Task<IActionResult> Create([Bind("ImagineProdusUrle, Nume, Marime, CantitateInStoc, Pret")]Produse produs)
        {

            if (!ModelState.IsValid)
            {
                return View(produs);

            }

            await _service.AddAsync(produs);
            return RedirectToAction(nameof(Index));

        }

        //Get Produse/Detalii/id
        public async Task<IActionResult> Detalii(int id)
        {
            var detaliiProduse = await _service.GetByIdAsync(id);
            if (detaliiProduse == null) return View("NotFound");
            return View(detaliiProduse); 


        }

        //Get request Produse/Create
        public async Task<IActionResult> Edit(int id)
        {
            var detaliiProduse = await _service.GetByIdAsync(id);
            if (detaliiProduse == null) return View("NotFound");
            return View(detaliiProduse);
        }

        //Post request
        [HttpPost]
        public async Task<IActionResult> Edit(int id, 
            [Bind("ProdusId, ImagineProdusUrle, Nume, Marime, CantitateInStoc, Pret")] 
            Produse produs)
        {

            if (!ModelState.IsValid)
            {
                return View(produs);

            }

            await _service.UpdateAsync(id, produs);
            return RedirectToAction(nameof(Index));

        }
    }
}
