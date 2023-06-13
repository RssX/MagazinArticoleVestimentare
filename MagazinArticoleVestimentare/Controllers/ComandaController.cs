using MagazinArticoleVestimentare.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace MagazinArticoleVestimentare.Controllers
{
    public class ComandaController : Controller
    {
        private readonly AppDbContext _context;

        public ComandaController(AppDbContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var toateComenzile = _context.Comanda.ToList();
            return View(toateComenzile);
        }
    }
}
